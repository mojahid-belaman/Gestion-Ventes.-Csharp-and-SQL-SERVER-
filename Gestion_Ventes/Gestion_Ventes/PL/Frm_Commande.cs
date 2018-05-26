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
    public partial class Frm_Commande : Form
    {
        BL.CLS_COMMANDE cmd = new BL.CLS_COMMANDE();

        public Frm_Commande()
        {
            InitializeComponent();
            this.dgvCommande.DataSource = cmd.ALL_COMMANDE();
        }

        private void txtSearchCmd_TextChanged(object sender, EventArgs e)
        {
            try
            {
               this.dgvCommande.DataSource = cmd.SEARCH_COMMANDE(txtSearchCmd.Text);
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

        private void btnImprimerCmd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int cmd_ID = Convert.ToInt32(dgvCommande.CurrentRow.Cells[0].Value.ToString());
                RPT.RPT_ORDERS report = new RPT.RPT_ORDERS();
                RPT.RPT_PRODUCT frm = new RPT.RPT_PRODUCT();
                report.SetDataSource(cmd.GETORDERDETAIL(cmd_ID));
                frm.crystalReportViewer1.ReportSource = report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-Vous Vraiment Supprimer Commande Sélectionné ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cmd.DELETE_Commande(Convert.ToInt32(this.dgvCommande.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Suppression réussie", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dgvCommande.DataSource = cmd.ALL_COMMANDE();

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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Frm_Vente frm = new Frm_Vente();
            frm.ShowDialog();
        }
    }
}
