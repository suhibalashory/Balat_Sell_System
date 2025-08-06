using Alkirat2.GlobalClass;
using BissnussLeayr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alkirat2.Alkirat2
{
    public partial class frm_Login: Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FillUserComboBox()
		{
			DataTable userlist = clsUser.GetAllUsersName();

			foreach(DataRow row in userlist.Rows)
			{
				cb_UserList.Items.Add(row["Name"]);
			}
		}

		private void frm_Login_Load(object sender, EventArgs e)
		{
			FillUserComboBox();
			//cb_UserList.SelectedIndex = 0;
			lab_Hour.Text = clsDate.Hour();
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tb_Password.Text))
				return;

			Form frmWindo = new frm_MainWindo(this);
			frmWindo.ShowDialog();

			//if (clsUser.Check_UserNameAndPassword(cb_UserList.Text, tb_Password.Text))
			//{
			//	clsUser currentUser = clsUser.Find(cb_UserList.Text);
			//	Global.CurrentUser = currentUser;

			//	Form frmWindo = new frm_MainWindo(this);
			//	frmWindo.ShowDialog();
			//}
			//else
			//{
			//	MessageBox.Show("", "");
			//}
		}
		
		// to move form
		private bool isDragging = false;
		private Point startPoint;

		private void frm_Login_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				isDragging = true;
				startPoint = new Point(e.X, e.Y);
			}
		}

		private void frm_Login_MouseMove(object sender, MouseEventArgs e)
		{
			if(isDragging)
			{
				Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
				this.Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
			}
		}

		private void frm_Login_MouseUp(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				isDragging = false;
			}
		}
	}
}
