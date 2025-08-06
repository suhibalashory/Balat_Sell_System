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
	public partial class frmShowFatora : Form
	{
		int MabiateFatoraID = 0;
		public frmShowFatora(int FatoraID)
		{
			InitializeComponent();

			this.MabiateFatoraID=FatoraID;
		}

		private void uctl_Mabiat1_Load(object sender, EventArgs e)
		{

		}

		private void frmShowFatora_Load(object sender, EventArgs e)
		{
			uctl_Mabiat1.FillInfo(MabiateFatoraID);
		}
	}
}
