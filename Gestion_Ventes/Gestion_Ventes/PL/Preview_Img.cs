using Gestion_Ventes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ventes.PL
{
    public partial class Preview_Img : Form
    {
        public Preview_Img()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.Close3a;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.Close3b;

        }
    }
}
