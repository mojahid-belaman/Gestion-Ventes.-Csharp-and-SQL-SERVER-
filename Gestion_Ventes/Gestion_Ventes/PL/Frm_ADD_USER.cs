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
    public partial class Frm_ADD_USER : Form
    {
        BL.CLS_LOGIN user = new BL.CLS_LOGIN();
        public Frm_ADD_USER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNomUti.Text == string.Empty || txtNomCom.Text == string.Empty || txtPsw.Text == string.Empty || txtCPSW.Text == string.Empty || cb.Text == string.Empty)
            {
                MessageBox.Show("S'il vous plaît entrer toutes les données", "avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnSave.Text == "Ajouter Utilisateur")
            {
                user.ADD_USER(txtNomUti.Text, txtNomCom.Text, txtPsw.Text, cb.Text);
                MessageBox.Show("L'utilisateur a été créé avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnSave.Text == "Mise à Jour")
            {
                user.UPDATE_USER(txtNomUti.Text, txtNomCom.Text, txtPsw.Text, cb.Text);
                MessageBox.Show("Il a Mise à Jour avec succès", "Processus Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            txtNomUti.Clear();
            txtNomCom.Clear();
            txtPsw.Clear();
            txtCPSW.Clear();
            cb.Text = null;
            txtNomUti.Focus();
        }

        private void txtCPSW_Validated(object sender, EventArgs e)
        {
            if (txtPsw.Text != txtCPSW.Text)
            {
                MessageBox.Show("S'il vous plaît Le mot de passe ne sont pas identiques", "avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPSW.Focus();
                txtCPSW.SelectionStart = 0;
                txtCPSW.SelectionLength = txtCPSW.TextLength;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
