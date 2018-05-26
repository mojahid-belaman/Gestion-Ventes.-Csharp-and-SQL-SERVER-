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
    public partial class Login : Form
    {
        public static bool k = true;

        BL.CLS_LOGIN log = new BL.CLS_LOGIN();

        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                t2.UseSystemPasswordChar = true;
                labelpwd.Text = "Cacher Password";
            }
            else
            {
                t2.UseSystemPasswordChar = false;
                labelpwd.Text = "Afficher Password";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(t1.Text, t2.Text);

            if (t1.Text == string.Empty && t2.Text == string.Empty)
            {
                MessageBox.Show("Saisir Nom d'utilisateur et Mot de Passe", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (t1.Text != string.Empty && t2.Text == string.Empty)
            {
                MessageBox.Show("Saisir Mot de Passe", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (t1.Text == string.Empty && t2.Text != string.Empty)
            {
                MessageBox.Show("Saisir Nom d'utilisateur", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (dt.Rows.Count > 0)
            {
                
               if (dt.Rows[0]["USERTYPE"].ToString() == "Administrateur")
                {
                    Gestion_Ventes.getGestion_Ventes.btnANC.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGC.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnANP.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGP.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGCAT.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnANU.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGU.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnsauv.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnCon.Enabled = false;
                    Gestion_Ventes.getGestion_Ventes.btnANV.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGV.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnDec.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnANU.Visible = true;
                    Gestion_Ventes.getGestion_Ventes.btnGU.Visible = true;
                    Gestion_Ventes.getGestion_Ventes.pictureANU.Visible = true;
                    Gestion_Ventes.getGestion_Ventes.pictureGU.Visible = true;
                    Program.NOM_VENDU = dt.Rows[0]["NAME"].ToString();
                    this.Close();
                }
                else if (dt.Rows[0]["USERTYPE"].ToString() == "User")
                {
                    Gestion_Ventes.getGestion_Ventes.btnANC.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGC.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnANP.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGP.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGCAT.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnANU.Visible = false;
                    Gestion_Ventes.getGestion_Ventes.btnGU.Visible = false;
                    Gestion_Ventes.getGestion_Ventes.btnsauv.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnCon.Enabled = false;
                    Gestion_Ventes.getGestion_Ventes.btnANV.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnGV.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.btnDec.Enabled = true;
                    Gestion_Ventes.getGestion_Ventes.pictureANU.Visible = false;
                    Gestion_Ventes.getGestion_Ventes.pictureGU.Visible = false;


                    Program.NOM_VENDU = dt.Rows[0]["NAME"].ToString();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Login Filed", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frm_MouseHover(object sender, EventArgs e)
        {
            frm.Image = Resources.Close3a;
        }

        private void frm_MouseLeave(object sender, EventArgs e)
        {
            frm.Image = Resources.Close3b;

        }

        private void minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void frm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
