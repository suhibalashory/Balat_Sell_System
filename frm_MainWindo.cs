using System;
using System.Drawing;
using System.Windows.Forms;
using Alkirat2.GlobalClass;
using BissnussLeayr;

namespace Alkirat2.Alkirat2
{
	public partial class frm_MainWindo : Form
	{
		private Form frm_Login;
		public frm_MainWindo(Form frmLogin)
		{
			InitializeComponent();

			this.frm_Login = frmLogin;
		}

		private void frm_MainWindo_Load(object sender, EventArgs e)
		{
			timer1_Tick(this, EventArgs.Empty);
			this.frm_Login.Hide();

			lab_User.Text = Global.CurrentUser.UserName;
		}

		private void btn_Bida3a_Click(object sender, EventArgs e)
		{
			Form frm = new frmAlkirat2();
			frm.ShowDialog();
		}

		private void rjButton5_Click(object sender, EventArgs e)
		{
			Form mabiatcs = new frmMabiatcs();
			mabiatcs.ShowDialog();
		}

		private void btn_Fatora_Click(object sender, EventArgs e)
		{
			Form frm = new frmFatora();
			frm.ShowDialog();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Interval = 1000;
			timer1.Start();
			lab_Houre.Text = clsDate.Hour();
		}

		private void btn_Makazen_Click(object sender, EventArgs e)
		{
			Form frm = new frm_Makazen();
			frm.ShowDialog();
		}

		private void btn_Fawater_Click(object sender, EventArgs e)
		{
			Form frm = new frmFawater();
			frm.ShowDialog();
		}

		private void btn_Out_Click(object sender, EventArgs e)
		{
			this.frm_Login.Show();
			this.Close();
		}

		// to move form
		private bool isDragging = false;
		private Point startPoint;

		private void frm_MainWindo_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				startPoint = new Point(e.X, e.Y);
			}
		}

		private void frm_MainWindo_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging)
			{
				Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
				this.Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
			}
		}

		private void frm_MainWindo_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = false;
			}
		}

		private void btn_Setting_Click(object sender, EventArgs e)
		{
			if (Global.CurrentUser.IsAdmin)
			{
				Form frm_Setting = new frm_Setting();
				frm_Setting.ShowDialog();
			}
			else
				MessageBox.Show("", "");
		}

        private void lab_User_Click(object sender, EventArgs e)
        {

        }
    }
}
