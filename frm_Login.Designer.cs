namespace Alkirat2.Alkirat2
{
	partial class frm_Login
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
			this.cb_UserList = new System.Windows.Forms.ComboBox();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.lab_Hour = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btn_Login = new CustomControls.RJControls.RJButton();
			this.btn_Close = new CustomControls.RJControls.RJButton();
			this.SuspendLayout();
			// 
			// cb_UserList
			// 
			this.cb_UserList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_UserList.FormattingEnabled = true;
			this.cb_UserList.Location = new System.Drawing.Point(111, 114);
			this.cb_UserList.Name = "cb_UserList";
			this.cb_UserList.Size = new System.Drawing.Size(132, 21);
			this.cb_UserList.TabIndex = 1;
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(111, 151);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '*';
			this.tb_Password.Size = new System.Drawing.Size(132, 20);
			this.tb_Password.TabIndex = 2;
			// 
			// lab_Hour
			// 
			this.lab_Hour.AutoSize = true;
			this.lab_Hour.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lab_Hour.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_Hour.Location = new System.Drawing.Point(12, 15);
			this.lab_Hour.Name = "lab_Hour";
			this.lab_Hour.Size = new System.Drawing.Size(75, 19);
			this.lab_Hour.TabIndex = 3;
			this.lab_Hour.Text = "00:00:00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Andalus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(1, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(391, 50);
			this.label1.TabIndex = 9;
			this.label1.Text = "منظومة الوادي لسرميك و البرسلين";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(260, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = " : ادخل الرمز ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(260, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = " : المستخدم ";
			// 
			// btn_Login
			// 
			this.btn_Login.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btn_Login.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.btn_Login.BorderColor = System.Drawing.Color.Black;
			this.btn_Login.BorderRadius = 11;
			this.btn_Login.BorderSize = 2;
			this.btn_Login.FlatAppearance.BorderSize = 3;
			this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Login.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Login.ForeColor = System.Drawing.Color.Black;
			this.btn_Login.Location = new System.Drawing.Point(262, 187);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(95, 29);
			this.btn_Login.TabIndex = 10;
			this.btn_Login.Text = "Login";
			this.btn_Login.TextColor = System.Drawing.Color.Black;
			this.btn_Login.UseVisualStyleBackColor = false;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btn_Close.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.btn_Close.BorderColor = System.Drawing.Color.Black;
			this.btn_Close.BorderRadius = 11;
			this.btn_Close.BorderSize = 2;
			this.btn_Close.FlatAppearance.BorderSize = 3;
			this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Close.ForeColor = System.Drawing.Color.Black;
			this.btn_Close.Location = new System.Drawing.Point(357, 5);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(35, 29);
			this.btn_Close.TabIndex = 0;
			this.btn_Close.Text = "X";
			this.btn_Close.TextColor = System.Drawing.Color.Black;
			this.btn_Close.UseVisualStyleBackColor = false;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// frm_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(405, 228);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lab_Hour);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.cb_UserList);
			this.Controls.Add(this.btn_Close);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_Login";
			this.Text = "frm_Login";
			this.Load += new System.EventHandler(this.frm_Login_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_Login_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomControls.RJControls.RJButton btn_Close;
		private System.Windows.Forms.ComboBox cb_UserList;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label lab_Hour;
		private System.Windows.Forms.Label label1;
		private CustomControls.RJControls.RJButton btn_Login;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer1;
	}
}