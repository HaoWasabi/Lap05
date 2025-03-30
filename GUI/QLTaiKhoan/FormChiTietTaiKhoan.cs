using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.GUI.QLTaiKhoan
{
    public partial class FormChiTietTaiKhoan : Form
    {
        public FormChiTietTaiKhoan()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            panel4 = new Panel();
            label19 = new Label();
            label18 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel5 = new Panel();
            label17 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(268, 30);
            label2.TabIndex = 0;
            label2.Text = "THÔNG TIN THÀNH VIÊN";
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(246, 263);
            label19.Name = "label19";
            label19.Size = new Size(137, 21);
            label19.TabIndex = 15;
            label19.Text = "09:02 15/04/2025";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(246, 225);
            label18.Name = "label18";
            label18.Size = new Size(96, 21);
            label18.TabIndex = 14;
            label18.Text = "15/04/2025";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.Location = new Point(443, 153);
            label16.Name = "label16";
            label16.Size = new Size(96, 21);
            label16.TabIndex = 12;
            label16.Text = "15/04/2004";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.Location = new Point(443, 116);
            label15.Name = "label15";
            label15.Size = new Size(115, 21);
            label15.TabIndex = 11;
            label15.Text = "a@gmail.com";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(443, 82);
            label14.Name = "label14";
            label14.Size = new Size(91, 21);
            label14.TabIndex = 10;
            label14.Text = "123456789";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(443, 46);
            label13.Name = "label13";
            label13.Size = new Size(119, 21);
            label13.TabIndex = 9;
            label13.Text = "Nguyễn Văn A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(443, 11);
            label12.Name = "label12";
            label12.Size = new Size(64, 21);
            label12.TabIndex = 8;
            label12.Text = "123456";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(12, 263);
            label11.Name = "label11";
            label11.Size = new Size(226, 20);
            label11.TabIndex = 7;
            label11.Text = "Tài khoản cập nhật lần cuối lúc";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(13, 226);
            label10.Name = "label10";
            label10.Size = new Size(227, 20);
            label10.TabIndex = 6;
            label10.Text = "Tài khoản được duyệt vào ngày";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(13, 189);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 5;
            label9.Text = "Vai trò:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(13, 153);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 4;
            label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(13, 116);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 3;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(12, 82);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 2;
            label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(12, 46);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 1;
            label5.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 0;
            label4.Text = "Mã tài khoản:";
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
            // panel6
            // 
            panel6.BackColor = Color.Navy;
            panel6.Controls.Add(label3);
            panel6.Location = new Point(0, 679);
            panel6.Name = "panel6";
            panel6.Size = new Size(1350, 50);
            panel6.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 729);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(1030, 238);
            button3.Name = "button3";
            button3.Size = new Size(300, 50);
            button3.TabIndex = 10;
            button3.Text = "KHÓA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1030, 182);
            button2.Name = "button2";
            button2.Size = new Size(300, 50);
            button2.TabIndex = 9;
            button2.Text = "SỬA";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1030, 126);
            button1.Name = "button1";
            button1.Size = new Size(300, 50);
            button1.TabIndex = 8;
            button1.Text = "ĐỔI VAI TRÒ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
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
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.Location = new Point(443, 188);
            label17.Name = "label17";
            label17.Size = new Size(74, 21);
            label17.TabIndex = 20;
            label17.Text = "member";
            label17.Click += label17_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1350, 100);
            panel3.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(1030, 294);
            button4.Name = "button4";
            button4.Size = new Size(300, 50);
            button4.TabIndex = 11;
            button4.Text = "XÓA";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormChiTietTaiKhoan
            // 
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "FormChiTietTaiKhoan";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);

        }
        private Label label1;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label label2;
        private Panel panel4;
        private Label label19;
        private Label label18;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel6;
        private Panel panel1;
        private Panel panel5;
        private Panel panel3;
        private Label label17;

        private void label17_Click(object sender, EventArgs e)
        {

        }
        private Button button3;
        private Button button2;
        private Button button1;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private Button button4;
    }
}
