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
	public partial class frmFawater : Form
	{

		public frmFawater()
		{
			InitializeComponent();
		}

		DataTable dt_Makazn = new DataTable();
		DataTable dt_Fawater = new DataTable();
		 
		private void FillComboBox()
		{
			dt_Makazn = clsMakzen.GetAll();
			cb_MakazenList.Items.Add("All");

			foreach (DataRow row in dt_Makazn.Rows)
				cb_MakazenList.Items.Add(row["Makzan"]);

			// cb_MakazenList.SelectedIndex = 0;
		}

		private DataTable ReturnColumn(DataTable DT)
		{
			DataTable dt = new DataTable();

			List<string> col = new List<string> { "ID", "المخزن", "الكود", "الصناديق", "اجمالي الفاتورة", "الحالة", "التاريخ", "اسم الزبون", "رقم الزبون", "الباقي" };

			col.ForEach(c => dt.Columns.Add(c));

			dt.Columns[0].DataType = typeof(int);

			// Get alat of time
			foreach (DataRow row in DT.Rows)
			{
				dt.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
			}

			return dt;
		}
		private void GetFawaterData(bool BitweenDate = false)
		{
			if(BitweenDate)
			{
				DataTable DTFatora = FauaterAlMakazen.LastMonth_F(dtp_From.Value, dtp_To.Value);
				dt_Fawater = ReturnColumn(DTFatora);
				dgv_Fauater.DataSource = dt_Fawater;
			}
			else
			{
				DataTable DTF = FauaterAlMakazen.Getall();
				dt_Fawater = ReturnColumn(DTF);
				dgv_Fauater.DataSource = dt_Fawater;
			}
		}

		private void RefreshFawaterData(bool BitweenDate = false)
		{
			GetFawaterData(BitweenDate);

			if(dgv_Fauater.Rows.Count > 0)
			{
				dgv_Fauater.Columns[0].HeaderText = "ID";
				dgv_Fauater.Columns[0].Width = 50;

				dgv_Fauater.Columns[1].HeaderText = "المخزن";
				dgv_Fauater.Columns[1].Width = 100;

				dgv_Fauater.Columns[2].HeaderText = "الكود";
				dgv_Fauater.Columns[2].Width = 70;

				dgv_Fauater.Columns[3].HeaderText = "الصناديق";
				dgv_Fauater.Columns[3].Width = 70;

				dgv_Fauater.Columns[4].HeaderText = "اجمالي الفاتورة";
				dgv_Fauater.Columns[4].Width = 100;

				dgv_Fauater.Columns[5].HeaderText = "الحالة"; 
				dgv_Fauater.Columns[5].Width = 60;

				dgv_Fauater.Columns[6].HeaderText = "التاريخ";
				dgv_Fauater.Columns[6].Width = 120;

				dgv_Fauater.Columns[7].HeaderText = "اسم الزبون";
				dgv_Fauater.Columns[7].Width = 100;

				dgv_Fauater.Columns[8].HeaderText = "رقم الزبون";
				dgv_Fauater.Columns[8].Width = 100;

				dgv_Fauater.Columns[9].HeaderText = "الباقي";
				dgv_Fauater.Columns[9].Width = 100;

			}

			lab_FatoraRecord.Text = dgv_Fauater.Rows.Count.ToString();
		}
		private void frmFatoraInfo_Load(object sender, EventArgs e)
		{
			FillComboBox();
			RefreshFawaterData();

			cb_FilterFatora.SelectedIndex = 0;
			cb_MakazenList.SelectedIndex = 0;

			dtp_From.MaxDate = DateTime.Now.AddDays(-1);
			dtp_From.MinDate = DateTime.Now.AddYears(-3);

			dtp_To.MaxDate = DateTime.Now;
			dtp_To.MinDate = DateTime.Now.AddYears(-3);
		}
		private void btn_GetFauaterBetweenDate_Click(object sender, EventArgs e)
		{
			if(dtp_From.Value <= dtp_To.Value)
			{
				MessageBox.Show("", "");
				return; 
			}
			RefreshFawaterData(true);
		}

		private void btn_ShowAll_Click(object sender, EventArgs e)
		{
			RefreshFawaterData();
		}

		private void cb_FilterFatora_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_FilterFatora.Text == "الجميع")
				dt_Fawater.DefaultView.RowFilter = "";
			else
				dt_Fawater.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'","الحالة",cb_FilterFatora.Text);

			lab_FatoraRecord.Text = dt_Fawater.Rows.Count.ToString();
		}

		private void cb_MakazenList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_FilterFatora.Text == "الجميع")
				dt_Fawater.DefaultView.RowFilter = "";
			else
				dt_Fawater.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "المخزن", cb_MakazenList.Text);

			lab_FatoraRecord.Text = dt_Fawater.Rows.Count.ToString();
		}
	}
}
