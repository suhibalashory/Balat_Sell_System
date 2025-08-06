using Alkirat2.GlobalClass;
using BissnussLeayrs;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;

namespace Alkirat2.Alkirat2
{
	public partial class frmaddupbalat : Form
	{
		enum Mode { Add = 1, Update = 2 }
		Mode _Mode;

		clsBalata _Balata;
		int _BalataID;

		DataTable dt_BalatType, dt_Makas, dt_MadeIn,dt_Makazen;

		

		public frmaddupbalat()
		{
			InitializeComponent();
			_Mode = Mode.Add;
		}

		public frmaddupbalat(int Balata)
		{
			InitializeComponent();
			_BalataID = Balata;
	

			_Mode = Mode.Update;
		}

		private void _FillCombos()
		{
			dt_BalatType = clsBalatType.GetAll();
			foreach(DataRow dr in dt_BalatType.Rows)
			{
				cb_BalataType.Items.Add(dr[1]);
			}

			dt_MadeIn = clsMadeIn.GetAll();
			foreach(DataRow dr in dt_MadeIn.Rows)
			{
				cb_MadeIn.Items.Add(dr[1]);
			}

			dt_Makas = clsMakas.GetAll();
			foreach(DataRow dr in dt_Makas.Rows)
			{
				cb_Makas.Items.Add(dr[1]);
			}

			dt_Makazen = clsMakzen.GetAll();
			foreach(DataRow dt in dt_Makazen.Rows)
			{
				cb_Makazen.Items.Add(dt[1]);
			}

			cb_Makazen.SelectedIndex = 0;
			cb_BalataType.SelectedIndex = 0;
			cb_MadeIn.SelectedIndex = 0;
			cb_Makas.SelectedIndex = 0;
		}

		private bool HandelImge()
		{


			if (_Balata.Picture_Path != picture_Balat.ImageLocation)
			{
				if (!String.IsNullOrEmpty(_Balata.Picture_Path))
				{
					//first we delete the old image from the folder in case there is any.

					try
					{
						File.Delete(_Balata.Picture_Path);
					}
					catch (IOException)
					{
						// We could not delete the file.
						//log it later   
					}
				}

				if (picture_Balat.ImageLocation != null)
				{
					//then we copy the new image to the image folder after we rename it
					string SourceImageFile = picture_Balat.ImageLocation.ToString();

					if (clsValidate.CopyImageToProjectImagesFolder(ref SourceImageFile))
					{
						picture_Balat.ImageLocation = SourceImageFile;
						return true;
					}
					else
					{
						MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}

			}
			return true;
		}

		private void SetValueUpdate()
		{
			cb_MadeIn.SelectedIndex = cb_MadeIn.FindString(_Balata.MadeIn);
			cb_BalataType.SelectedIndex = cb_BalataType.FindString(_Balata.Type);
			TB_Code.Text = _Balata.Code.ToString();
			cb_Makas.SelectedIndex = cb_Makas.FindString(_Balata.Makas);
			cb_Makazen.SelectedIndex = cb_Makazen.FindString(_Balata.Makzan);
			tb_M_in_B.Text = _Balata.MiterInBox.ToString();
			TB_Salary.Text = _Balata.Salary.ToString();

			if (!String.IsNullOrEmpty(_Balata.Picture_Path))
			{
				picture_Balat.ImageLocation = _Balata.Picture_Path;
			}

			btn_RemovePicture.Visible = !string.IsNullOrEmpty(_Balata.Picture_Path);

			lab_Title.Text = "ثحديث";
			btn.Text = "ثحديث";
		}

		private void TB_Salary_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TB_Salary.Text) || !clsValidate.IsNumber(TB_Salary.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(TB_Salary, "Error");
			}
			else
			{
				errorProvider1.SetError(TB_Code, null);
			}
		}

		private void tb_M_in_B_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tb_M_in_B.Text) || !clsValidate.IsNumber(tb_M_in_B.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(tb_M_in_B, "Error");
			}
			else
			{
				errorProvider1.SetError(TB_Code, null);
			}
		}

		private void btn_AddPicture_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// Process the selected file
				string selectedFilePath = openFileDialog1.FileName;
				picture_Balat.Load(selectedFilePath);
				btn_RemovePicture.Visible = true;
				// ...
			}
		}

		private void btn_RemovePicture_Click(object sender, EventArgs e)
		{
			picture_Balat.ImageLocation = null;
			btn_RemovePicture.Visible = false;
		}

		private void frmaddupblalat_Load(object sender, EventArgs e)
		{
			cb_BalataType.Items.Clear();
			cb_Makas.Items.Clear();
			cb_MadeIn.Items.Clear();
			cb_Makazen.Items.Clear();

			_FillCombos();

			if (_Mode == Mode.Update)
			{
				_Balata = clsBalata.Find(_BalataID);
				SetValueUpdate();
			}
			else
			{
				lab_Title.Text = "اضافة صنف";
				btn.Text = "اضافة";
				_Balata = new clsBalata();
			}
		}

		private int Return_ID_fromCB(ComboBox comboBox,DataTable dt )
		{
			foreach (DataRow dr in dt.Rows)
			{
				if (dr[1].ToString() == comboBox.Text)
					return (int)dr[0];
			}
			return int.MaxValue;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren()){
				MessageBox.Show("Check the Boxis");
				return;
			}

			if (!HandelImge())
				return;

			_Balata.MadeInID = Return_ID_fromCB(cb_MadeIn,dt_MadeIn);
			_Balata.MakazenID = Return_ID_fromCB(cb_Makazen,dt_Makazen);
			_Balata.TypeID = Return_ID_fromCB(cb_BalataType,dt_BalatType);
			_Balata.Code = TB_Code.Text.Trim();
			_Balata.MakasID = Return_ID_fromCB(cb_Makas,dt_Makas);
			_Balata.MiterInBox = Convert.ToSingle(tb_M_in_B.Text.Trim());
			_Balata.Salary = Convert.ToDecimal(TB_Salary.Text.Trim());

			if (picture_Balat.ImageLocation != null)
				_Balata.Picture_Path = picture_Balat.ImageLocation;
			
			if (_Balata.Save())
			{
				MessageBox.Show("Done Seccssfuly", "Saving", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("Saving Faild", "Error", MessageBoxButtons.OK);
				return;
			}

			_BalataID = _Balata.BalatID;
			_Mode = Mode.Update;
			frmaddupblalat_Load(null, null);

		}

	}
}
