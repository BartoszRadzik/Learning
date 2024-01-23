namespace WindowsFormsApp1
{
	partial class Form1
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.CloseBTN = new System.Windows.Forms.Button();
			this.showPatternTXT = new System.Windows.Forms.TextBox();
			this.PrintBTN = new System.Windows.Forms.Button();
			this.patternsCMB = new System.Windows.Forms.ComboBox();
			this.Data1LBL = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Data1Numeric = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Data1Numeric)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.Data1Numeric);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.Data1LBL);
			this.panel1.Controls.Add(this.patternsCMB);
			this.panel1.Controls.Add(this.PrintBTN);
			this.panel1.Controls.Add(this.showPatternTXT);
			this.panel1.Controls.Add(this.CloseBTN);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 426);
			this.panel1.TabIndex = 0;
			// 
			// CloseBTN
			// 
			this.CloseBTN.Location = new System.Drawing.Point(728, 3);
			this.CloseBTN.Name = "CloseBTN";
			this.CloseBTN.Size = new System.Drawing.Size(45, 23);
			this.CloseBTN.TabIndex = 0;
			this.CloseBTN.Text = "X";
			this.CloseBTN.UseVisualStyleBackColor = true;
			this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
			// 
			// showPatternTXT
			// 
			this.showPatternTXT.Location = new System.Drawing.Point(3, 90);
			this.showPatternTXT.Multiline = true;
			this.showPatternTXT.Name = "showPatternTXT";
			this.showPatternTXT.Size = new System.Drawing.Size(284, 333);
			this.showPatternTXT.TabIndex = 1;
			// 
			// PrintBTN
			// 
			this.PrintBTN.Location = new System.Drawing.Point(293, 400);
			this.PrintBTN.Name = "PrintBTN";
			this.PrintBTN.Size = new System.Drawing.Size(172, 23);
			this.PrintBTN.TabIndex = 2;
			this.PrintBTN.Text = "Show";
			this.PrintBTN.UseVisualStyleBackColor = true;
			this.PrintBTN.Click += new System.EventHandler(this.PrintBTN_Click);
			// 
			// patternsCMB
			// 
			this.patternsCMB.FormattingEnabled = true;
			this.patternsCMB.Items.AddRange(new object[] {
            "Christmas Tree",
            "Square",
            "Rectangle",
            "Star",
            "Triangle",
            "Diamond"});
			this.patternsCMB.Location = new System.Drawing.Point(293, 106);
			this.patternsCMB.Name = "patternsCMB";
			this.patternsCMB.Size = new System.Drawing.Size(172, 21);
			this.patternsCMB.TabIndex = 3;
			this.patternsCMB.SelectedIndexChanged += new System.EventHandler(this.patternsCMB_SelectedIndexChanged);
			// 
			// Data1LBL
			// 
			this.Data1LBL.AutoSize = true;
			this.Data1LBL.Location = new System.Drawing.Point(290, 160);
			this.Data1LBL.Name = "Data1LBL";
			this.Data1LBL.Size = new System.Drawing.Size(61, 13);
			this.Data1LBL.TabIndex = 5;
			this.Data1LBL.Text = "Podaj dane";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(290, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Wybierz figurę";
			// 
			// Data1Numeric
			// 
			this.Data1Numeric.Location = new System.Drawing.Point(293, 176);
			this.Data1Numeric.Name = "Data1Numeric";
			this.Data1Numeric.Size = new System.Drawing.Size(120, 20);
			this.Data1Numeric.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Data1Numeric)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button CloseBTN;
		private System.Windows.Forms.Button PrintBTN;
		private System.Windows.Forms.TextBox showPatternTXT;
		private System.Windows.Forms.ComboBox patternsCMB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Data1LBL;
		private System.Windows.Forms.NumericUpDown Data1Numeric;
	}
}

