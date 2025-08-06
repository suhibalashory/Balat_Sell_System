using Alkirat2.GlobalClass;
using BissnussLeayrs;
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
	public partial class frm_Makazen : Form
	{
		public frm_Makazen()
		{
			InitializeComponent(); 
		}

		private DataTable dt_Makazen = new DataTable();

		private DataTable Format_Table()
		{
			List<string> list_col = new List<string> {"ID","Name","Number" };
			list_col.ForEach(l =>
			{
				Type type = l == "ID" ? typeof(int) : typeof(string);
				dt_Makazen.Columns.Add(l, type);
			});

			dt_Makazen = clsMakzen.GetMakazenTableWhitInfo();

			return dt_Makazen;
		}

		private void _FillMakazenDGV()
		{
			dt_Makazen = Format_Table();
			dgv_Makazen.DataSource = dt_Makazen;

			if(dt_Makazen.Rows.Count > 0)
			{
				dgv_Makazen.Columns[0].HeaderText = "ID";
				dgv_Makazen.Columns[0].Width = 50;

				dgv_Makazen.Columns[1].HeaderText = "Name";
				dgv_Makazen.Columns[1].Width = 100;

				dgv_Makazen.Columns[2].HeaderText = "Number";
				dgv_Makazen.Columns[2].Width = 150;

			}

			lab_Count.Text = dt_Makazen.Rows.Count.ToString();
		}

		private void frm_Makazen_Load(object sender, EventArgs e)
		{
			_FillMakazenDGV();
			lab_Houre.Text = clsDate.Hour();
		}

		// Check Is Admin
		private void btn_Add_Click(object sender, EventArgs e)
		{
			Form frmAdd = new frmAddMakzan();
			frmAdd.ShowDialog();

			_FillMakazenDGV();
		}

		private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frmUpdate = new frmAddMakzan((int)dgv_Makazen.CurrentRow.Cells[0].Value);
			frmUpdate.ShowDialog();

			_FillMakazenDGV();
		}

		private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
		{

				
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			bool Admin = Global.CurrentUser.IsAdmin;
			حذفToolStripMenuItem.Enabled = Admin;
			تعديلToolStripMenuItem.Enabled = Admin;
		}
	}
}
