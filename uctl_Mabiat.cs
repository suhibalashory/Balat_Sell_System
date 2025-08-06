using BissnussLeayrs;
using System.Windows.Forms;
using Alkirat2.GlobalClass;

namespace Alkirat2.Alkirat2
{
	public partial class uctl_Mabiat : UserControl
	{
		public uctl_Mabiat()
		{
			InitializeComponent();
		}

		private Mabiat _Mabiat= null;

		public void FillInfo(int _MabiatID)
		{
			this._Mabiat = Mabiat.Find(_MabiatID);

			if (_Mabiat != null)
			{
				lab_C_Name.Text = _Mabiat.ClientName;
				lab_C_Phone.Text = _Mabiat.ClientPhone;
				lab_TotalSalary.Text = _Mabiat.TotalSalary.ToString();
				lab_Date.Text = clsDate.Short(_Mabiat.Date);
				dgv_Fauater.DataSource = _Mabiat.FauaterRows;
			}
		}

		private void uctl_Mabiat_Load(object sender, System.EventArgs e)
		{

		}
	}
}
