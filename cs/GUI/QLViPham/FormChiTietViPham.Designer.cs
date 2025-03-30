
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class FormChiTietViPham
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
            label3 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            label28 = new Label();
            label32 = new Label();
            label34 = new Label();
            label35 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label31 = new Label();
            label30 = new Label();
            label27 = new Label();
            label26 = new Label();
            label24 = new Label();
            label21 = new Label();
            label17 = new Label();
            label20 = new Label();
            label25 = new Label();
            label23 = new Label();
            label29 = new Label();
            label33 = new Label();
            label16 = new Label();
            label15 = new Label();
            label10 = new Label();
            label19 = new Label();
            label18 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label37 = new Label();
            label38 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 0;
            label3.Text = "Design by T18";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 729);
            panel1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Navy;
            panel6.Controls.Add(label3);
            panel6.Location = new Point(0, 679);
            panel6.Name = "panel6";
            panel6.Size = new Size(1350, 50);
            panel6.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(label38);
            panel5.Controls.Add(label37);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label28);
            panel5.Controls.Add(label32);
            panel5.Controls.Add(label34);
            panel5.Controls.Add(label35);
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Font = new Font("Segoe UI", 14.25F);
            panel5.Location = new Point(0, 168);
            panel5.Name = "panel5";
            panel5.Size = new Size(1000, 390);
            panel5.TabIndex = 6;
            panel5.Paint += panel5_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(721, 281);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 26;
            button1.Text = "Cập nhật trạng thái";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.Red;
            label28.Location = new Point(802, 240);
            label28.Name = "label28";
            label28.Size = new Size(138, 21);
            label28.TabIndex = 24;
            label28.Text = "Chưa thanh toán";
            label28.Click += this.label28_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(803, 214);
            label32.Name = "label32";
            label32.Size = new Size(65, 21);
            label32.TabIndex = 23;
            label32.Text = "10000đ";
            label32.Click += this.label32_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.Red;
            label34.Location = new Point(671, 240);
            label34.Name = "label34";
            label34.Size = new Size(82, 21);
            label34.TabIndex = 22;
            label34.Text = "Trạng thái:";
            label34.Click += this.label34_Click;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Microsoft Sans Serif", 12F);
            label35.Location = new Point(672, 214);
            label35.Name = "label35";
            label35.Size = new Size(79, 20);
            label35.TabIndex = 21;
            label35.Text = "Mức phạt:";
            label35.Click += this.label35_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.47303F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.52697F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.Controls.Add(label31, 2, 2);
            tableLayoutPanel1.Controls.Add(label30, 1, 2);
            tableLayoutPanel1.Controls.Add(label27, 2, 1);
            tableLayoutPanel1.Controls.Add(label26, 1, 1);
            tableLayoutPanel1.Controls.Add(label24, 0, 1);
            tableLayoutPanel1.Controls.Add(label21, 2, 0);
            tableLayoutPanel1.Controls.Add(label17, 0, 0);
            tableLayoutPanel1.Controls.Add(label20, 1, 0);
            tableLayoutPanel1.Controls.Add(label25, 0, 2);
            tableLayoutPanel1.Controls.Add(label23, 3, 0);
            tableLayoutPanel1.Controls.Add(label29, 3, 1);
            tableLayoutPanel1.Controls.Add(label33, 3, 2);
            tableLayoutPanel1.Location = new Point(13, 203);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.2758636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.7241364F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(601, 128);
            tableLayoutPanel1.TabIndex = 19;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.None;
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(347, 98);
            label31.Name = "label31";
            label31.Size = new Size(102, 21);
            label31.TabIndex = 12;
            label31.Text = "Giáo trình C#";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.None;
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(214, 98);
            label30.Name = "label30";
            label30.Size = new Size(43, 21);
            label30.TabIndex = 11;
            label30.Text = "Sách";
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.None;
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(347, 56);
            label27.Name = "label27";
            label27.Size = new Size(102, 21);
            label27.TabIndex = 8;
            label27.Text = "Giáo trình C#";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.None;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(214, 56);
            label26.Name = "label26";
            label26.Size = new Size(43, 21);
            label26.TabIndex = 7;
            label26.Text = "Sách";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.None;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(47, 56);
            label24.Name = "label24";
            label24.Size = new Size(55, 21);
            label24.TabIndex = 5;
            label24.Text = "BK001";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label21.Location = new Point(344, 11);
            label21.Name = "label21";
            label21.Size = new Size(108, 21);
            label21.TabIndex = 2;
            label21.Text = "Tên sản phẩm";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label17.Location = new Point(58, 11);
            label17.Name = "label17";
            label17.Size = new Size(33, 21);
            label17.TabIndex = 0;
            label17.Text = "Mã";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label20.Location = new Point(215, 11);
            label20.Name = "label20";
            label20.Size = new Size(40, 21);
            label20.TabIndex = 1;
            label20.Text = "Loại";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.None;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(47, 98);
            label25.Name = "label25";
            label25.Size = new Size(55, 21);
            label25.TabIndex = 6;
            label25.Text = "BK001";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label23.Location = new Point(502, 11);
            label23.Name = "label23";
            label23.Size = new Size(72, 21);
            label23.TabIndex = 4;
            label23.Text = "Thời hạn";
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.None;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(509, 56);
            label29.Name = "label29";
            label29.Size = new Size(57, 21);
            label29.TabIndex = 10;
            label29.Text = "1 ngày";
            // 
            // label33
            // 
            label33.Anchor = AnchorStyles.None;
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.Location = new Point(509, 98);
            label33.Name = "label33";
            label33.Size = new Size(57, 21);
            label33.TabIndex = 14;
            label33.Text = "1 ngày";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(12, 163);
            label16.Name = "label16";
            label16.Size = new Size(300, 25);
            label16.TabIndex = 18;
            label16.Text = "DANH SÁCH MƯỢN SẢN PHÂM";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(698, 10);
            label15.Name = "label15";
            label15.Size = new Size(96, 21);
            label15.TabIndex = 17;
            label15.Text = "11/04/2025";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(698, 45);
            label10.Name = "label10";
            label10.Size = new Size(96, 21);
            label10.TabIndex = 16;
            label10.Text = "15/04/2025";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(698, 115);
            label19.Name = "label19";
            label19.Size = new Size(92, 21);
            label19.TabIndex = 15;
            label19.Text = "Chưa xử lý";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(698, 84);
            label18.Name = "label18";
            label18.Size = new Size(96, 21);
            label18.TabIndex = 14;
            label18.Text = "15/04/2025";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(135, 82);
            label14.Name = "label14";
            label14.Size = new Size(119, 21);
            label14.TabIndex = 10;
            label14.Text = "Nguyễn Văn A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(135, 46);
            label13.Name = "label13";
            label13.Size = new Size(82, 21);
            label13.TabIndex = 9;
            label13.Text = "12345678";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(135, 11);
            label12.Name = "label12";
            label12.Size = new Size(64, 21);
            label12.TabIndex = 8;
            label12.Text = "LB0001";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(567, 115);
            label11.Name = "label11";
            label11.Size = new Size(47, 21);
            label11.TabIndex = 7;
            label11.Text = "Xử lý:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(567, 84);
            label9.Name = "label9";
            label9.Size = new Size(125, 20);
            label9.TabIndex = 5;
            label9.Text = "Ngày trả thực tế:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(567, 48);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 4;
            label8.Text = "Ngày trả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(567, 11);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 3;
            label7.Text = "Ngày mượn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(12, 82);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 2;
            label6.Text = "Họ và tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(12, 46);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 1;
            label5.Text = "Mã tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 0;
            label4.Text = "Mã vi phạm:";
            label4.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 126);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 50);
            panel4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(194, 30);
            label2.TabIndex = 0;
            label2.Text = "CHI TIẾT VI PHẠM";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1350, 100);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1167, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 34);
            panel2.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(106, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Xin chào Gia Hào | ";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Microsoft Sans Serif", 12F);
            label37.Location = new Point(13, 115);
            label37.Name = "label37";
            label37.Size = new Size(76, 20);
            label37.TabIndex = 27;
            label37.Text = "Nội dung:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label38.Location = new Point(135, 115);
            label38.Name = "label38";
            label38.Size = new Size(129, 21);
            label38.TabIndex = 28;
            label38.Text = "Quá hạn 1 ngày";
            // 
            // FormChiTietViPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "FormChiTietViPham";
            Text = "FormChiTietViPham";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void label35_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Add the missing method definition for panel5_Paint
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Add your custom paint logic here if needed
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Label label19;
        private Label label18;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label16;
        private Label label15;
        private Label label10;
        private Label label23;
        private Label label21;
        private Label label17;
        private Label label20;
        private Label label29;
        private Label label27;
        private Label label26;
        private Label label24;
        private Label label31;
        private Label label30;
        private Label label25;
        private Label label33;
        private Button button1;
        private Label label28;
        private Label label32;
        private Label label34;
        private Label label35;
        private Label label38;
        private Label label37;
    }
}