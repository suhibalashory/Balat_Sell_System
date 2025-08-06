namespace Alkirat.Al_3orod
{
	partial class frmShowBalat
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
			this.uctlBalata1 = new Alkirat.Al_3orod.uctlBalata();
			this.SuspendLayout();
			// 
			// uctlBalata1
			// 
			this.uctlBalata1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.uctlBalata1.Location = new System.Drawing.Point(4, 2);
			this.uctlBalata1.Name = "uctlBalata1";
			this.uctlBalata1.Size = new System.Drawing.Size(451, 243);
			this.uctlBalata1.TabIndex = 0;
			this.uctlBalata1.Load += new System.EventHandler(this.uctlBalata1_Load);
			// 
			// frmShowBalat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 245);
			this.Controls.Add(this.uctlBalata1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmShowBalat";
			this.Text = "بلاطة";
			this.Load += new System.EventHandler(this.frmShowBalat_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private uctlBalata uctlBalata1;
	}
}