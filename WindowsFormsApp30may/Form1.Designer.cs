
namespace WindowsFormsApp30may
{
    partial class Form30May
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelIsiTeamName = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelManagerIsi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStadiumIsi = new System.Windows.Forms.Label();
            this.labelTopScore = new System.Windows.Forms.Label();
            this.labelIsiTopScorer = new System.Windows.Forms.Label();
            this.labelWorstDiscipline = new System.Windows.Forms.Label();
            this.labelWorstDisc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(12, 12);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(91, 55);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(109, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 55);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(211, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(92, 55);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(310, 13);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(91, 54);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(61, 91);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(93, 17);
            this.labelTeamName.TabIndex = 4;
            this.labelTeamName.Text = "Team Name :";
            // 
            // labelIsiTeamName
            // 
            this.labelIsiTeamName.AutoSize = true;
            this.labelIsiTeamName.Location = new System.Drawing.Point(192, 91);
            this.labelIsiTeamName.Name = "labelIsiTeamName";
            this.labelIsiTeamName.Size = new System.Drawing.Size(13, 17);
            this.labelIsiTeamName.TabIndex = 5;
            this.labelIsiTeamName.Text = "-";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(83, 121);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(76, 17);
            this.labelManager.TabIndex = 6;
            this.labelManager.Text = "Manager : ";
            // 
            // labelManagerIsi
            // 
            this.labelManagerIsi.AutoSize = true;
            this.labelManagerIsi.Location = new System.Drawing.Point(192, 121);
            this.labelManagerIsi.Name = "labelManagerIsi";
            this.labelManagerIsi.Size = new System.Drawing.Size(13, 17);
            this.labelManagerIsi.TabIndex = 7;
            this.labelManagerIsi.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stadium : ";
            // 
            // labelStadiumIsi
            // 
            this.labelStadiumIsi.AutoSize = true;
            this.labelStadiumIsi.Location = new System.Drawing.Point(192, 148);
            this.labelStadiumIsi.Name = "labelStadiumIsi";
            this.labelStadiumIsi.Size = new System.Drawing.Size(13, 17);
            this.labelStadiumIsi.TabIndex = 9;
            this.labelStadiumIsi.Text = "-";
            // 
            // labelTopScore
            // 
            this.labelTopScore.AutoSize = true;
            this.labelTopScore.Location = new System.Drawing.Point(68, 175);
            this.labelTopScore.Name = "labelTopScore";
            this.labelTopScore.Size = new System.Drawing.Size(91, 17);
            this.labelTopScore.TabIndex = 10;
            this.labelTopScore.Text = "Top Scorer : ";
            // 
            // labelIsiTopScorer
            // 
            this.labelIsiTopScorer.AutoSize = true;
            this.labelIsiTopScorer.Location = new System.Drawing.Point(192, 175);
            this.labelIsiTopScorer.Name = "labelIsiTopScorer";
            this.labelIsiTopScorer.Size = new System.Drawing.Size(13, 17);
            this.labelIsiTopScorer.TabIndex = 11;
            this.labelIsiTopScorer.Text = "-";
            // 
            // labelWorstDiscipline
            // 
            this.labelWorstDiscipline.AutoSize = true;
            this.labelWorstDiscipline.Location = new System.Drawing.Point(38, 207);
            this.labelWorstDiscipline.Name = "labelWorstDiscipline";
            this.labelWorstDiscipline.Size = new System.Drawing.Size(121, 17);
            this.labelWorstDiscipline.TabIndex = 12;
            this.labelWorstDiscipline.Text = "Worst Discipline : ";
            // 
            // labelWorstDisc
            // 
            this.labelWorstDisc.AutoSize = true;
            this.labelWorstDisc.Location = new System.Drawing.Point(192, 207);
            this.labelWorstDisc.Name = "labelWorstDisc";
            this.labelWorstDisc.Size = new System.Drawing.Size(13, 17);
            this.labelWorstDisc.TabIndex = 13;
            this.labelWorstDisc.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 211);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form30May
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelWorstDisc);
            this.Controls.Add(this.labelWorstDiscipline);
            this.Controls.Add(this.labelIsiTopScorer);
            this.Controls.Add(this.labelTopScore);
            this.Controls.Add(this.labelStadiumIsi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelManagerIsi);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelIsiTeamName);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFirst);
            this.Name = "Form30May";
            this.Text = "Form Navigasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelIsiTeamName;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelManagerIsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStadiumIsi;
        private System.Windows.Forms.Label labelTopScore;
        private System.Windows.Forms.Label labelIsiTopScorer;
        private System.Windows.Forms.Label labelWorstDiscipline;
        private System.Windows.Forms.Label labelWorstDisc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

