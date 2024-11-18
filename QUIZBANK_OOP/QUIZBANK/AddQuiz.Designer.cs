namespace QUIZBANK
{
    partial class AddQuiz
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
            this.btnIdentification = new System.Windows.Forms.Button();
            this.btnEssay = new System.Windows.Forms.Button();
            this.btnMultipleChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnumeration = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIdentification
            // 
            this.btnIdentification.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIdentification.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentification.Location = new System.Drawing.Point(320, 269);
            this.btnIdentification.Name = "btnIdentification";
            this.btnIdentification.Size = new System.Drawing.Size(145, 38);
            this.btnIdentification.TabIndex = 9;
            this.btnIdentification.Text = "Identification";
            this.btnIdentification.UseVisualStyleBackColor = false;
            this.btnIdentification.Click += new System.EventHandler(this.btnIdentification_Click);
            // 
            // btnEssay
            // 
            this.btnEssay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEssay.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEssay.Location = new System.Drawing.Point(320, 225);
            this.btnEssay.Name = "btnEssay";
            this.btnEssay.Size = new System.Drawing.Size(145, 38);
            this.btnEssay.TabIndex = 8;
            this.btnEssay.Text = " Essay";
            this.btnEssay.UseVisualStyleBackColor = false;
            // 
            // btnMultipleChoice
            // 
            this.btnMultipleChoice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMultipleChoice.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleChoice.Location = new System.Drawing.Point(320, 181);
            this.btnMultipleChoice.Name = "btnMultipleChoice";
            this.btnMultipleChoice.Size = new System.Drawing.Size(145, 38);
            this.btnMultipleChoice.TabIndex = 7;
            this.btnMultipleChoice.Text = "Multiple Choice Quiz";
            this.btnMultipleChoice.UseVisualStyleBackColor = false;
            this.btnMultipleChoice.Click += new System.EventHandler(this.btnMultipleChoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Category of Quiz to Add";
            // 
            // btnEnumeration
            // 
            this.btnEnumeration.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnumeration.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumeration.Location = new System.Drawing.Point(320, 313);
            this.btnEnumeration.Name = "btnEnumeration";
            this.btnEnumeration.Size = new System.Drawing.Size(145, 38);
            this.btnEnumeration.TabIndex = 10;
            this.btnEnumeration.Text = "Enumeration";
            this.btnEnumeration.UseVisualStyleBackColor = false;
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.btnEnumeration);
            this.addPanel.Controls.Add(this.btnIdentification);
            this.addPanel.Controls.Add(this.btnEssay);
            this.addPanel.Controls.Add(this.btnMultipleChoice);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(800, 450);
            this.addPanel.TabIndex = 11;
            // 
            // AddQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQuiz";
            this.Text = "AddQuiz";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIdentification;
        private System.Windows.Forms.Button btnEssay;
        private System.Windows.Forms.Button btnMultipleChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnumeration;
        private System.Windows.Forms.Panel addPanel;
    }
}