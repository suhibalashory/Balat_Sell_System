using BissnussLeayrs;
using System;
using System.IO;
using System.Windows.Forms;

namespace Alkirat.Al_3orod
{
	public partial class uctlBalata : UserControl
	{
		Balata _Balata;
		int _BalataId = -1;
		public uctlBalata()
		{
			InitializeComponent();
		}

		private void SetDefultValues()
		{
			lab_Code.Text = "[----]";
			lab_MaedIn.Text = "[----]";
			lab_Makas.Text = "[----]";
			lab_Name.Text = "[----]";
			lab_Salary.Text = "[----]";
		}

		private void Balata_Load(object sender, EventArgs e)
		{
			SetDefultValues();
		}

		public void GetBalatInfo(int BalatID)
		{
			_BalataId = BalatID;
			_Balata = Balata.Find(_BalataId);

			if (_Balata == null)
			{
				MessageBox.Show("Balat Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			lab_Name.Text = _Balata.Name;
			lab_MaedIn.Text = _Balata.MaedIn;
			lab_Code.Text = _Balata.Code.ToString();
			lab_Salary.Text = _Balata.Salary.ToString();
			lab_Makas.Text = _Balata.Makas.ToString();

			if (!string.IsNullOrEmpty(_Balata.ImagPath))
			{
				pictureBox1.ImageLocation = _Balata.ImagPath;
			}
		}

		private void linklab_Edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmAddUpdateBalata frmupdate = new frmAddUpdateBalata(_BalataId);
			frmupdate.ShowDialog();
		}
	}

}

