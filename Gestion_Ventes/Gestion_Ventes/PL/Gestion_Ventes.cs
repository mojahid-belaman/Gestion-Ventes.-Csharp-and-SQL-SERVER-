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
    public partial class Gestion_Ventes : Form
    {
        private static Gestion_Ventes frmGV;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGV = null;
        }

        public static Gestion_Ventes getGestion_Ventes
        {
            get
            {
                if (frmGV == null)
                {
                    frmGV = new Gestion_Ventes();
                    frmGV.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frmGV;
            }
        } 
        public static bool k = true;

        public Gestion_Ventes()
        {
            InitializeComponent();
            if (frmGV == null)
            {
                frmGV = this;
            }

            this.btnANC.Enabled = false;
            this.btnGC.Enabled = false;
            this.btnANP.Enabled = false;
            this.btnGP.Enabled = false;
            this.btnGCAT.Enabled = false;
            this.btnANU.Enabled = false;
            this.btnGU.Enabled = false;
            this.btnsauv.Enabled = false;
            this.btnANV.Enabled = false;
            this.btnGV.Enabled = false;
            this.btnDec.Enabled = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close3a;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Close3b;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

            int x = DateTime.Now.Second;
            x = x % 10;
            switch (x)
            {
                case 0:
                    {
                        label2.ForeColor = Color.Red; break;
                    }
                case 1:
                    {
                        label2.ForeColor = Color.OrangeRed; break;
                    }
                case 2:
                    {
                        label2.ForeColor = Color.Orange; break;
                    }
                case 3:
                    {
                        label2.ForeColor = Color.Yellow; break;
                    }
                case 4:
                    {
                        label2.ForeColor = Color.YellowGreen; break;
                    }
                case 5:
                    {
                        label2.ForeColor = Color.Green; break;
                    }
                case 6:
                    {
                        label2.ForeColor = Color.DarkOliveGreen; break;
                    }
                case 7:
                    {
                        label2.ForeColor = Color.Olive; break;
                    }
                case 8:
                    {
                        label2.ForeColor = Color.Orchid; break;
                    }
                case 9:
                    {
                        label2.ForeColor = Color.PaleVioletRed;
                        break;
                    }
            }

            if (k)
                label2.Location = new Point(label2.Location.X + 10, label2.Location.Y);
            else
                label2.Location = new Point(label2.Location.X - 1600, label2.Location.Y);
            if (label2.Location.X + label2.Width >= this.Width + 300)
                k = false;
            if (label2.Location.X <= 0)
                k = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();

        }

        private void btnGCAT_Click(object sender, EventArgs e)
        {
            Catégorie frm = new Catégorie();
            frm.ShowDialog();
        }

        private void btnANP_Click(object sender, EventArgs e)
        {
            Add_Product ap = new Add_Product();
            ap.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.btnANC.Enabled = false;
            this.btnGC.Enabled = false;
            this.btnANP.Enabled = false;
            this.btnGP.Enabled = false;
            this.btnGCAT.Enabled = false;
            this.btnANU.Enabled = false;
            this.btnGU.Enabled = false;
            this.btnsauv.Enabled = false;
            this.btnCon.Enabled = true;
            this.btnANV.Enabled = false;
            this.btnGV.Enabled = false;
            this.btnDec.Enabled = false;
        }

        private void btnGP_Click(object sender, EventArgs e)
        {
            Gestions_Produit frm = new Gestions_Produit();
            frm.ShowDialog();
        }

        private void btnANC_Click(object sender, EventArgs e)
        {
            ADD_CLIENT ac = new ADD_CLIENT();
            ac.ShowDialog();
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            Gestion_Client gc = new Gestion_Client();
            gc.ShowDialog();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            Frm_Commande frm = new Frm_Commande();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnANV_Click(object sender, EventArgs e)
        {
            Frm_Vente frm = new Frm_Vente();
            frm.ShowDialog();
        }

        private void btnANU_Click(object sender, EventArgs e)
        {
            Frm_ADD_USER frm = new Frm_ADD_USER();
            frm.ShowDialog();
        }

        private void btnGU_Click(object sender, EventArgs e)
        {
            Gestion_User frm = new Gestion_User();
            frm.ShowDialog();
        }

        private void btnsauv_Click(object sender, EventArgs e)
        {
            Frm_Buckup frm = new Frm_Buckup();
            frm.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Image = Resources.Close3a;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Resources.Close3b;

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Mojahid.BELAMAN");

        }

        private void Gestion_Ventes_Load(object sender, EventArgs e)
        {

        }
    }
}
