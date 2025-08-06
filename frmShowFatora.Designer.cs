namespace Alkirat2.Alkirat2
{
	partial class frmShowFatora
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
			this.uctl_Mabiat1 = new Alkirat2.uctl_Mabiat();
			this.SuspendLayout();
			// 
			// uctl_Mabiat1
			// 
			this.uctl_Mabiat1.Location = new System.Drawing.Point(-5, 2);
			this.uctl_Mabiat1.Name = "uctl_Mabiat1";
			this.uctl_Mabiat1.Size = new System.Drawing.Size(426, 457);
			this.uctl_Mabiat1.TabIndex = 0;
			this.uctl_Mabiat1.Load += new System.EventHandler(this.uctl_Mabiat1_Load);
			// 
			// frmShowFatora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 461);
			this.Controls.Add(this.uctl_Mabiat1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmShowFatora";
			this.Text = "frmShowFatora";
			this.Load += new System.EventHandler(this.frmShowFatora_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Alkirat2.uctl_Mabiat uctl_Mabiat1;
	}
}