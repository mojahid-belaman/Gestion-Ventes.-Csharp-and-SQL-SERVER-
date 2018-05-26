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
using Gestion_Ventes.Properties;

namespace Gestion_Ventes.PL
{
    public partial class Gestion_Client : Form
    {
        private static Gestion_Client frmGC;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGC = null;
        }

        public static Gestion_Client getGestion_Client
        {
            get
            {
                if (frmGC == null)
                {
                    frmGC = new Gestion_Client();
                    frmGC.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frmGC;
            }
        }

        CLS_CUSTOMERS cli = new CLS_CUSTOMERS();
        public Gestion_Client()
        {
            InitializeComponent();
            if (frmGC == null)
            {
                frmGC = this;
            }
            this.dgvClient.DataSource = cli.ALL_CUSTOMERS();
            dgvClient.Columns[0].Visible = false;
            dgvClient.Columns[6].Visible = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ADD_CLIENT ac = new ADD_CLIENT();
            ac.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                ADD_CLIENT frm = new ADD_CLIENT();
                frm.ID = Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value.ToString());
                frm.txtName.Text = this.dgvClient.CurrentRow.Cells[1].Value.ToString();
                frm.txtPrn.Text = this.dgvClient.CurrentRow.Cells[2].Value.ToString();
                frm.txtTele.Text = this.dgvClient.CurrentRow.Cells[3].Value.ToString();
                frm.txtEmail.Text = this.dgvClient.CurrentRow.Cells[4].Value.ToString();
                frm.cbCity.Text = this.dgvClient.CurrentRow.Cells[5].Value.ToString();
                frm.labelAdd_Produit.Text = "Mise à Jour du Client : " + this.dgvClient.CurrentRow.Cells[1].Value.ToString() + "  " + this.dgvClient.CurrentRow.Cells[2].Value.ToString();
                frm.btnAdd.Text = "Mise à Jour";
                frm.state = "Update";
                byte[] image = (byte[])cli.GET_IMG_CLIENT(Convert.ToInt32(this.dgvClient.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                frm.pbImg.Image = Image.FromStream(ms);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-Vous Vraiment Supprimer le Produit Sélectionné ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cli.DELETE_CLIENT(Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Suppression réussie", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dgvClient.DataSource = cli.ALL_CUSTOMERS();

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

        private void btnImgCli_Click(object sender, EventArgs e)
        {
            try
            {
                Image_Client frm = new Image_Client();
                frm.label1.Text = "Image du Client : " + this.dgvClient.CurrentRow.Cells[1].Value.ToString() + "  " + this.dgvClient.CurrentRow.Cells[2].Value.ToString();
                byte[] image = (byte[])cli.GET_IMG_CLIENT(Convert.ToInt32(this.dgvClient.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                frm.Img_Client.Image = Image.FromStream(ms);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtSech_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cli.SEARCH_CLIENT(txtSech.Text);
            this.dgvClient.DataSource = dt;
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
