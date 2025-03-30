using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcomeUser_Click(object sender, EventArgs e)
        {

        }
    }
}
