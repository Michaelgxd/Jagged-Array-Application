namespace jaggedArrayDemo
{
    partial class frmScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSection1 = new System.Windows.Forms.ListBox();
            this.lstSection2 = new System.Windows.Forms.ListBox();
            this.lstSection3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAvgSection1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAvgAll = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAvgSection2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAvgSection3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHighestScore = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLowestScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstSection1
            // 
            this.lstSection1.FormattingEnabled = true;
            this.lstSection1.ItemHeight = 15;
            this.lstSection1.Location = new System.Drawing.Point(23, 70);
            this.lstSection1.Name = "lstSection1";
            this.lstSection1.Size = new System.Drawing.Size(120, 154);
            this.lstSection1.TabIndex = 0;

            // 
            // lstSection2
            // 
            this.lstSection2.FormattingEnabled = true;
            this.lstSection2.ItemHeight = 15;
            this.lstSection2.Location = new System.Drawing.Point(219, 70);
            this.lstSection2.Name = "lstSection2";
            this.lstSection2.Size = new System.Drawing.Size(120, 154);
            this.lstSection2.TabIndex = 1;
            // 
            // lstSection3
            // 
            this.lstSection3.FormattingEnabled = true;
            this.lstSection3.ItemHeight = 15;
            this.lstSection3.Location = new System.Drawing.Point(410, 70);
            this.lstSection3.Name = "lstSection3";
            this.lstSection3.Size = new System.Drawing.Size(120, 154);
            this.lstSection3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "SECTION 1";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "SECTION 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(410, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "SECTION 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(219, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SECTIONS\' SCORES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "The average score of Section 1";

            // 
            // txtAvgSection1
            // 
            this.txtAvgSection1.Location = new System.Drawing.Point(203, 253);
            this.txtAvgSection1.Name = "txtAvgSection1";
            this.txtAvgSection1.ReadOnly = true;
            this.txtAvgSection1.Size = new System.Drawing.Size(100, 23);
            this.txtAvgSection1.TabIndex = 8;

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "The average score for all the students in the 3 sections";

            // 
            // txtAvgAll
            // 
            this.txtAvgAll.Location = new System.Drawing.Point(319, 353);
            this.txtAvgAll.Name = "txtAvgAll";
            this.txtAvgAll.ReadOnly = true;
            this.txtAvgAll.Size = new System.Drawing.Size(100, 23);
            this.txtAvgAll.TabIndex = 10;

            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "The average score of Section 2";
            // 
            // txtAvgSection2
            // 
            this.txtAvgSection2.Location = new System.Drawing.Point(203, 282);
            this.txtAvgSection2.Name = "txtAvgSection2";
            this.txtAvgSection2.ReadOnly = true;
            this.txtAvgSection2.Size = new System.Drawing.Size(100, 23);
            this.txtAvgSection2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "The average score of Section 3";
            // 
            // txtAvgSection3
            // 
            this.txtAvgSection3.Location = new System.Drawing.Point(203, 312);
            this.txtAvgSection3.Name = "txtAvgSection3";
            this.txtAvgSection3.ReadOnly = true;
            this.txtAvgSection3.Size = new System.Drawing.Size(100, 23);
            this.txtAvgSection3.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(23, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(455, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "The highest score among all 3 sections and the section in which that score was fo" +
    "und";
            // 
            // txtHighestScore
            // 
            this.txtHighestScore.Location = new System.Drawing.Point(484, 382);
            this.txtHighestScore.Name = "txtHighestScore";
            this.txtHighestScore.ReadOnly = true;
            this.txtHighestScore.Size = new System.Drawing.Size(100, 23);
            this.txtHighestScore.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(23, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(450, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "The lowest score among all 3 sections and the section in which that score was fou" +
    "nd";
            // 
            // txtLowestScore
            // 
            this.txtLowestScore.Location = new System.Drawing.Point(484, 413);
            this.txtLowestScore.Name = "txtLowestScore";
            this.txtLowestScore.ReadOnly = true;
            this.txtLowestScore.Size = new System.Drawing.Size(100, 23);
            this.txtLowestScore.TabIndex = 18;
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 463);
            this.Controls.Add(this.txtLowestScore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHighestScore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAvgSection3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAvgSection2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAvgAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAvgSection1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSection3);
            this.Controls.Add(this.lstSection2);
            this.Controls.Add(this.lstSection1);
            this.Name = "frmScores";
            this.Text = "Section Scores";
            this.Load += new System.EventHandler(this.frmScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSection1;
        private System.Windows.Forms.ListBox lstSection2;
        private System.Windows.Forms.ListBox lstSection3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAvgSection1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAvgAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAvgSection2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAvgSection3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHighestScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLowestScore;
    }
}