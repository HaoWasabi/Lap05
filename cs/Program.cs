using System;
using System.Windows.Forms;

namespace QuanLyThuQuan
{
    class Program
    {
        [STAThread] // Cần thiết cho Windows Forms
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BookDetails()); // Chạy Form chính
        }
    }

    public class MyForm : Form
    {
        public MyForm()
        {
            this.Text = "Hello World";
            Label label = new Label();
            label.Text = "Hello World";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point((this.ClientSize.Height - label.Height) / 2, (this.ClientSize.Width - label.Width) / 2 ) ;

            this.Controls.Add(label); // Thêm Label vào Form
        }
    }
}
