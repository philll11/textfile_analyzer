namespace Assignment_4
{
	partial class MainWindow
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.opnFile = new System.Windows.Forms.ToolStripMenuItem();
			this.commonLtBx = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.longLtBx = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.shortLtBx = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.averageLtBx = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.wordTxtBx = new System.Windows.Forms.TextBox();
			this.lengthTxtBx = new System.Windows.Forms.TextBox();
			this.wordBtn = new System.Windows.Forms.Button();
			this.lengthBtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.wordCountLbl = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.aveWordLbl = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.uniqueTxBx = new System.Windows.Forms.TextBox();
			this.wordError = new System.Windows.Forms.Label();
			this.lengthError = new System.Windows.Forms.Label();
			this.wordLtBx = new System.Windows.Forms.ListBox();
			this.lengthTxBx = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opnFile});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// opnFile
			// 
			this.opnFile.Name = "opnFile";
			this.opnFile.Size = new System.Drawing.Size(103, 22);
			this.opnFile.Text = "Open";
			this.opnFile.Click += new System.EventHandler(this.OpnFileClick);
			// 
			// commonLtBx
			// 
			this.commonLtBx.FormattingEnabled = true;
			this.commonLtBx.Location = new System.Drawing.Point(202, 93);
			this.commonLtBx.Name = "commonLtBx";
			this.commonLtBx.Size = new System.Drawing.Size(279, 69);
			this.commonLtBx.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Most Common Words";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Longest Words";
			// 
			// longLtBx
			// 
			this.longLtBx.FormattingEnabled = true;
			this.longLtBx.Location = new System.Drawing.Point(202, 168);
			this.longLtBx.Name = "longLtBx";
			this.longLtBx.Size = new System.Drawing.Size(279, 69);
			this.longLtBx.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 255);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Shortest Words";
			// 
			// shortLtBx
			// 
			this.shortLtBx.FormattingEnabled = true;
			this.shortLtBx.Location = new System.Drawing.Point(202, 243);
			this.shortLtBx.Name = "shortLtBx";
			this.shortLtBx.Size = new System.Drawing.Size(279, 69);
			this.shortLtBx.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 332);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Average Word Length";
			// 
			// averageLtBx
			// 
			this.averageLtBx.FormattingEnabled = true;
			this.averageLtBx.Location = new System.Drawing.Point(202, 320);
			this.averageLtBx.Name = "averageLtBx";
			this.averageLtBx.Size = new System.Drawing.Size(279, 69);
			this.averageLtBx.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label5.Location = new System.Drawing.Point(449, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(231, 25);
			this.label5.TabIndex = 9;
			this.label5.Text = "Text Analysis Application";
			// 
			// wordTxtBx
			// 
			this.wordTxtBx.Location = new System.Drawing.Point(704, 90);
			this.wordTxtBx.Name = "wordTxtBx";
			this.wordTxtBx.Size = new System.Drawing.Size(100, 20);
			this.wordTxtBx.TabIndex = 10;
			// 
			// lengthTxtBx
			// 
			this.lengthTxtBx.Location = new System.Drawing.Point(704, 175);
			this.lengthTxtBx.Name = "lengthTxtBx";
			this.lengthTxtBx.Size = new System.Drawing.Size(100, 20);
			this.lengthTxtBx.TabIndex = 11;
			// 
			// wordBtn
			// 
			this.wordBtn.Location = new System.Drawing.Point(717, 116);
			this.wordBtn.Name = "wordBtn";
			this.wordBtn.Size = new System.Drawing.Size(75, 23);
			this.wordBtn.TabIndex = 12;
			this.wordBtn.Text = "Search";
			this.wordBtn.UseVisualStyleBackColor = true;
			this.wordBtn.Click += new System.EventHandler(this.WordBtnClick);
			// 
			// lengthBtn
			// 
			this.lengthBtn.Location = new System.Drawing.Point(717, 201);
			this.lengthBtn.Name = "lengthBtn";
			this.lengthBtn.Size = new System.Drawing.Size(75, 23);
			this.lengthBtn.TabIndex = 13;
			this.lengthBtn.Text = "Search";
			this.lengthBtn.UseVisualStyleBackColor = true;
			this.lengthBtn.Click += new System.EventHandler(this.LengthBtnClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(619, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Search Word";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(612, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Search Length";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(615, 249);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "List of all unique words";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(55, 481);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(260, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Albsolute number of words (not counting repeitions) is:";
			// 
			// wordCountLbl
			// 
			this.wordCountLbl.AutoSize = true;
			this.wordCountLbl.Location = new System.Drawing.Point(321, 481);
			this.wordCountLbl.Name = "wordCountLbl";
			this.wordCountLbl.Size = new System.Drawing.Size(13, 13);
			this.wordCountLbl.TabIndex = 21;
			this.wordCountLbl.Text = "0";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(354, 481);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(161, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "Average word length of words is:";
			// 
			// aveWordLbl
			// 
			this.aveWordLbl.AutoSize = true;
			this.aveWordLbl.Location = new System.Drawing.Point(521, 481);
			this.aveWordLbl.Name = "aveWordLbl";
			this.aveWordLbl.Size = new System.Drawing.Size(13, 13);
			this.aveWordLbl.TabIndex = 23;
			this.aveWordLbl.Text = "0";
			// 
			// chart1
			// 
			chartArea5.AxisX.Interval = 1D;
			chartArea5.AxisX.IsLabelAutoFit = false;
			chartArea5.AxisX.LabelStyle.Angle = -90;
			chartArea5.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.chart1.Legends.Add(legend5);
			this.chart1.Location = new System.Drawing.Point(13, 497);
			this.chart1.Name = "chart1";
			series5.ChartArea = "ChartArea1";
			series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
			series5.LabelAngle = 1;
			series5.Legend = "Legend1";
			series5.Name = "Words";
			series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
			this.chart1.Series.Add(series5);
			this.chart1.Size = new System.Drawing.Size(1090, 419);
			this.chart1.TabIndex = 24;
			this.chart1.Text = "chart1";
			// 
			// uniqueTxBx
			// 
			this.uniqueTxBx.Location = new System.Drawing.Point(615, 268);
			this.uniqueTxBx.Multiline = true;
			this.uniqueTxBx.Name = "uniqueTxBx";
			this.uniqueTxBx.ReadOnly = true;
			this.uniqueTxBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.uniqueTxBx.Size = new System.Drawing.Size(488, 198);
			this.uniqueTxBx.TabIndex = 25;
			// 
			// wordError
			// 
			this.wordError.AutoSize = true;
			this.wordError.ForeColor = System.Drawing.Color.Red;
			this.wordError.Location = new System.Drawing.Point(619, 142);
			this.wordError.Name = "wordError";
			this.wordError.Size = new System.Drawing.Size(161, 13);
			this.wordError.TabIndex = 26;
			this.wordError.Text = "* Input must not include numbers";
			this.wordError.Visible = false;
			// 
			// lengthError
			// 
			this.lengthError.AutoSize = true;
			this.lengthError.ForeColor = System.Drawing.Color.Red;
			this.lengthError.Location = new System.Drawing.Point(619, 224);
			this.lengthError.Name = "lengthError";
			this.lengthError.Size = new System.Drawing.Size(161, 13);
			this.lengthError.TabIndex = 27;
			this.lengthError.Text = "* Input must not include numbers";
			this.lengthError.Visible = false;
			// 
			// wordLtBx
			// 
			this.wordLtBx.FormattingEnabled = true;
			this.wordLtBx.Location = new System.Drawing.Point(824, 90);
			this.wordLtBx.Name = "wordLtBx";
			this.wordLtBx.Size = new System.Drawing.Size(279, 69);
			this.wordLtBx.TabIndex = 14;
			// 
			// lengthTxBx
			// 
			this.lengthTxBx.Location = new System.Drawing.Point(824, 173);
			this.lengthTxBx.Multiline = true;
			this.lengthTxBx.Name = "lengthTxBx";
			this.lengthTxBx.ReadOnly = true;
			this.lengthTxBx.Size = new System.Drawing.Size(279, 74);
			this.lengthTxBx.TabIndex = 28;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 928);
			this.Controls.Add(this.lengthTxBx);
			this.Controls.Add(this.lengthError);
			this.Controls.Add(this.wordError);
			this.Controls.Add(this.uniqueTxBx);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.aveWordLbl);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.wordCountLbl);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.wordLtBx);
			this.Controls.Add(this.lengthBtn);
			this.Controls.Add(this.wordBtn);
			this.Controls.Add(this.lengthTxtBx);
			this.Controls.Add(this.wordTxtBx);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.averageLtBx);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.shortLtBx);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.longLtBx);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.commonLtBx);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Text Analysis";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem opnFile;
		private System.Windows.Forms.ListBox commonLtBx;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox longLtBx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox shortLtBx;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox averageLtBx;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox wordTxtBx;
		private System.Windows.Forms.TextBox lengthTxtBx;
		private System.Windows.Forms.Button wordBtn;
		private System.Windows.Forms.Button lengthBtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label wordCountLbl;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label aveWordLbl;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.TextBox uniqueTxBx;
		private System.Windows.Forms.Label wordError;
		private System.Windows.Forms.Label lengthError;
		private System.Windows.Forms.ListBox wordLtBx;
		private System.Windows.Forms.TextBox lengthTxBx;
	}
}

