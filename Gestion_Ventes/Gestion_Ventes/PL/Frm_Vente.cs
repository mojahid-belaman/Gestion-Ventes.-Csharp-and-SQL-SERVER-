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
using System.IO;
using Gestion_Ventes.BL;

namespace Gestion_Ventes.PL
{
    public partial class Frm_Vente : Form
    {
        CLS_COMMANDE cmd = new CLS_COMMANDE();

        DataTable dt = new DataTable();

        void CalculeTotalMontant()
        {
            if (txtTaux.Text != string.Empty && txtMontant.Text != string.Empty)
            {
                double discount = Convert.ToDouble(txtTaux.Text);
                double montant = Convert.ToDouble(txtMontant.Text);
                double total = montant - (montant * (discount / 100));
                txtTotale.Text = total.ToString();
            }
            
        }
        void CalculMontant()
        {
            if (txtPrice.Text != string.Empty && txtQte.Text != string.Empty)
            {
                double montant = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQte.Text);
                txtMontant.Text = montant.ToString();
            }
            
        }

        void ClearTxtBox()
        {
            txtID.Clear();
            txtNom.Clear();
            txtPrice.Clear();
            txtQte.Clear();
            txtMontant.Clear();
            txtTaux.Clear();
            txtTotale.Clear();
        }

        void ClearData()
        {
            txtCmdID.Clear();
            txtDescCmd.Clear();
            dtp.ResetText();
            txtVen.Clear();
            txtIDCli.Clear();
            txtName.Clear();
            txtPrn.Clear();
            txtTele.Clear();
            txtEmail.Clear();
            txtVille.Clear();
            ClearTxtBox();
            dt.Clear();
            dgvProduct.DataSource = null;
            txtSum.Clear();
            imgCli.Image = null;
            btnSave.Enabled = false;
            btnImp.Enabled = true;
        }

        void CreateDataTable()
        {
            dt.Columns.Add("ID Produit");
            dt.Columns.Add("Nom Produit");
            dt.Columns.Add("Prix de Produit");
            dt.Columns.Add("Quantité de produit");
            dt.Columns.Add("Montant");
            dt.Columns.Add("Taux d'actualisation(%)");
            dt.Columns.Add("Montant Total");

            dgvProduct.DataSource = dt;

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "Choix du Produit";
            //btn.Text = "Chereche";
            //dgvProduct.Columns.Insert(0, btn);
            //btn.UseColumnTextForButtonValue = true;
        }

        void ResizeDGV()
        {
            this.dgvProduct.RowHeadersWidth = 59;
            this.dgvProduct.Columns[0].Width = 100;
            this.dgvProduct.Columns[1].Width = 284;
            this.dgvProduct.Columns[2].Width = 186;
            this.dgvProduct.Columns[3].Width = 216;
            this.dgvProduct.Columns[4].Width = 169;
            this.dgvProduct.Columns[5].Width = 206;
            this.dgvProduct.Columns[6].Width = 131;
        }

