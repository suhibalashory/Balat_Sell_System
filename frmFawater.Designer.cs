namespace Alkirat2.Alkirat2
{
	partial class frmFawater
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
			this.dgv_Fauater = new System.Windows.Forms.DataGridView();
			this.btn_GetFauaterBetweenDate = new System.Windows.Forms.Button();
			this.gb_DateFilter = new System.Windows.Forms.GroupBox();
			this.dtp_To = new System.Windows.Forms.DateTimePicker();
			this.dtp_From = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lab_FatoraRecord = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cb_FilterFatora = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_MakazenList = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_ShowAll = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Fauater)).BeginInit();
			this.gb_DateFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_Fauater
			// 
			this.dgv_Fauater.AllowUserToAddRows = false;
			this.dgv_Fauater.AllowUserToDeleteRows = false;
			this.dgv_Fauater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Fauater.Location = new System.Drawing.Point(1, 141);
			this.dgv_Fauater.Name = "dgv_Fauater";
			this.dgv_Fauater.ReadOnly = true;
			this.dgv_Fauater.Size = new System.Drawing.Size(810, 341);
			this.dgv_Fauater.TabIndex = 5;
			// 
			// btn_GetFauaterBetweenDate
			// 
			this.btn_GetFauaterBetweenDate.Location = new System.Drawing.Point(540, 74);
			this.btn_GetFauaterBetweenDate.Name = "btn_GetFauaterBetweenDate";
			this.btn_GetFauaterBetweenDate.Size = new System.Drawing.Size(76, 25);
			this.btn_GetFauaterBetweenDate.TabIndex = 28;
			this.btn_GetFauaterBetweenDate.Text = "بحت";
			this.btn_GetFauaterBetweenDate.UseVisualStyleBackColor = true;
			this.btn_GetFauaterBetweenDate.Click += new System.EventHandler(this.btn_GetFauaterBetweenDate_Click);
			// 
			// gb_DateFilter
			// 
			this.gb_DateFilter.Controls.Add(this.dtp_To);
			this.gb_DateFilter.Controls.Add(this.dtp_From);
			this.gb_DateFilter.Controls.Add(this.label5);
			this.gb_DateFilter.Controls.Add(this.label4);
			this.gb_DateFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_DateFilter.Location = new System.Drawing.Point(227, 78);
			this.gb_DateFilter.Name = "gb_DateFilter";
			this.gb_DateFilter.Size = new System.Drawing.Size(307, 47);
			this.gb_DateFilter.TabIndex = 32;
			this.gb_DateFilter.TabStop = false;
			this.gb_DateFilter.Text = "التاريخ";
			// 
			// dtp_To
			// 
			this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_To.Location = new System.Drawing.Point(0, 18);
			this.dtp_To.Name = "dtp_To";
			this.dtp_To.Size = new System.Drawing.Size(99, 22);
			this.dtp_To.TabIndex = 27;
			// 
			// dtp_From
			// 
			this.dtp_From.CustomFormat = "";
			this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_From.Location = new System.Drawing.Point(148, 19);
			this.dtp_From.Name = "dtp_From";
			this.dtp_From.Size = new System.Drawing.Size(101, 22);
			this.dtp_From.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(267, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 14);
			this.label5.TabIndex = 25;
			this.label5.Text = ": من ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(105, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 14);
			this.label4.TabIndex = 24;
			this.label4.Text = ": الي";
			// 
			// lab_FatoraRecord
			// 
			this.lab_FatoraRecord.AutoSize = true;
			this.lab_FatoraRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_FatoraRecord.Location = new System.Drawing.Point(680, 114);
			this.lab_FatoraRecord.Name = "lab_FatoraRecord";
			this.lab_FatoraRecord.Size = new System.Drawing.Size(15, 16);
			this.lab_FatoraRecord.TabIndex = 31;
			this.lab_FatoraRecord.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(706, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 18);
			this.label6.TabIndex = 30;
			this.label6.Text = " : عدد الفواتير ";
			// 
			// cb_FilterFatora
			// 
			this.cb_FilterFatora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_FilterFatora.FormattingEnabled = true;
			this.cb_FilterFatora.Items.AddRange(new object[] {
            "الجميع",
            "خالص",
            "غ.خالص"});
			this.cb_FilterFatora.Location = new System.Drawing.Point(1, 78);
			this.cb_FilterFatora.Name = "cb_FilterFatora";
			this.cb_FilterFatora.Size = new System.Drawing.Size(123, 21);
			this.cb_FilterFatora.TabIndex = 29;
			this.cb_FilterFatora.SelectedIndexChanged += new System.EventHandler(this.cb_FilterFatora_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Andalus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(142, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 56);
			this.label1.TabIndex = 33;
			this.label1.Text = "منظومة الوادي لسرميك و البرسلين";
			// 
			// cb_MakazenList
			// 
			this.cb_MakazenList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_MakazenList.FormattingEnabled = true;
			this.cb_MakazenList.Location = new System.Drawing.Point(1, 105);
			this.cb_MakazenList.Name = "cb_MakazenList";
			this.cb_MakazenList.Size = new System.Drawing.Size(123, 21);
			this.cb_MakazenList.TabIndex = 34;
			this.cb_MakazenList.SelectedIndexChanged += new System.EventHandler(this.cb_MakazenList_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(35, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 16);
			this.label2.TabIndex = 35;
			this.label2.Text = "فلاتر البحت";
			// 
			// btn_ShowAll
			// 
			this.btn_ShowAll.Location = new System.Drawing.Point(540, 105);
			this.btn_ShowAll.Name = "btn_ShowAll";
			this.btn_ShowAll.Size = new System.Drawing.Size(76, 28);
			this.btn_ShowAll.TabIndex = 36;
			this.btn_ShowAll.Text = "الجميع";
			this.btn_ShowAll.UseVisualStyleBackColor = true;
			this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(139, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = ": الحالة";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(130, 106);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = " : المخزن ";
			// 
			// frmFawater
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(814, 481);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_ShowAll);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cb_MakazenList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_GetFauaterBetweenDate);
			this.Controls.Add(this.gb_DateFilter);
			this.Controls.Add(this.lab_FatoraRecord);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cb_FilterFatora);
			this.Controls.Add(this.dgv_Fauater);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmFawater";
			this.Text = "الفواتير";
			this.Load += new System.EventHandler(this.frmFatoraInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Fauater)).EndInit();
			this.gb_DateFilter.ResumeLayout(false);
			this.gb_DateFilter.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_Fauater;
		private System.Windows.Forms.Button btn_GetFauaterBetweenDate;
		private System.Windows.Forms.GroupBox gb_DateFilter;
		private System.Windows.Forms.DateTimePicker dtp_To;
		private System.Windows.Forms.DateTimePicker dtp_From;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lab_FatoraRecord;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cb_FilterFatora;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_MakazenList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_ShowAll;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
	}
}