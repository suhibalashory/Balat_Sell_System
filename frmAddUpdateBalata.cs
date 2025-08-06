using BissnussLeayrs;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Alkirat.GlobalClass;


namespace Alkirat.Al_3orod
{
	public partial class frmAddUpdateBalata : Form
	{
		enum Mode { Add = 1,Update  = 2}
		Mode _Mode;

		int BalataID = -1;
		Balata _Balata;
		DataTable _MakazenName;

		public frmAddUpdateBalata()
		{
			InitializeComponent();
			_Mode = Mode.Add;
		}

		public frmAddUpdateBalata(int BalatID)
		{
			InitializeComponent();
			this.BalataID = BalatID;
			_Mode = Mode.Update;
			
		}

		private void SetValueUpdate()
		{
			TB_Name.Text = _Balata.Name;
			TB_MaidIn.Text = _Balata.MaedIn;
			TB_Code.Text = _Balata.Code.ToString();
			TB_Makas.Text = _Balata.Makas;
			TB_Salary.Text = _Balata.Salary.ToString();

			if(!string.IsNullOrEmpty(_Balata.ImagPath))
				pictureBox1.ImageLocation = _Balata.ImagPath;

			label5.Text = "ثحديث";
			button1.Text = "ثحديث";
		}

		private void frmAddUpdateBalata_Load(object sender, EventArgs e)
		{
			if(_Mode == Mode.Update)
			{
				_Balata = Balata.Find(BalataID);
				SetValueUpdate(); 
			}
			else
			{
				_Balata = new Balata();
			}
		}

		private void FillComboBox()
		{
			_MakazenName = Makzen.GetAll();

				foreach (DataRow row in _MakazenName.Rows)
				{
					cb_MakazenName.Items.Add(row["Name"]);
				}
			
		}

		private bool HandelImage()
		{
			if (pictureBox1.ImageLocation != _Balata.ImagPath)
			{
				if (_Balata.ImagPath != "")
				{
					try
					{
						File.Delete(_Balata.ImagPath);
					}
					catch (IOException ioe)
					{
					}
				}


				if (pictureBox1.ImageLocation != null)
				{
					string NewFile = pictureBox1.ImageLocation.ToString();

					if (Unit.CopyImageToProjectImagesFolder(ref NewFile))
					{
						pictureBox1.ImageLocation = NewFile;
						return true;
					}
					else
					{
						MessageBox.Show("Error in Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}

				}
			}
			return true;
		}

		private void btn_SetPicture_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// Process the selected file
				string selectedFilePath = openFileDialog1.FileName;
				pictureBox1.Load(selectedFilePath);
				// ...
			}
		}

		private int ReturnMakzenID(string MakzanName)
		{
			int ret = 0;
			foreach(DataRow row in _MakazenName.Rows)
			{
				if(MakzanName == (string)row[1])
				{
					ret = (int)row[0];
				}
			}
			return ret;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//if (!HandelImage())
			//	return;

			_Balata.Name = TB_Name.Text.Trim();
			_Balata.MaedIn = TB_MaidIn.Text.Trim();
			_Balata.MakazenID = ReturnMakzenID(cb_MakazenName.Text) ;
			_Balata.Code = Convert.ToInt32(TB_Code.Text);
			_Balata.Makas = TB_Makas.Text.Trim();
			_Balata.Salary = Convert.ToDecimal(TB_Salary.Text.Trim());
			
		//	_Balata.ImagPath = pictureBox1.ImageLocation;


			if (_Balata.Save())
			{
				MessageBox.Show("Done Seccssfuly", "Saving", MessageBoxButtons.OK);
			}
		}

	}
}
