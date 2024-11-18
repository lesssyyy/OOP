namespace QUIZBANK
{
    partial class Dashboard
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panelside = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnAddquiz = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnUpdateDelete = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(142, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(658, 450);
            this.mainpanel.TabIndex = 41;
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.Turquoise;
            this.panelside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelside.Controls.Add(this.pictureBox6);
            this.panelside.Controls.Add(this.panel6);
            this.panelside.Controls.Add(this.panel7);
            this.panelside.Controls.Add(this.panel8);
            this.panelside.Controls.Add(this.panel9);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 0);
            this.panelside.MaximumSize = new System.Drawing.Size(200, 450);
            this.panelside.MinimumSize = new System.Drawing.Size(49, 0);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(142, 450);
            this.panelside.TabIndex = 40;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::QUIZBANK.Properties.Resources.teacher;
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(138, 131);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.btnAddquiz);
            this.panel6.Location = new System.Drawing.Point(3, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(138, 37);
            this.panel6.TabIndex = 40;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox7.Image = global::QUIZBANK.Properties.Resources.add_file;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(42, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            // 
            // btnAddquiz
            // 
            this.btnAddquiz.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddquiz.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddquiz.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddquiz.Location = new System.Drawing.Point(35, 0);
            this.btnAddquiz.Name = "btnAddquiz";
            this.btnAddquiz.Size = new System.Drawing.Size(103, 37);
            this.btnAddquiz.TabIndex = 41;
            this.btnAddquiz.Text = "Add Quiz Set";
            this.btnAddquiz.UseVisualStyleBackColor = false;
            this.btnAddquiz.Click += new System.EventHandler(this.btnAddquiz_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.pictureBox8);
            this.panel7.Controls.Add(this.btnUpdateDelete);
            this.panel7.Location = new System.Drawing.Point(3, 183);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(138, 37);
            this.panel7.TabIndex = 43;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox8.Image = global::QUIZBANK.Properties.Resources.update;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(42, 37);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 42;
            this.pictureBox8.TabStop = false;
            // 
            // btnUpdateDelete
            // 
            this.btnUpdateDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDelete.Location = new System.Drawing.Point(35, 0);
            this.btnUpdateDelete.Name = "btnUpdateDelete";
            this.btnUpdateDelete.Size = new System.Drawing.Size(103, 37);
            this.btnUpdateDelete.TabIndex = 41;
            this.btnUpdateDelete.Text = "Update and Delete";
            this.btnUpdateDelete.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.pictureBox9);
            this.panel8.Controls.Add(this.btnView);
            this.panel8.Location = new System.Drawing.Point(3, 226);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(138, 37);
            this.panel8.TabIndex = 44;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox9.Image = global::QUIZBANK.Properties.Resources.analysis;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(42, 37);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 42;
            this.pictureBox9.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(35, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(103, 37);
            this.btnView.TabIndex = 41;
            this.btnView.Text = "View Quiz";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.pictureBox10);
            this.panel9.Controls.Add(this.btLogout);
            this.panel9.Location = new System.Drawing.Point(3, 269);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(138, 37);
            this.panel9.TabIndex = 45;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = global::QUIZBANK.Properties.Resources.logout;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(42, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 42;
            this.pictureBox10.TabStop = false;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(35, 0);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(103, 37);
            this.btLogout.TabIndex = 41;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.FlowLayoutPanel panelside;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnAddquiz;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnUpdateDelete;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}