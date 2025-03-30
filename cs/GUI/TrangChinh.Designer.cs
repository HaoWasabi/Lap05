using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class TrangChinh
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
            header = new Header();
            tabInformation = new TabPage();
            tabAnnouncement = new TabPage();
            tabHistory = new TabPage();
            tabHome = new TabPage();
            label1 = new Label();
            tabControl = new TabControl();
            tabHome.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = SystemColors.ControlLightLight;
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1384, 89);
            header.TabIndex = 0;
            // 
            // tabInformation
            // 
            tabInformation.Cursor = Cursors.Default;
            tabInformation.Location = new Point(4, 33);
            tabInformation.Name = "tabInformation";
            tabInformation.Size = new Size(1376, 603);
            tabInformation.TabIndex = 3;
            tabInformation.Text = "THÔNG TIN";
            tabInformation.UseVisualStyleBackColor = true;
            // 
            // tabAnnouncement
            // 
            tabAnnouncement.Cursor = Cursors.Default;
            tabAnnouncement.Location = new Point(4, 33);
            tabAnnouncement.Name = "tabAnnouncement";
            tabAnnouncement.Size = new Size(1376, 603);
            tabAnnouncement.TabIndex = 2;
            tabAnnouncement.Text = "THÔNG BÁO";
            tabAnnouncement.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            tabHistory.Cursor = Cursors.Default;
            tabHistory.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tabHistory.Location = new Point(4, 33);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.Size = new Size(1376, 603);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "LỊCH SỬ";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            tabHome.BackColor = SystemColors.ControlLightLight;
            tabHome.Controls.Add(label1);
            tabHome.Cursor = Cursors.Default;
            tabHome.Location = new Point(4, 33);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(1376, 603);
            tabHome.TabIndex = 0;
            tabHome.Text = "TRANG CHỦ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 449);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabHome);
            tabControl.Controls.Add(tabHistory);
            tabControl.Controls.Add(tabAnnouncement);
            tabControl.Controls.Add(tabInformation);
            tabControl.Cursor = Cursors.Hand;
            tabControl.Dock = DockStyle.Fill;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tabControl.Location = new Point(0, 89);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1384, 640);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // TrangChinh
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1384, 729);
            Controls.Add(tabControl);
            Controls.Add(header);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(1400, 768);
            Name = "TrangChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Header header;
        private TabPage tabInformation;
        private TabPage tabAnnouncement;
        private TabPage tabHistory;
        private TabPage tabHome;
        private TabControl tabControl;
        private Label label1;
    }
}
