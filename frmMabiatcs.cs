using Alkirat2.GlobalClass;
using BissnussLeayrs;
using System;
using System.Data;
using System.Windows.Forms;

namespace Alkirat2.Alkirat2
{
	public partial class frmMabiatcs : Form
	{
		private DataTable dt_Mabiat;
		public frmMabiatcs()
		{
			InitializeComponent();
		}

	
		private void button1_Click(object sender, EventArgs e)
		{
			dgv_Mabiat.DataSource = Mabiat.GetAllBetween(dtp_From.Value, dtp_To.Value);
		}

		private void SetDefultValue()
		{
			dt_Mabiat = Mabiat.GetAll();
			dgv_Mabiat.DataSource = dt_Mabiat;

			if(dt_Mabiat.Rows.Count > 0)
			{

			}

			gb_DateFilter.Visible = false;
			button1.Visible = false;
		}

		private void frmMabiatcs_Load(object sender, EventArgs e)
		{
			tb_FilterBy.Visible = false;
			cb_Filter.SelectedIndex = 0;
		}

		private void SwitchBetweenContols(bool ShowDate = false)
		{
			gb_DateFilter.Visible = ShowDate;
			button1.Visible = ShowDate;

			tb_FilterBy.Visible = !ShowDate;

			if(gb_DateFilter.Visible)
			{
				dtp_From.Value = DateTime.Now.AddDays(-30);
				dtp_To.Value = DateTime.Now;
			}
		}

		private void cb_Filter_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch(cb_Filter.Text)
			{
				case "الجميع":
					SetDefultValue();
					break;

				case "الاسم":
					SetDefultValue();
					tb_FilterBy.Visible = true;
					break;

				case "الرقم":
					SetDefultValue();
					tb_FilterBy.Visible = true;
					break;

				case "التاريخ":
					SwitchBetweenContols(true);
					break;

				default:
					break;

			}
		}

		private void عرضالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmShowFatora((int)dgv_Mabiat.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
		}

		private void حذفالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int M_ID = (int)dgv_Mabiat.Rows[0].Cells[0].Value;

			if (MessageBox.Show("Do you Want Delete it","Anser",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
				return;
				
			Mabiat mbt = Mabiat.Find(M_ID);

			if (mbt != null)
			{
				Mabiat.DeleteMabiate(M_ID);
				MessageBox.Show($"Mabiate ID {M_ID} is Deleteng", "Successfuly");
			}
			else
			{
				MessageBox.Show("Fatora Not Fount!", "Error");
			}
		}
	}
}
