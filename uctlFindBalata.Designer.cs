namespace Alkirat.Al_3orod
{
	partial class uctlFindBalata
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.uctlBalata1 = new Alkirat.Al_3orod.uctlBalata();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// uctlBalata1
			// 
			this.uctlBalata1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.uctlBalata1.Location = new System.Drawing.Point(3, 55);
			this.uctlBalata1.Name = "uctlBalata1";
			this.uctlBalata1.Size = new System.Drawing.Size(451, 243);
			this.uctlBalata1.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(3, 28);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(177, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "فلترة حسب";
			// 
			// uctlFindBalata
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.uctlBalata1);
			this.Name = "uctlFindBalata";
			this.Size = new System.Drawing.Size(463, 305);
			this.Load += new System.EventHandler(this.uctlFindBalata_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private uctlBalata uctlBalata1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}
