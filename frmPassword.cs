using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alkirat2.GlobalClass;

namespace Alkirat2.Alkirat2
{
	public partial class frmPassword : Form
	{

		public delegate void DataBakeEventHandler(object sender,int Code);
		public event DataBakeEventHandler DataBake;

		int _ID = 0;
		public frmPassword(int ID_Return)
		{
			InitializeComponent();
			_ID = ID_Return;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox.Text.Trim() == Global.CurrentUser.UserPassword )
			{
				DataBake?.Invoke(this,_ID);

				this.Close();
			}
			else
			{
				MessageBox.Show("خطأ في الكود!","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}


	}
}
