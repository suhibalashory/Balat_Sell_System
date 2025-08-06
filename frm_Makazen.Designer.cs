namespace Alkirat2.Alkirat2
{
	partial class frm_Makazen
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
			this.dgv_Makazen = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Add = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lab_Houre = new System.Windows.Forms.Label();
			this.lab_Count = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Makazen)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_Makazen
			// 
			this.dgv_Makazen.AllowUserToAddRows = false;
			this.dgv_Makazen.AllowUserToDeleteRows = false;
			this.dgv_Makazen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Makazen.ContextMenuStrip = this.contextMenuStrip1;
			this.dgv_Makazen.Location = new System.Drawing.Point(3, 162);
			this.dgv_Makazen.Name = "dgv_Makazen";
			this.dgv_Makazen.ReadOnly = true;
			this.dgv_Makazen.Size = new System.Drawing.Size(591, 220);
			this.dgv_Makazen.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripMenuItem1,
            this.حذفToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 76);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// تعديلToolStripMenuItem
			// 
			this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
			this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.تعديلToolStripMenuItem.Text = "تعديل";
			this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// حذفToolStripMenuItem
			// 
			this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
			this.حذفToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.حذفToolStripMenuItem.Text = "حذف";
			this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(507, 133);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(75, 23);
			this.btn_Add.TabIndex = 2;
			this.btn_Add.Text = "اضافة";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(60, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = ": العدد ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Andalus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(111, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 56);
			this.label1.TabIndex = 9;
			this.label1.Text = "منظومة الوادي لسرميك و البرسلين";
			// 
			// lab_Houre
			// 
			this.lab_Houre.AutoSize = true;
			this.lab_Houre.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lab_Houre.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_Houre.Location = new System.Drawing.Point(12, 9);
			this.lab_Houre.Name = "lab_Houre";
			this.lab_Houre.Size = new System.Drawing.Size(92, 25);
			this.lab_Houre.TabIndex = 10;
			this.lab_Houre.Text = "00:00:00";
			// 
			// lab_Count
			// 
			this.lab_Count.AutoSize = true;
			this.lab_Count.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_Count.Location = new System.Drawing.Point(13, 133);
			this.lab_Count.Name = "lab_Count";
			this.lab_Count.Size = new System.Drawing.Size(19, 19);
			this.lab_Count.TabIndex = 11;
			this.lab_Count.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(231, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 19);
			this.label4.TabIndex = 12;
			this.label4.Text = "الموردين و المخازن";
			// 
			// frm_Makazen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(594, 386);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lab_Count);
			this.Controls.Add(this.lab_Houre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.dgv_Makazen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frm_Makazen";
			this.Text = "frm_Makazen";
			this.Load += new System.EventHandler(this.frm_Makazen_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Makazen)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_Makazen;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab_Houre;
		private System.Windows.Forms.Label lab_Count;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
	}
}