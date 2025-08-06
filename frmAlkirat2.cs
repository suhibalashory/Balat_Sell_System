using Alkirat2.Alkirat2;
using BissnussLeayrs;
using System;
using System.Data;
using System.Windows.Forms;
using Alkirat2.GlobalClass;
using System.Collections.Generic;
using System.Linq;


namespace Alkirat2
{
	public partial class frmAlkirat2 : Form
	{
		public frmAlkirat2()
		{
			InitializeComponent();
		}

		/*
		 * Befor Form Lode
		 * 1- Fill combobox Whit Makazen Name.
		 * 2- Select index 0.
		 * 3- Fill Balat and Fauater.
		 *  BalatList = BalatID,Name,Code,MaenIn,Makas,Salary.
		 *  Fauater = BalatID,CountBox,TotalSalary,Date.
		 *
		 * Form Action 
		 * 1- balat and fauater Have Minu 
		 * balat : Add,Edit,show,Delete.
		 * Fauater: add,lock,Delete.
		 * Makazen : Add,Edit,Delete. Be Cearful ????
		 * 
		 */

		DataTable dt_Makazen = new DataTable();
		 DataTable DT_Balat = clsBalata.GetAll();
		DataTable dt_balat = new DataTable();// DT_Balat.DefaultView.ToTable(false, "ID", "النوع", "الكود", "الصنع", "سعر المتر", "المقاس", "المتر في الصندوق");

		private void _FillComboMakazen()
		{
			dt_Makazen = clsMakzen.GetAll();

			cb_MakazenList.Items.Add("الجميع");

			// Get Alat of time
			foreach (DataRow dr in dt_Makazen.Rows)
			{
				cb_MakazenList.Items.Add(dr[0]);
			}

			cb_MakazenList.SelectedIndex = 0;
		}

		private DataTable ReturnColumn(DataTable DT)
		{
			DataTable dt = new DataTable();

			List<string> col = new List<string> {"ID", "النوع", "الكود", "الصنع", "سعر المتر", "المقاس", "المتر في الصندوق" };

			col.ForEach(c => dt.Columns.Add(c));

			dt.Columns[0].DataType = typeof(int);
			
			// Get alat of time
			foreach(DataRow row in DT.Rows)
			{
				dt.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
			}

			return dt;
		}

		private void Refresh_Balats(int _MakzanID = -1)
		{
			if (_MakzanID == -1)
				DT_Balat = clsBalata.GetAll();
			else
				DT_Balat = clsBalata.GetAllBalatsInMakzan(_MakzanID);

			dt_balat = ReturnColumn(DT_Balat);

			dgv_BalatList.DataSource = dt_balat;
			cb_BalatFilter.SelectedIndex = 0;


			if (dgv_BalatList.Rows.Count > 0)
			{
				dgv_BalatList.Columns[0].HeaderText = "ID";
				dgv_BalatList.Columns[0].Width = 50;

				dgv_BalatList.Columns[1].HeaderText = "النوع";
				dgv_BalatList.Columns[1].Width = 100;

				dgv_BalatList.Columns[2].HeaderText = "الكود";
				dgv_BalatList.Columns[2].Width = 100;

				dgv_BalatList.Columns[3].HeaderText = "الصنع";
				dgv_BalatList.Columns[3].Width = 100;

				dgv_BalatList.Columns[4].HeaderText = "سعر المتر";
				dgv_BalatList.Columns[4].Width = 100;

				dgv_BalatList.Columns[5].HeaderText = "المقاس";
				dgv_BalatList.Columns[5].Width = 100;

				dgv_BalatList.Columns[6].HeaderText = "المتر في الصندوق";
				dgv_BalatList.Columns[6].Width = 100;

			}


			lab_BalatRecord.Text = dgv_BalatList.RowCount.ToString();
		}


		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_MakazenList.Text != "الجميع")
			{
				int MID = clsMakzen.Find(cb_MakazenList.Text).MakazenID;
				Refresh_Balats(MID);
			}
			else
			{
				Refresh_Balats();
			}

		}

		// StripMenu Balata ---------------------------
		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{


			comboBox1_SelectedIndexChanged(null, null);
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Enter PassWord Before using delegate

			frmPassword frm = new frmPassword((int)dgv_BalatList.CurrentRow.Cells[0].Value);
			frm.DataBake += CheckPassword;
			frm.ShowDialog();

			comboBox1_SelectedIndexChanged(null, null);
		}

         void CheckPassword(object sender,int BalatID)
	   	 {
				clsBalata.DeleteByID(BalatID);
		 }
		// ===============================================================

		// Befor you Work
		private void frmAlkirat_Load(object sender, EventArgs e)
		{
			_FillComboMakazen();
		}

		// Filter Info 
		private void tb_BalatFilter_TextChanged(object sender, EventArgs e)
		{
			string FilterBalat = "الكود";

			dt_balat.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterBalat, tb_BalatFilter.Text);
			lab_BalatRecord.Text = DT_Balat.Rows.Count.ToString();
		}

		private void _FillComboFilter()
		{
			DataTable dataTable = new DataTable();

			if (cb_BalatFilter.Text == "النوع")
				dataTable = clsBalatType.GetAll();
			else
				dataTable = clsMakas.GetAll();

			cb_Balata_TypeAndMakas.Items.Add("الجميع");

			foreach(DataRow row in dataTable.Rows)
			{
				cb_Balata_TypeAndMakas.Items.Add(row[1].ToString());
			}
		}

		private void cb_BalatFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch(cb_BalatFilter.Text)
			{
				case "الجميع":
					tb_BalatFilter.Visible = false;
					cb_Balata_TypeAndMakas.Visible = false;
					dt_balat.DefaultView.RowFilter = "";
					break;

				case "الكود":
					dt_balat.DefaultView.RowFilter = "";
					cb_Balata_TypeAndMakas.Visible = false;
					tb_BalatFilter.Visible = true;
					tb_BalatFilter.Text = "";
					tb_BalatFilter.Focus();
					break;

				default :
					tb_BalatFilter.Visible = false;
					cb_Balata_TypeAndMakas.Visible = true;
					cb_Balata_TypeAndMakas.Items.Clear();
					_FillComboFilter();
					cb_Balata_TypeAndMakas.SelectedIndex = 0;
					break;
			}

		}

		private void cb_Balata_TypeAndMakas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_Balata_TypeAndMakas.Text == "الجميع")
				dt_balat.DefaultView.RowFilter = "";
			else
				dt_balat.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", cb_BalatFilter.Text, cb_Balata_TypeAndMakas.Text);

			lab_BalatRecord.Text = dgv_BalatList.RowCount.ToString();
		}

		private void contextMenuStrip_B_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			contextMenuStrip_B.Items[0].Enabled = (cb_MakazenList.Text != "All");
			contextMenuStrip_B.Items[1].Enabled = (cb_MakazenList.Text != "All");
		}

		private void rjButton1_Click(object sender, EventArgs e)
		{
			Form frm = new frmaddupbalat();
			frm.ShowDialog();

			comboBox1_SelectedIndexChanged(null, null);
		}

		private void tabPage_Balat_Click(object sender, EventArgs e)
		{

		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close(); 
		}

		private void dgv_BalatList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			uctl_BalatInfo1.LoadBalatInfo((int)dgv_BalatList.CurrentRow.Cells[0].Value);
		}

		private void dgv_BalatList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//uctl_BalatInfo1.LoadBalatInfo((int)dgv_BalatList.CurrentRow.Cells[0].Value);
		}
	}
}
