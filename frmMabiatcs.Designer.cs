namespace Alkirat2.Alkirat2
{
	partial class frmMabiatcs
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
			this.dgv_Mabiat = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.عرضالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.حذفالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cb_Filter = new System.Windows.Forms.ComboBox();
			this.tb_FilterBy = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.gb_DateFilter = new System.Windows.Forms.GroupBox();
			this.dtp_To = new System.Windows.Forms.DateTimePicker();
			this.dtp_From = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Mabiat)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gb_DateFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_Mabiat
			// 
			this.dgv_Mabiat.AllowUserToAddRows = false;
			this.dgv_Mabiat.AllowUserToDeleteRows = false;
			this.dgv_Mabiat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Mabiat.ContextMenuStrip = this.contextMenuStrip1;
			this.dgv_Mabiat.Location = new System.Drawing.Point(2, 84);
			this.dgv_Mabiat.Name = "dgv_Mabiat";
			this.dgv_Mabiat.ReadOnly = true;
			this.dgv_Mabiat.Size = new System.Drawing.Size(616, 358);
			this.dgv_Mabiat.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالفاتورةToolStripMenuItem,
            this.toolStripMenuItem1,
            this.حذفالفاتورةToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(141, 54);
			// 
			// عرضالفاتورةToolStripMenuItem
			// 
			this.عرضالفاتورةToolStripMenuItem.Name = "عرضالفاتورةToolStripMenuItem";
			this.عرضالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.عرضالفاتورةToolStripMenuItem.Text = "عرض الفاتورة";
			this.عرضالفاتورةToolStripMenuItem.Click += new System.EventHandler(this.عرضالفاتورةToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 6);
			// 
			// حذفالفاتورةToolStripMenuItem
			// 
			this.حذفالفاتورةToolStripMenuItem.Name = "حذفالفاتورةToolStripMenuItem";
			this.حذفالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.حذفالفاتورةToolStripMenuItem.Text = "حذف الفاتورة";
			this.حذفالفاتورةToolStripMenuItem.Click += new System.EventHandler(this.حذفالفاتورةToolStripMenuItem_Click);
			// 
			// cb_Filter
			// 
			this.cb_Filter.FormattingEnabled = true;
			this.cb_Filter.Items.AddRange(new object[] {
            "الجميع",
            "الاسم",
            "الرقم",
            "التاريخ"});
			this.cb_Filter.Location = new System.Drawing.Point(6, 19);
			this.cb_Filter.Name = "cb_Filter";
			this.cb_Filter.Size = new System.Drawing.Size(98, 26);
			this.cb_Filter.TabIndex = 1;
			this.cb_Filter.SelectedIndexChanged += new System.EventHandler(this.cb_Filter_SelectedIndexChanged);
			// 
			// tb_FilterBy
			// 
			this.tb_FilterBy.Location = new System.Drawing.Point(110, 19);
			this.tb_FilterBy.Name = "tb_FilterBy";
			this.tb_FilterBy.Size = new System.Drawing.Size(125, 26);
			this.tb_FilterBy.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.gb_DateFilter);
			this.groupBox1.Controls.Add(this.tb_FilterBy);
			this.groupBox1.Controls.Add(this.cb_Filter);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(606, 66);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "فلاتر";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(496, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 28);
			this.button1.TabIndex = 21;
			this.button1.Text = "بحث ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gb_DateFilter
			// 
			this.gb_DateFilter.Controls.Add(this.dtp_To);
			this.gb_DateFilter.Controls.Add(this.dtp_From);
			this.gb_DateFilter.Controls.Add(this.label5);
			this.gb_DateFilter.Controls.Add(this.label4);
			this.gb_DateFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_DateFilter.Location = new System.Drawing.Point(193, 17);
			this.gb_DateFilter.Name = "gb_DateFilter";
			this.gb_DateFilter.Size = new System.Drawing.Size(297, 41);
			this.gb_DateFilter.TabIndex = 26;
			this.gb_DateFilter.TabStop = false;
			this.gb_DateFilter.Text = "التاريخ";
			// 
			// dtp_To
			// 
			this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_To.Location = new System.Drawing.Point(12, 15);
			this.dtp_To.Name = "dtp_To";
			this.dtp_To.Size = new System.Drawing.Size(94, 22);
			this.dtp_To.TabIndex = 27;
			// 
			// dtp_From
			// 
			this.dtp_From.CustomFormat = "";
			this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_From.Location = new System.Drawing.Point(155, 15);
			this.dtp_From.Name = "dtp_From";
			this.dtp_From.Size = new System.Drawing.Size(94, 22);
			this.dtp_From.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(259, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 14);
			this.label5.TabIndex = 25;
			this.label5.Text = ": من ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(112, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 14);
			this.label4.TabIndex = 24;
			this.label4.Text = ": الي";
			// 
			// frmMabiatcs
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 454);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgv_Mabiat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmMabiatcs";
			this.Text = "المبيعات";
			this.Load += new System.EventHandler(this.frmMabiatcs_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Mabiat)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gb_DateFilter.ResumeLayout(false);
			this.gb_DateFilter.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_Mabiat;
		private System.Windows.Forms.ComboBox cb_Filter;
		private System.Windows.Forms.TextBox tb_FilterBy;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gb_DateFilter;
		private System.Windows.Forms.ToolStripMenuItem عرضالفاتورةToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem حذفالفاتورةToolStripMenuItem;
		private System.Windows.Forms.DateTimePicker dtp_From;
		private System.Windows.Forms.DateTimePicker dtp_To;
	}
}