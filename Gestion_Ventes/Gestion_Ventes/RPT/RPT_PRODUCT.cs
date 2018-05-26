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

namespace Gestion_Ventes.RPT
{
    public partial class RPT_PRODUCT : Form
    {
        public RPT_PRODUCT()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            btnfrm.Image = Resources.Close3a;
        }

        private void btnfrm_MouseLeave(object sender, EventArgs e)
        {
            btnfrm.Image = Resources.Close3b;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

    }
}
