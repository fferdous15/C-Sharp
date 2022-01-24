using System;

namespace B_M_C
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBands = new System.Windows.Forms.Button();
            this.userBands = new B_M_C.UserBands();
            this.userChangePassword1 = new B_M_C.UserChangePassword();
            this.accreq1 = new B_M_C.accreq();
            this.userReport1 = new B_M_C.UserReport();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 72);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Controls.Add(this.btnChange);
            this.bunifuGradientPanel1.Controls.Add(this.btnBands);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 72);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(140, 437);
            this.bunifuGradientPanel1.TabIndex = 1;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "History";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(0, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 43);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChange.Location = new System.Drawing.Point(0, 104);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(137, 57);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBands
            // 
            this.btnBands.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBands.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBands.Location = new System.Drawing.Point(0, 6);
            this.btnBands.Name = "btnBands";
            this.btnBands.Size = new System.Drawing.Size(137, 43);
            this.btnBands.TabIndex = 9;
            this.btnBands.Text = "Bands";
            this.btnBands.UseVisualStyleBackColor = false;
            this.btnBands.Click += new System.EventHandler(this.btnBands_Click);
            // 
            // userBands
            // 
            this.userBands.Location = new System.Drawing.Point(140, 72);
            this.userBands.Name = "userBands";
            this.userBands.Size = new System.Drawing.Size(619, 437);
            this.userBands.TabIndex = 17;
            this.userBands.Load += new System.EventHandler(this.userBands_Load);
            // 
            // userChangePassword1
            // 
            this.userChangePassword1.Location = new System.Drawing.Point(140, 72);
            this.userChangePassword1.Name = "userChangePassword1";
            this.userChangePassword1.Size = new System.Drawing.Size(619, 437);
            this.userChangePassword1.TabIndex = 16;
            this.userChangePassword1.Load += new System.EventHandler(this.userChangePassword1_Load_1);
            // 
            // accreq1
            // 
            this.accreq1.Location = new System.Drawing.Point(140, 72);
            this.accreq1.Name = "accreq1";
            this.accreq1.Size = new System.Drawing.Size(619, 437);
            this.accreq1.TabIndex = 18;
            // 
            // userReport1
            // 
            this.userReport1.Location = new System.Drawing.Point(140, 72);
            this.userReport1.Name = "userReport1";
            this.userReport1.Size = new System.Drawing.Size(619, 437);
            this.userReport1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(140, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 437);
            this.panel2.TabIndex = 20;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(759, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userReport1);
            this.Controls.Add(this.accreq1);
            this.Controls.Add(this.userBands);
            this.Controls.Add(this.userChangePassword1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void userBands_Load(object sender, EventArgs e)
        {
            
        }

        private void userChangePassword1_Load_1(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnBands;
        private System.Windows.Forms.Button btnExit;
        private UserBands userBands;
        private UserChangePassword userChangePassword1;
        private System.Windows.Forms.Button button1;
        private accreq accreq1;
        private UserReport userReport1;
        private System.Windows.Forms.Panel panel2;
    }
}