        public Frm_Vente()
        {
            InitializeComponent();
            CreateDataTable();
            ResizeDGV();
            txtVen.Text = Program.NOM_VENDU;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtCmdID.Text = cmd.LASR_COMMANDE_ID().Rows[0][0].ToString();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescCmd.Text == string.Empty || txtIDCli.Text == string.Empty || dgvProduct.Rows.Count < 0)
            {
                MessageBox.Show("Entrez Tout les Données du Ventes", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ADD SINGLE COMMANDE
            cmd.ADD_CMMANDE(Convert.ToInt32(txtCmdID.Text), Convert.ToInt32(txtIDCli.Text), dtp.Value, txtDescCmd.Text, txtVen.Text);

            //ADD ALL DETAIL_CMD
            for (int i = 0; i < dgvProduct.Rows.Count - 1; i++)
            {

                cmd.ADD_CMD_DETAIL(Convert.ToInt32(dgvProduct.Rows[i].Cells[0].Value),
                                   Convert.ToInt32(txtCmdID.Text),
                                   Convert.ToInt32(dgvProduct.Rows[i].Cells[3].Value),
                                   Convert.ToDecimal(dgvProduct.Rows[i].Cells[2].Value),
                                   Convert.ToDouble(dgvProduct.Rows[i].Cells[4].Value),
                                      dgvProduct.Rows[i].Cells[5].Value.ToString(),
                                      dgvProduct.Rows[i].Cells[6].Value.ToString());
            }

            MessageBox.Show("Sauvegarder L'opération a Réussi", "Sauvegarder Opération", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ALL_Client frm = new Frm_ALL_Client();
                frm.ShowDialog();
                this.txtIDCli.Text = frm.dgvClient.CurrentRow.Cells[0].Value.ToString();
                this.txtName.Text = frm.dgvClient.CurrentRow.Cells[1].Value.ToString();
                this.txtPrn.Text = frm.dgvClient.CurrentRow.Cells[2].Value.ToString();
                this.txtTele.Text = frm.dgvClient.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = frm.dgvClient.CurrentRow.Cells[4].Value.ToString();
                this.txtVille.Text = frm.dgvClient.CurrentRow.Cells[5].Value.ToString();
                byte[] clipicture = (byte[])frm.dgvClient.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(clipicture);
                imgCli.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Frm_All_Produitscs frm = new Frm_All_Produitscs();
            frm.ShowDialog();
            this.txtID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtNom.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.txtQte.Focus();

        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQte.Text != string.Empty && txtQte.Text != "0")
            {
                txtTaux.Focus();
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculMontant();
            CalculeTotalMontant();
        }

        private void txtQte_KeyUp(object sender, KeyEventArgs e)
        {
            CalculMontant();
            CalculeTotalMontant();
        }

        private void txtTaux_KeyUp(object sender, KeyEventArgs e)
        {
            CalculeTotalMontant();
        }

        private void txtTaux_KeyDown(object sender, KeyEventArgs e)
        {
            double sum = 0;

            
            if (e.KeyCode == Keys.Enter && txtTaux.Text != string.Empty && txtQte.Text != "0")
            {
                if (cmd.VERIFY_QTE(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtQte.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("Quantité entré pour ce produit ne sont pas disponibles", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQte.Focus();
                    return;

                }

                for (int i = 0; i < dgvProduct.Rows.Count - 1; i++)
                {
                    if (dgvProduct.Rows[i].Cells[0].Value.ToString() == txtID.Text)
                    {
                        MessageBox.Show("Cet Produit Existe Déjà", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearTxtBox();
                        btn.Focus();
                        return;
                    }
                }

                DataRow dr = dt.NewRow();
                dr[0] = txtID.Text;
                dr[1] = txtNom.Text;
                dr[2] = txtPrice.Text;
                dr[3] = txtQte.Text;
                dr[4] = txtMontant.Text;
                dr[5] = txtTaux.Text;
                dr[6] = txtTotale.Text;

                dt.Rows.Add(dr);

                dgvProduct.DataSource = dt;

                ClearTxtBox();

                for (int i = 0; i < dgvProduct.Rows.Count - 1; i++)
                {
                    sum += Convert.ToDouble(dgvProduct.Rows[i].Cells[6].Value);
                }
                txtSum.Text = sum.ToString();

                btn.Focus();


            }
        }

        private void txtTaux_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (txtQte.Text == string.Empty && txtTaux.Text == string.Empty)
                {
                    txtID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                    txtNom.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                    txtPrice.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
                    txtQte.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
                    txtMontant.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
                    txtTaux.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
                    txtTotale.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();
                    dgvProduct.Rows.RemoveAt(dgvProduct.CurrentRow.Index);
                    txtQte.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvProduct_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                double sum = 0;

                for (int i = 0; i < dgvProduct.Rows.Count - 1; i++)
                {
                    sum += Convert.ToDouble(dgvProduct.Rows[i].Cells[6].Value);
                }
                txtSum.Text = sum.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProduct_DoubleClick(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void supprimerLaLigneActuelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.Rows.RemoveAt(dgvProduct.CurrentRow.Index);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void supprimerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dgvProduct.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int cmd_ID = Convert.ToInt32(cmd.LASR_ORDER_FOR_PRINT().Rows[0][0]);
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
    }
}
