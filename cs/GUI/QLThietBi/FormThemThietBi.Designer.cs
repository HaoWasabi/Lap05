using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1.Properties
{
    partial class FormThemThietBi
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
            label2 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            button6 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button4 = new Button();
            panel7 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(162, 30);
            label2.TabIndex = 0;
            label2.Text = "THÊM THIẾT BỊ";
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
            panel1.TabIndex = 6;
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
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(button6);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Font = new Font("Segoe UI", 14.25F);
            panel5.Location = new Point(0, 168);
            panel5.Name = "panel5";
            panel5.Size = new Size(1000, 390);
            panel5.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = Color.Green;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(765, 296);
            button6.Name = "button6";
            button6.Size = new Size(222, 50);
            button6.TabIndex = 23;
            button6.Text = "Lưu";
            button6.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(443, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 33);
            comboBox1.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(443, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 33);
            textBox1.TabIndex = 21;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(12, 296);
            button4.Name = "button4";
            button4.Size = new Size(220, 50);
            button4.TabIndex = 20;
            button4.Text = "ĐỔI ẢNH";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDark;
            panel7.Location = new Point(12, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 250);
            panel7.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(297, 85);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 2;
            label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(297, 49);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 1;
            label5.Text = "Tên thiết bị:";
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
            // FormThemThietBi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "FormThemThietBi";
            Text = "FormThemThietBi";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Panel panel6;
        private Label label3;
        private Panel panel5;
        private Button button6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button4;
        private Panel panel7;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}