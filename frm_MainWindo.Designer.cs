namespace Alkirat2.Alkirat2
{
	partial class frm_MainWindo
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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation4 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_Houre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Setting = new CustomControls.RJControls.RJButton();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.btn_Fatora = new CustomControls.RJControls.RJButton();
            this.btn_Fawater = new CustomControls.RJControls.RJButton();
            this.btn_Makazen = new CustomControls.RJControls.RJButton();
            this.btn_Bida3a = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_User = new System.Windows.Forms.Label();
            this.btn_Out = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            lineAnnotation1.Name = "LineAnnotation1";
            lineAnnotation2.Name = "LineAnnotation2";
            lineAnnotation3.Name = "LineAnnotation3";
            lineAnnotation4.Name = "LineAnnotation4";
            this.chart1.Annotations.Add(lineAnnotation1);
            this.chart1.Annotations.Add(lineAnnotation2);
            this.chart1.Annotations.Add(lineAnnotation3);
            this.chart1.Annotations.Add(lineAnnotation4);
            this.chart1.BackColor = System.Drawing.Color.Gray;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Silver;
            chartArea1.CursorX.Interval = 3D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.On;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(346, 108);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series1.YValuesPerPoint = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint1);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(441, 260);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Andalus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(146, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 70);
            this.label1.TabIndex = 8;
            this.label1.Text = "منظومة الوادي لسرميك و البرسلين";
            // 
            // lab_Houre
            // 
            this.lab_Houre.AutoSize = true;
            this.lab_Houre.BackColor = System.Drawing.Color.LightGray;
            this.lab_Houre.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Houre.Location = new System.Drawing.Point(670, 71);
            this.lab_Houre.Name = "lab_Houre";
            this.lab_Houre.Size = new System.Drawing.Size(125, 33);
            this.lab_Houre.TabIndex = 9;
            this.lab_Houre.Text = "00:00:00";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 247);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "ملاحظات اليوم";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.Navy;
            this.btn_Setting.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_Setting.BorderColor = System.Drawing.Color.Black;
            this.btn_Setting.BorderRadius = 10;
            this.btn_Setting.BorderSize = 3;
            this.btn_Setting.FlatAppearance.BorderSize = 3;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Setting.Location = new System.Drawing.Point(550, 463);
            this.btn_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(237, 74);
            this.btn_Setting.TabIndex = 6;
            this.btn_Setting.Text = "الاعدادات";
            this.btn_Setting.TextColor = System.Drawing.Color.White;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.Navy;
            this.rjButton5.BackgroundColor = System.Drawing.Color.Navy;
            this.rjButton5.BorderColor = System.Drawing.Color.Black;
            this.rjButton5.BorderRadius = 10;
            this.rjButton5.BorderSize = 3;
            this.rjButton5.FlatAppearance.BorderSize = 3;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(277, 458);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(227, 74);
            this.rjButton5.TabIndex = 5;
            this.rjButton5.Text = "المبيعات";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // btn_Fatora
            // 
            this.btn_Fatora.BackColor = System.Drawing.Color.Navy;
            this.btn_Fatora.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_Fatora.BorderColor = System.Drawing.Color.Black;
            this.btn_Fatora.BorderRadius = 10;
            this.btn_Fatora.BorderSize = 3;
            this.btn_Fatora.FlatAppearance.BorderSize = 3;
            this.btn_Fatora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fatora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fatora.ForeColor = System.Drawing.Color.White;
            this.btn_Fatora.Location = new System.Drawing.Point(13, 460);
            this.btn_Fatora.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fatora.Name = "btn_Fatora";
            this.btn_Fatora.Size = new System.Drawing.Size(219, 74);
            this.btn_Fatora.TabIndex = 4;
            this.btn_Fatora.Text = "اصدار فاتورة";
            this.btn_Fatora.TextColor = System.Drawing.Color.White;
            this.btn_Fatora.UseVisualStyleBackColor = false;
            this.btn_Fatora.Click += new System.EventHandler(this.btn_Fatora_Click);
            // 
            // btn_Fawater
            // 
            this.btn_Fawater.BackColor = System.Drawing.Color.Navy;
            this.btn_Fawater.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_Fawater.BorderColor = System.Drawing.Color.Black;
            this.btn_Fawater.BorderRadius = 10;
            this.btn_Fawater.BorderSize = 3;
            this.btn_Fawater.FlatAppearance.BorderSize = 3;
            this.btn_Fawater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fawater.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fawater.ForeColor = System.Drawing.Color.White;
            this.btn_Fawater.Location = new System.Drawing.Point(550, 376);
            this.btn_Fawater.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fawater.Name = "btn_Fawater";
            this.btn_Fawater.Size = new System.Drawing.Size(237, 79);
            this.btn_Fawater.TabIndex = 3;
            this.btn_Fawater.Text = "الفواتير";
            this.btn_Fawater.TextColor = System.Drawing.Color.White;
            this.btn_Fawater.UseVisualStyleBackColor = false;
            this.btn_Fawater.Click += new System.EventHandler(this.btn_Fawater_Click);
            // 
            // btn_Makazen
            // 
            this.btn_Makazen.BackColor = System.Drawing.Color.Navy;
            this.btn_Makazen.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_Makazen.BorderColor = System.Drawing.Color.Black;
            this.btn_Makazen.BorderRadius = 10;
            this.btn_Makazen.BorderSize = 3;
            this.btn_Makazen.FlatAppearance.BorderSize = 3;
            this.btn_Makazen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Makazen.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Makazen.ForeColor = System.Drawing.Color.White;
            this.btn_Makazen.Location = new System.Drawing.Point(277, 376);
            this.btn_Makazen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Makazen.Name = "btn_Makazen";
            this.btn_Makazen.Size = new System.Drawing.Size(227, 79);
            this.btn_Makazen.TabIndex = 2;
            this.btn_Makazen.Text = "الموردين و المخازن";
            this.btn_Makazen.TextColor = System.Drawing.Color.White;
            this.btn_Makazen.UseVisualStyleBackColor = false;
            this.btn_Makazen.Click += new System.EventHandler(this.btn_Makazen_Click);
            // 
            // btn_Bida3a
            // 
            this.btn_Bida3a.BackColor = System.Drawing.Color.Navy;
            this.btn_Bida3a.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_Bida3a.BorderColor = System.Drawing.Color.Black;
            this.btn_Bida3a.BorderRadius = 10;
            this.btn_Bida3a.BorderSize = 3;
            this.btn_Bida3a.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Bida3a.FlatAppearance.BorderSize = 3;
            this.btn_Bida3a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bida3a.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bida3a.ForeColor = System.Drawing.Color.White;
            this.btn_Bida3a.Location = new System.Drawing.Point(13, 373);
            this.btn_Bida3a.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bida3a.Name = "btn_Bida3a";
            this.btn_Bida3a.Size = new System.Drawing.Size(219, 79);
            this.btn_Bida3a.TabIndex = 1;
            this.btn_Bida3a.Text = "البضاعة";
            this.btn_Bida3a.TextColor = System.Drawing.Color.White;
            this.btn_Bida3a.UseVisualStyleBackColor = false;
            this.btn_Bida3a.Click += new System.EventHandler(this.btn_Bida3a_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "User :";
            // 
            // lab_User
            // 
            this.lab_User.AutoSize = true;
            this.lab_User.BackColor = System.Drawing.Color.Gainsboro;
            this.lab_User.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_User.Location = new System.Drawing.Point(734, 14);
            this.lab_User.Name = "lab_User";
            this.lab_User.Size = new System.Drawing.Size(68, 23);
            this.lab_User.TabIndex = 13;
            this.lab_User.Text = "label4";
            this.lab_User.Click += new System.EventHandler(this.lab_User_Click);
            // 
            // btn_Out
            // 
            this.btn_Out.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Out.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Out.BorderColor = System.Drawing.Color.Black;
            this.btn_Out.BorderRadius = 10;
            this.btn_Out.BorderSize = 2;
            this.btn_Out.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Out.FlatAppearance.BorderSize = 3;
            this.btn_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Out.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Out.ForeColor = System.Drawing.Color.Black;
            this.btn_Out.Location = new System.Drawing.Point(8, 8);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(113, 36);
            this.btn_Out.TabIndex = 14;
            this.btn_Out.Text = "خروج";
            this.btn_Out.TextColor = System.Drawing.Color.Black;
            this.btn_Out.UseVisualStyleBackColor = false;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // frm_MainWindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btn_Out;
            this.ClientSize = new System.Drawing.Size(810, 542);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.lab_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lab_Houre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.btn_Fatora);
            this.Controls.Add(this.btn_Fawater);
            this.Controls.Add(this.btn_Makazen);
            this.Controls.Add(this.btn_Bida3a);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_MainWindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الرئيسية";
            this.Load += new System.EventHandler(this.frm_MainWindo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MainWindo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MainWindo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MainWindo_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private CustomControls.RJControls.RJButton btn_Bida3a;
		private CustomControls.RJControls.RJButton btn_Makazen;
		private CustomControls.RJControls.RJButton btn_Fawater;
		private CustomControls.RJControls.RJButton btn_Setting;
		private CustomControls.RJControls.RJButton rjButton5;
		private CustomControls.RJControls.RJButton btn_Fatora;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab_Houre;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lab_User;
		private CustomControls.RJControls.RJButton btn_Out;
	}
}