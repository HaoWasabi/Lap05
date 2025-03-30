using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcomeUser = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            lblDividerLine = new Label();
            pbLogo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.Anchor = AnchorStyles.Left;
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblWelcomeUser.Location = new Point(37, 40);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(156, 22);
            lblWelcomeUser.TabIndex = 1;
            lblWelcomeUser.Text = "Xin chào Gia Hào";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblDividerLine);
            panel1.Controls.Add(lblWelcomeUser);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1012, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(348, 90);
            panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogout.ForeColor = Color.FromArgb(30, 89, 152);
            btnLogout.Location = new Point(222, 37);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(118, 30);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblDividerLine
            // 
            lblDividerLine.AutoSize = true;
            lblDividerLine.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDividerLine.Location = new Point(199, 35);
            lblDividerLine.Name = "lblDividerLine";
            lblDividerLine.Size = new Size(17, 27);
            lblDividerLine.TabIndex = 2;
            lblDividerLine.Text = "|";
            lblDividerLine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbLogo.BackgroundImage = cs.Properties.Resources.logo;
            pbLogo.BackgroundImageLayout = ImageLayout.None;
            pbLogo.Location = new Point(3, 15);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(500, 75);
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(pbLogo);
            Controls.Add(panel1);
            Name = "Header";
            Size = new Size(1360, 90);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblWelcomeUser;
        private Panel panel1;
        private Label lblDividerLine;
        private Button btnLogout;
        private PictureBox pbLogo;
    }
}
