using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BissnussLeayrs;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Runtime.InteropServices;
using Alkirat2.Alkirat2;
using Alkirat2.GlobalClass;

namespace Alkirat2.Controls
{
    public partial class uctl_BalatInfo: UserControl
    {
        public uctl_BalatInfo()
        {
            InitializeComponent();
        }

        clsBalata _Balata = null;


		private void SetDefult_Value()
        {
            tb_ID.Text     = "-1";
            tb_Code.Text   = "####";
            tb_MadeIn.Text = "####";
            tb_Makas.Text  = "####";
            tb_Makzan.Text = "####";
            tb_Type.Text   = "####";
            tb_M_in_B.Text = "####";
            pictur_Balat.ImageLocation = null;

            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
		}

		private void uctl_BalatInfo_Load(object sender, EventArgs e)
		{
            SetDefult_Value();
		}


        public void LoadBalatInfo(int BalatID = -1)
        {
            _Balata = clsBalata.Find(BalatID);

            if(_Balata == null)
			{
                SetDefult_Value();
                return;
            }

            tb_ID.Text = _Balata.BalatID.ToString();
            tb_Code.Text = _Balata.Code;
            tb_MadeIn.Text = _Balata.MadeIn;
            tb_Makas.Text = _Balata.Makas;
            tb_Makzan.Text = _Balata.Makzan;
            tb_Type.Text = _Balata.Type;
            tb_M_in_B.Text = _Balata.MiterInBox.ToString();

            if (!string.IsNullOrEmpty(_Balata.Picture_Path))
                pictur_Balat.ImageLocation = _Balata.Picture_Path;

            btn_Delete.Enabled = true;
            btn_Update.Enabled = true;
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
            if(_Balata == null || !Global.CurrentUser.IsAdmin)
            {
                return;
            }

			frmaddupbalat update = new frmaddupbalat(_Balata.BalatID);
			update.ShowDialog();

            LoadBalatInfo(_Balata.BalatID);
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{

		}
	}
}
