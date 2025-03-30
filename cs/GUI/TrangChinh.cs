using cs.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChinh : Form
    {
        private Dictionary<string, UserControl> userControls;

        public TrangChinh()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            userControls = new Dictionary<string, UserControl>();
            tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab != null)
            {
                string tabName = tabControl.SelectedTab.Text;

                if (!userControls.ContainsKey(tabName))
                {
                    UserControl newControl = CreateUserControlForTab(tabName);
                    if (newControl != null)
                    {
                        newControl.Dock = DockStyle.Fill;
                        userControls.Add(tabName, newControl);
                        tabControl.SelectedTab.Controls.Add(newControl);
                    }
                }

                foreach (var kvp in userControls)
                {
                    if (tabControl.TabPages.Cast<TabPage>().Any(p => p.Text == kvp.Key))
                    {
                        kvp.Value.Visible = (kvp.Key == tabName);
                    }
                }
            }
        }

        private UserControl CreateUserControlForTab(string tabName)
        {
            switch (tabName)
            {
                case "TRANG CHỦ":
                    return null;
                case "LỊCH SỬ":
                    return null;
                case "THÔNG BÁO":
                    return new ThongBao();
                case "THÔNG TIN":
                    return new ThongTinTaiKhoan();
                default:
                    return null;
            }
        }

        // Ve lai giao dien cho tabcontrol
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabControl tabControl = sender as TabControl;
            Rectangle tabRect = tabControl.GetTabRect(e.Index);
            Font font = new Font("Arial", 14, FontStyle.Bold);

            Color selectedColor = Color.FromArgb(30, 89, 152);
            Color normalColor = Color.FromArgb(0, 123, 255);
            Color backColor = e.State == DrawItemState.Selected ? selectedColor : normalColor;

            // Mau chu
            Brush textBrush = e.State == DrawItemState.Selected ? Brushes.White : new SolidBrush(Color.FromArgb(211, 211, 211));

            // Ve mau nen cho tab item
            using (Brush b = new SolidBrush(backColor))
            {
                g.FillRectangle(b, tabRect);
            }

            // Ve duong vien
            using (Pen p = new Pen(Color.Black, 1))
            {
                g.DrawRectangle(p, tabRect);
            }

            // Can chinh chu trong tab
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString(tabControl.TabPages[e.Index].Text, font, textBrush, tabRect, stringFormat);
        }

    }
}