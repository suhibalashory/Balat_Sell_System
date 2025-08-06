namespace Alkirat2
{
	partial class frmAlkirat2
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
			this.contextMenuStrip_B = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_F = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.تسديدالقيمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage_Balat = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.cb_Balata_TypeAndMakas = new System.Windows.Forms.ComboBox();
			this.lab_BalatRecord = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_BalatFilter = new System.Windows.Forms.TextBox();
			this.cb_BalatFilter = new System.Windows.Forms.ComboBox();
			this.dgv_BalatList = new System.Windows.Forms.DataGridView();
			this.cb_MakazenList = new System.Windows.Forms.ComboBox();
			this.tc_MakazenInfo = new System.Windows.Forms.TabControl();
			this.btn_Close = new CustomControls.RJControls.RJButton();
			this.uctl_BalatInfo1 = new Controls.uctl_BalatInfo();
			this.rjButton1 = new CustomControls.RJControls.RJButton();
			this.contextMenuStrip_B.SuspendLayout();
			this.contextMenuStrip_F.SuspendLayout();
			this.tabPage_Balat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_BalatList)).BeginInit();
			this.tc_MakazenInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip_B
			// 
			this.contextMenuStrip_B.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.showToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuStrip_B.Name = "contextMenuStrip_B";
			this.contextMenuStrip_B.Size = new System.Drawing.Size(104, 54);
			this.contextMenuStrip_B.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_B_Opening);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.updateToolStripMenuItem.Text = "تعديل";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(100, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.deleteToolStripMenuItem.Text = "حذف";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// contextMenuStrip_F
			// 
			this.contextMenuStrip_F.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسديدالقيمةToolStripMenuItem});
			this.contextMenuStrip_F.Name = "contextMenuStrip1";
			this.contextMenuStrip_F.Size = new System.Drawing.Size(138, 26);
			// 
			// تسديدالقيمةToolStripMenuItem
			// 
			this.تسديدالقيمةToolStripMenuItem.Name = "تسديدالقيمةToolStripMenuItem";
			this.تسديدالقيمةToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.تسديدالقيمةToolStripMenuItem.Text = "تسديد القيمة";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(332, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 45);
			this.label1.TabIndex = 5;
			this.label1.Text = "منظومة الوادي لي الرخام و البورسلين";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(468, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "البضاعة في المعرض";
			// 
			// tabPage_Balat
			// 
			this.tabPage_Balat.Controls.Add(this.uctl_BalatInfo1);
			this.tabPage_Balat.Controls.Add(this.rjButton1);
			this.tabPage_Balat.Controls.Add(this.label7);
			this.tabPage_Balat.Controls.Add(this.cb_Balata_TypeAndMakas);
			this.tabPage_Balat.Controls.Add(this.lab_BalatRecord);
			this.tabPage_Balat.Controls.Add(this.label3);
			this.tabPage_Balat.Controls.Add(this.tb_BalatFilter);
			this.tabPage_Balat.Controls.Add(this.cb_BalatFilter);
			this.tabPage_Balat.Controls.Add(this.dgv_BalatList);
			this.tabPage_Balat.Controls.Add(this.cb_MakazenList);
			this.tabPage_Balat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage_Balat.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Balat.Name = "tabPage_Balat";
			this.tabPage_Balat.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Balat.Size = new System.Drawing.Size(1066, 424);
			this.tabPage_Balat.TabIndex = 0;
			this.tabPage_Balat.Text = "Balat";
			this.tabPage_Balat.UseVisualStyleBackColor = true;
			this.tabPage_Balat.Click += new System.EventHandler(this.tabPage_Balat_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(513, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 19);
			this.label7.TabIndex = 7;
			this.label7.Text = " : مخزن ";
			// 
			// cb_Balata_TypeAndMakas
			// 
			this.cb_Balata_TypeAndMakas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Balata_TypeAndMakas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_Balata_TypeAndMakas.FormattingEnabled = true;
			this.cb_Balata_TypeAndMakas.Location = new System.Drawing.Point(154, 6);
			this.cb_Balata_TypeAndMakas.Name = "cb_Balata_TypeAndMakas";
			this.cb_Balata_TypeAndMakas.Size = new System.Drawing.Size(98, 21);
			this.cb_Balata_TypeAndMakas.TabIndex = 13;
			this.cb_Balata_TypeAndMakas.SelectedIndexChanged += new System.EventHandler(this.cb_Balata_TypeAndMakas_SelectedIndexChanged);
			// 
			// lab_BalatRecord
			// 
			this.lab_BalatRecord.AutoSize = true;
			this.lab_BalatRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_BalatRecord.Location = new System.Drawing.Point(673, 396);
			this.lab_BalatRecord.Name = "lab_BalatRecord";
			this.lab_BalatRecord.Size = new System.Drawing.Size(15, 16);
			this.lab_BalatRecord.TabIndex = 12;
			this.lab_BalatRecord.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(694, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = ": عدد البلاط ";
			// 
			// tb_BalatFilter
			// 
			this.tb_BalatFilter.Location = new System.Drawing.Point(154, 7);
			this.tb_BalatFilter.Name = "tb_BalatFilter";
			this.tb_BalatFilter.Size = new System.Drawing.Size(134, 22);
			this.tb_BalatFilter.TabIndex = 10;
			this.tb_BalatFilter.TextChanged += new System.EventHandler(this.tb_BalatFilter_TextChanged);
			// 
			// cb_BalatFilter
			// 
			this.cb_BalatFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_BalatFilter.FormattingEnabled = true;
			this.cb_BalatFilter.Items.AddRange(new object[] {
            "الجميع",
            "الكود",
            "النوع",
            "المقاس"});
			this.cb_BalatFilter.Location = new System.Drawing.Point(6, 6);
			this.cb_BalatFilter.Name = "cb_BalatFilter";
			this.cb_BalatFilter.Size = new System.Drawing.Size(142, 22);
			this.cb_BalatFilter.TabIndex = 9;
			this.cb_BalatFilter.SelectedIndexChanged += new System.EventHandler(this.cb_BalatFilter_SelectedIndexChanged);
			// 
			// dgv_BalatList
			// 
			this.dgv_BalatList.AllowUserToAddRows = false;
			this.dgv_BalatList.AllowUserToDeleteRows = false;
			this.dgv_BalatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_BalatList.ContextMenuStrip = this.contextMenuStrip_B;
			this.dgv_BalatList.Location = new System.Drawing.Point(6, 33);
			this.dgv_BalatList.Name = "dgv_BalatList";
			this.dgv_BalatList.ReadOnly = true;
			this.dgv_BalatList.Size = new System.Drawing.Size(791, 359);
			this.dgv_BalatList.TabIndex = 3;
			this.dgv_BalatList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BalatList_CellClick);
			this.dgv_BalatList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BalatList_CellContentClick);
			// 
			// cb_MakazenList
			// 
			this.cb_MakazenList.DropDownHeight = 100;
			this.cb_MakazenList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_MakazenList.DropDownWidth = 150;
			this.cb_MakazenList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_MakazenList.FormattingEnabled = true;
			this.cb_MakazenList.IntegralHeight = false;
			this.cb_MakazenList.ItemHeight = 16;
			this.cb_MakazenList.Location = new System.Drawing.Point(386, 6);
			this.cb_MakazenList.Name = "cb_MakazenList";
			this.cb_MakazenList.Size = new System.Drawing.Size(121, 24);
			this.cb_MakazenList.TabIndex = 3;
			this.cb_MakazenList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// tc_MakazenInfo
			// 
			this.tc_MakazenInfo.Controls.Add(this.tabPage_Balat);
			this.tc_MakazenInfo.Location = new System.Drawing.Point(2, 87);
			this.tc_MakazenInfo.Name = "tc_MakazenInfo";
			this.tc_MakazenInfo.SelectedIndex = 0;
			this.tc_MakazenInfo.Size = new System.Drawing.Size(1074, 450);
			this.tc_MakazenInfo.TabIndex = 4;
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
			this.btn_Close.Location = new System.Drawing.Point(1037, 9);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(35, 29);
			this.btn_Close.TabIndex = 7;
			this.btn_Close.Text = "X";
			this.btn_Close.TextColor = System.Drawing.Color.Black;
			this.btn_Close.UseVisualStyleBackColor = false;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// uctl_BalatInfo1
			// 
			this.uctl_BalatInfo1.Location = new System.Drawing.Point(804, 9);
			this.uctl_BalatInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uctl_BalatInfo1.Name = "uctl_BalatInfo1";
			this.uctl_BalatInfo1.Size = new System.Drawing.Size(255, 402);
			this.uctl_BalatInfo1.TabIndex = 15;
			// 
			// rjButton1
			// 
			this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.rjButton1.BorderColor = System.Drawing.Color.Black;
			this.rjButton1.BorderRadius = 8;
			this.rjButton1.BorderSize = 1;
			this.rjButton1.FlatAppearance.BorderSize = 3;
			this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton1.ForeColor = System.Drawing.Color.Black;
			this.rjButton1.Location = new System.Drawing.Point(674, 3);
			this.rjButton1.Name = "rjButton1";
			this.rjButton1.Size = new System.Drawing.Size(116, 27);
			this.rjButton1.TabIndex = 14;
			this.rjButton1.Text = "اضافة بلاطة";
			this.rjButton1.TextColor = System.Drawing.Color.Black;
			this.rjButton1.UseVisualStyleBackColor = false;
			this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
			// 
			// frmAlkirat2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1080, 536);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tc_MakazenInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAlkirat2";
			this.Text = "الخيرات";
			this.Load += new System.EventHandler(this.frmAlkirat_Load);
			this.contextMenuStrip_B.ResumeLayout(false);
			this.contextMenuStrip_F.ResumeLayout(false);
			this.tabPage_Balat.ResumeLayout(false);
			this.tabPage_Balat.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_BalatList)).EndInit();
			this.tc_MakazenInfo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_B;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_F;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تسديدالقيمةToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage_Balat;
		private CustomControls.RJControls.RJButton rjButton1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cb_Balata_TypeAndMakas;
		private System.Windows.Forms.Label lab_BalatRecord;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_BalatFilter;
		private System.Windows.Forms.ComboBox cb_BalatFilter;
		private System.Windows.Forms.DataGridView dgv_BalatList;
		private System.Windows.Forms.ComboBox cb_MakazenList;
		private System.Windows.Forms.TabControl tc_MakazenInfo;
		private CustomControls.RJControls.RJButton btn_Close;
		private Controls.uctl_BalatInfo uctl_BalatInfo1;
	}
}

