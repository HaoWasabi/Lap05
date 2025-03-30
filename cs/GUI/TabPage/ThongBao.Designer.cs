namespace cs.GUI
{
    partial class ThongBao
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
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            llbTitle = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            columnThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            btnLast = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnPre = new System.Windows.Forms.Button();
            btnFirst = new System.Windows.Forms.Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(30, 89, 152);
            flowLayoutPanel1.Controls.Add(llbTitle);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1366, 50);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // llbTitle
            // 
            llbTitle.BackColor = System.Drawing.Color.FromArgb(30, 89, 152);
            llbTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            llbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            llbTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            llbTitle.Location = new System.Drawing.Point(3, 0);
            llbTitle.Name = "llbTitle";
            llbTitle.Size = new System.Drawing.Size(229, 50);
            llbTitle.TabIndex = 1;
            llbTitle.Text = "THÔNG BÁO CHUNG";
            llbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { columnDescription, columnThoiGian });
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(1366, 247);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // columnDescription
            // 
            columnDescription.HeaderText = "Mô tả";
            columnDescription.Name = "columnDescription";
            columnDescription.ReadOnly = true;
            // 
            // columnThoiGian
            // 
            columnThoiGian.HeaderText = "Thời gian";
            columnThoiGian.Name = "columnThoiGian";
            columnThoiGian.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(-1, 254);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1366, 40);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLast);
            panel3.Controls.Add(btnNext);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(1091, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(275, 40);
            panel3.TabIndex = 5;
            // 
            // btnLast
            // 
            btnLast.BackColor = System.Drawing.Color.FromArgb(0, 116, 211);
            btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLast.Dock = System.Windows.Forms.DockStyle.Right;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLast.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            btnLast.ForeColor = System.Drawing.Color.White;
            btnLast.Location = new System.Drawing.Point(140, 0);
            btnLast.Name = "btnLast";
            btnLast.Size = new System.Drawing.Size(135, 40);
            btnLast.TabIndex = 4;
            btnLast.Text = "Cuối trang";
            btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = System.Drawing.Color.FromArgb(0, 116, 211);
            btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            btnNext.ForeColor = System.Drawing.Color.White;
            btnNext.Location = new System.Drawing.Point(0, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(135, 40);
            btnNext.TabIndex = 3;
            btnNext.Text = "Trang sau";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel2.Controls.Add(btnPre);
            panel2.Controls.Add(btnFirst);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(276, 40);
            panel2.TabIndex = 0;
            // 
            // btnPre
            // 
            btnPre.BackColor = System.Drawing.Color.Silver;
            btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPre.Dock = System.Windows.Forms.DockStyle.Right;
            btnPre.Enabled = false;
            btnPre.FlatAppearance.BorderSize = 0;
            btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            btnPre.ForeColor = System.Drawing.Color.White;
            btnPre.Location = new System.Drawing.Point(141, 0);
            btnPre.Name = "btnPre";
            btnPre.Size = new System.Drawing.Size(135, 40);
            btnPre.TabIndex = 4;
            btnPre.Text = "Trang trước";
            btnPre.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = System.Drawing.Color.Silver;
            btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFirst.Dock = System.Windows.Forms.DockStyle.Left;
            btnFirst.Enabled = false;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFirst.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
            btnFirst.ForeColor = System.Drawing.Color.White;
            btnFirst.Location = new System.Drawing.Point(0, 0);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new System.Drawing.Size(135, 40);
            btnFirst.TabIndex = 3;
            btnFirst.Text = "Đầu trang";
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // ThongBao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Name = "ThongBao";
            Size = new System.Drawing.Size(1366, 297);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label llbTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnThoiGian;
    }
}
