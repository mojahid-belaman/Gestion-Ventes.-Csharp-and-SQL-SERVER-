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
    public partial class Gestion_User : Form
    {
        BL.CLS_LOGIN user = new BL.CLS_LOGIN();
        public Gestion_User()
        {
            InitializeComponent();
            this.dgvutilisateur.DataSource = user.ALL_USER();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Frm_ADD_USER frm = new Frm_ADD_USER();
            frm.ShowDialog();
            this.dgvutilisateur.DataSource = user.ALL_USER();

        }

        private void txtSearchUti_TextChanged(object sender, EventArgs e)
        {
            this.dgvutilisateur.DataSource = user.SEARCH_USER(txtSearchUti.Text);
        }

        private void btnImprimerUti_Click(object sender, EventArgs e)
        {
            Frm_ADD_USER frm = new Frm_ADD_USER();
            frm.txtNomUti.ReadOnly = true;
            frm.labelAdd_Utili.Text = "Mise à Jour d'utilisateur : " + this.dgvutilisateur.CurrentRow.Cells[1].Value.ToString();
            frm.txtNomUti.Text = this.dgvutilisateur.CurrentRow.Cells[0].Value.ToString();
            frm.txtNomCom.Text = this.dgvutilisateur.CurrentRow.Cells[1].Value.ToString();
            frm.txtPsw.Text = this.dgvutilisateur.CurrentRow.Cells[2].Value.ToString();
            frm.txtCPSW.Text = this.dgvutilisateur.CurrentRow.Cells[2].Value.ToString();
            frm.cb.Text = this.dgvutilisateur.CurrentRow.Cells[3].Value.ToString();
            frm.btnSave.Text = "Mise à Jour";
            frm.ShowDialog();
            this.dgvutilisateur.DataSource = user.ALL_USER();

        }

        private void btnSuprimerUti_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-Vous Vraiment Supprimer le Produit Sélectionné ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    user.DELETE_USER(this.dgvutilisateur.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Suppression réussie", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dgvutilisateur.DataSource = user.ALL_USER();

                }
                else
                {
                    MessageBox.Show("Annuler Processus Suppression", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
