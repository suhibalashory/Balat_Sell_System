namespace Alkirat2.Alkirat2
{
	partial class frmaddupbalat
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label7 = new System.Windows.Forms.Label();
			this.lab_Title = new System.Windows.Forms.Label();
			this.btn = new System.Windows.Forms.Button();
			this.TB_Salary = new System.Windows.Forms.TextBox();
			this.TB_Code = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.cb_MadeIn = new System.Windows.Forms.ComboBox();
			this.cb_BalataType = new System.Windows.Forms.ComboBox();
			this.cb_Makas = new System.Windows.Forms.ComboBox();
			this.tb_M_in_B = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cb_Makazen = new System.Windows.Forms.ComboBox();
			this.picture_Balat = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btn_RemovePicture = new CustomControls.RJControls.RJButton();
			this.btn_AddPicture = new CustomControls.RJControls.RJButton();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Balat)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(373, 89);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 18);
			this.label7.TabIndex = 41;
			this.label7.Text = " :  المخزن";
			// 
			// lab_Title
			// 
			this.lab_Title.AutoSize = true;
			this.lab_Title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_Title.ForeColor = System.Drawing.Color.Maroon;
			this.lab_Title.Location = new System.Drawing.Point(181, 18);
			this.lab_Title.Name = "lab_Title";
			this.lab_Title.Size = new System.Drawing.Size(114, 23);
			this.lab_Title.TabIndex = 40;
			this.lab_Title.Text = "اضافة صنف";
			// 
			// btn
			// 
			this.btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn.Location = new System.Drawing.Point(311, 297);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(126, 30);
			this.btn.TabIndex = 39;
			this.btn.Text = "اضافة";
			this.btn.UseVisualStyleBackColor = true;
			this.btn.Click += new System.EventHandler(this.button1_Click);
			// 
			// TB_Salary
			// 
			this.TB_Salary.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Salary.Location = new System.Drawing.Point(205, 205);
			this.TB_Salary.MaxLength = 10;
			this.TB_Salary.Name = "TB_Salary";
			this.TB_Salary.Size = new System.Drawing.Size(152, 22);
			this.TB_Salary.TabIndex = 37;
			this.TB_Salary.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Salary_Validating);
			// 
			// TB_Code
			// 
			this.TB_Code.Location = new System.Drawing.Point(205, 178);
			this.TB_Code.MaxLength = 10;
			this.TB_Code.Name = "TB_Code";
			this.TB_Code.Size = new System.Drawing.Size(152, 20);
			this.TB_Code.TabIndex = 36;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(372, 267);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 18);
			this.label6.TabIndex = 33;
			this.label6.Text = ": المقاس ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(384, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 18);
			this.label4.TabIndex = 32;
			this.label4.Text = ":    النوع";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(376, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 18);
			this.label3.TabIndex = 31;
			this.label3.Text = ":   السعر   ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(373, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 30;
			this.label2.Text = " :     الكود ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(373, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 18);
			this.label1.TabIndex = 29;
			this.label1.Text = " :    الصنع";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// cb_MadeIn
			// 
			this.cb_MadeIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_MadeIn.FormattingEnabled = true;
			this.cb_MadeIn.Location = new System.Drawing.Point(205, 120);
			this.cb_MadeIn.Name = "cb_MadeIn";
			this.cb_MadeIn.Size = new System.Drawing.Size(152, 21);
			this.cb_MadeIn.TabIndex = 43;
			// 
			// cb_BalataType
			// 
			this.cb_BalataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_BalataType.FormattingEnabled = true;
			this.cb_BalataType.Location = new System.Drawing.Point(205, 147);
			this.cb_BalataType.Name = "cb_BalataType";
			this.cb_BalataType.Size = new System.Drawing.Size(152, 21);
			this.cb_BalataType.TabIndex = 44;
			// 
			// cb_Makas
			// 
			this.cb_Makas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Makas.FormattingEnabled = true;
			this.cb_Makas.Location = new System.Drawing.Point(205, 263);
			this.cb_Makas.Name = "cb_Makas";
			this.cb_Makas.Size = new System.Drawing.Size(152, 21);
			this.cb_Makas.TabIndex = 45;
			// 
			// tb_M_in_B
			// 
			this.tb_M_in_B.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_M_in_B.Location = new System.Drawing.Point(205, 233);
			this.tb_M_in_B.MaxLength = 10;
			this.tb_M_in_B.Name = "tb_M_in_B";
			this.tb_M_in_B.Size = new System.Drawing.Size(152, 22);
			this.tb_M_in_B.TabIndex = 47;
			this.tb_M_in_B.Validating += new System.ComponentModel.CancelEventHandler(this.tb_M_in_B_Validating);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(375, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 18);
			this.label5.TabIndex = 46;
			this.label5.Text = " :   العبوة ";
			// 
			// cb_Makazen
			// 
			this.cb_Makazen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Makazen.FormattingEnabled = true;
			this.cb_Makazen.Location = new System.Drawing.Point(202, 86);
			this.cb_Makazen.Name = "cb_Makazen";
			this.cb_Makazen.Size = new System.Drawing.Size(152, 21);
			this.cb_Makazen.TabIndex = 48;
			// 
			// picture_Balat
			// 
			this.picture_Balat.Location = new System.Drawing.Point(12, 86);
			this.picture_Balat.Name = "picture_Balat";
			this.picture_Balat.Size = new System.Drawing.Size(173, 169);
			this.picture_Balat.TabIndex = 49;
			this.picture_Balat.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(113, 65);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 18);
			this.label8.TabIndex = 50;
			this.label8.Text = " :  الصورة";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btn_RemovePicture
			// 
			this.btn_RemovePicture.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btn_RemovePicture.BackgroundColor = System.Drawing.Color.CornflowerBlue;
			this.btn_RemovePicture.BorderColor = System.Drawing.Color.Black;
			this.btn_RemovePicture.BorderRadius = 10;
			this.btn_RemovePicture.BorderSize = 3;
			this.btn_RemovePicture.FlatAppearance.BorderSize = 3;
			this.btn_RemovePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_RemovePicture.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RemovePicture.ForeColor = System.Drawing.Color.Black;
			this.btn_RemovePicture.Location = new System.Drawing.Point(12, 261);
			this.btn_RemovePicture.Name = "btn_RemovePicture";
			this.btn_RemovePicture.Size = new System.Drawing.Size(87, 33);
			this.btn_RemovePicture.TabIndex = 52;
			this.btn_RemovePicture.Text = "ازالة ";
			this.btn_RemovePicture.TextColor = System.Drawing.Color.Black;
			this.btn_RemovePicture.UseVisualStyleBackColor = false;
			this.btn_RemovePicture.Click += new System.EventHandler(this.btn_RemovePicture_Click);
			// 
			// btn_AddPicture
			// 
			this.btn_AddPicture.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btn_AddPicture.BackgroundColor = System.Drawing.Color.CornflowerBlue;
			this.btn_AddPicture.BorderColor = System.Drawing.Color.Black;
			this.btn_AddPicture.BorderRadius = 10;
			this.btn_AddPicture.BorderSize = 3;
			this.btn_AddPicture.FlatAppearance.BorderSize = 3;
			this.btn_AddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_AddPicture.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_AddPicture.ForeColor = System.Drawing.Color.Black;
			this.btn_AddPicture.Location = new System.Drawing.Point(95, 261);
			this.btn_AddPicture.Name = "btn_AddPicture";
			this.btn_AddPicture.Size = new System.Drawing.Size(86, 32);
			this.btn_AddPicture.TabIndex = 51;
			this.btn_AddPicture.Text = "اضف ";
			this.btn_AddPicture.TextColor = System.Drawing.Color.Black;
			this.btn_AddPicture.UseVisualStyleBackColor = false;
			this.btn_AddPicture.Click += new System.EventHandler(this.btn_AddPicture_Click);
			// 
			// frmaddupbalat
			// 
			this.AcceptButton = this.btn;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(459, 332);
			this.Controls.Add(this.btn_RemovePicture);
			this.Controls.Add(this.btn_AddPicture);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.picture_Balat);
			this.Controls.Add(this.cb_Makazen);
			this.Controls.Add(this.tb_M_in_B);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cb_Makas);
			this.Controls.Add(this.cb_BalataType);
			this.Controls.Add(this.cb_MadeIn);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lab_Title);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.TB_Salary);
			this.Controls.Add(this.TB_Code);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmaddupbalat";
			this.Text = "frmaddupblalat";
			this.Load += new System.EventHandler(this.frmaddupblalat_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Balat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lab_Title;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.TextBox TB_Salary;
		private System.Windows.Forms.TextBox TB_Code;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ComboBox cb_MadeIn;
		private System.Windows.Forms.ComboBox cb_Makas;
		private System.Windows.Forms.ComboBox cb_BalataType;
		private System.Windows.Forms.TextBox tb_M_in_B;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox picture_Balat;
		private System.Windows.Forms.ComboBox cb_Makazen;
		private CustomControls.RJControls.RJButton btn_RemovePicture;
		private CustomControls.RJControls.RJButton btn_AddPicture;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}