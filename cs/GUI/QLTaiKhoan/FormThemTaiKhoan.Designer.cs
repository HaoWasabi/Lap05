using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class FormThemTaiKhoan
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
            label1 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            panel4 = new Panel();
            button4 = new Button();
            comboBox1 = new ComboBox();
            label19 = new Label();
            label18 = new Label();
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
            panel5 = new Panel();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            panel3 = new Panel();
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
            label2.Size = new Size(209, 30);
            label2.TabIndex = 0;
            label2.Text = "THÊM THÀNH VIÊN";
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
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(770, 325);
            button4.Name = "button4";
            button4.Size = new Size(222, 50);
            button4.TabIndex = 19;
            button4.Text = "Lưu";
            button4.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(443, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 33);
            comboBox1.TabIndex = 18;
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
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 729);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(label12);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(443, 11);
            label12.Name = "label12";
            label12.Size = new Size(64, 21);
            label12.TabIndex = 25;
            label12.Text = "123456";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(443, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 33);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(443, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 33);
            textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(443, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 33);
            textBox3.TabIndex = 22;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(443, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 33);
            textBox2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1350, 100);
            panel3.TabIndex = 1;
            // 
            // FormThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "FormThemTaiKhoan";
            Text = "FormThemTaiKhoan";
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
        // Add the missing event handler method for panel1_Paint
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Add your custom paint logic here
        }
        // Add the missing event handler method for panel8_Paint
        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // Add your custom paint logic here
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label label2;
        private Panel panel4;
        private Button button4;
        private ComboBox comboBox1;
        private Label label19;
        private Label label18;
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label12;
    }
}