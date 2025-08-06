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
using Alkirat2.GlobalClass;

namespace Alkirat2.Alkirat2
{
	public partial class frmAddMakzan : Form
	{
		private clsMakzen _Makzen;
		private int _MakzenID = -1;
		enum Mode { Add, Update}
		private Mode _Mode = Mode.Add;

		public frmAddMakzan()
		{
			InitializeComponent();

			_Mode = Mode.Add;
		}

		public frmAddMakzan(int MakzanID)
		{
			InitializeComponent();

			_MakzenID = MakzanID;
			_Mode = Mode.Update;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
				return;

			_Makzen.Name = textBox1.Text.Trim();
			_Makzen.Number = textBox2.Text.Trim();

			if(_Makzen.Save())
				MessageBox.Show("Add Succssfuly","Addeing",MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
				MessageBox.Show("Add Fail","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void textBox1_Validating(object sender, CancelEventArgs e)
		{
			if (clsValidate.IsNumber(textBox1.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(textBox1, "Inter Name");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(textBox1, null);
			}
		}

		private void textBox2_Validating(object sender, CancelEventArgs e)
		{
			if (!clsValidate.IsNumber(textBox2.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(textBox2, "Inter Number");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(textBox2, null);
			}
		}

		private void frmAddMakzan_Load(object sender, EventArgs e)
		{
			if(_Mode == Mode.Add)
			{
				this.Text = "اضافة";
				lab_Title.Text = "اضافة مخزن";
				button1.Text = "اضافة";
				_Makzen = new clsMakzen();
			}
			else
			{
				this.Text = "Update";
				lab_Title.Text = "Update";
				button1.Text = "Update";
				_Makzen = clsMakzen.Find(_MakzenID);
				textBox1.Text = _Makzen.Name;
				textBox2.Text = _Makzen.Number;
			}
		}

		private void textBox1_Validated(object sender, EventArgs e)
		{
	
		}
	}
}
