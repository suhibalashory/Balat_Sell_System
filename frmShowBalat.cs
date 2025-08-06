using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alkirat.Al_3orod
{
	public partial class frmShowBalat : Form
	{
		int _Balata = 0;
		int _EditFromMakzan;
		public frmShowBalat(int Balata,int EditFromMakzan = -1)
		{
			InitializeComponent();
			_Balata = Balata;
			_EditFromMakzan = EditFromMakzan;
		}

		private void frmShowBalat_Load(object sender, EventArgs e)
		{
			uctlBalata1.GetBalatInfo(_Balata);
		}

		private void uctlBalata1_Load(object sender, EventArgs e)
		{

		}

	}
}
