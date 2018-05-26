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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;


namespace Gestion_Ventes.PL
{
    public partial class Gestions_Produit : Form
    {
        private static Gestions_Produit frmGP;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGP = null;
        }

        public static Gestions_Produit getGestion_Produit
        {
            get
            {
                if (frmGP == null)
                {
                    frmGP = new Gestions_Produit();
                    frmGP.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frmGP;
            }
        }


        BL.CLS_Product prd = new BL.CLS_Product();

        public Gestions_Produit()
        {
            InitializeComponent();
            if (frmGP == null)
            {
                frmGP = this;
            }
            this.dataGridView1.DataSource = prd.All_Product();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.Search_Produit(txtSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Product frm = new Add_Product();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-Vous Vraiment Supprimer le Produit Sélectionné ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prd.DELETE_PRODUIT(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Suppression réussie", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataGridView1.DataSource = prd.All_Product();

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

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Product frm = new Add_Product();
            frm.t1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.cbCat.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.t2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.t3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.t4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.labelAdd_Produit.Text = "Mise à Jour du Produit : " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.button2.Text = "Mise à Jour";
            frm.state = "Update";
            frm.t1.ReadOnly = true;
            byte[] image = (byte[])prd.GET_IMG_PRODUCT(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Preview_Img frm = new Preview_Img();
            frm.label1.Text = "Image du Produit : " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            byte[] image = (byte[])prd.GET_IMG_PRODUCT(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.Image_Produit.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_PRODUCT myReport = new RPT.RPT_ALL_PRODUCT();
            RPT.RPT_PRODUCT frm = new RPT.RPT_PRODUCT();
            frm.crystalReportViewer1.ReportSource = myReport;
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save to:";
            saveFileDialog1.FileName = "Produits List.pdf";
            saveFileDialog1.Filter = "PDF file |*.pdf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Path = saveFileDialog1.FileName;
                RPT.RPT_ALL_PRODUCT myReport = new RPT.RPT_ALL_PRODUCT();

                // Create Export Option
                ExportOptions export = new ExportOptions();

                // Create Obect For Destination
                DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();

                PdfFormatOptions pdfformat = new PdfFormatOptions();

                // Set The Path Of Destination
                dfoption.DiskFileName = Path;

                export = myReport.ExportOptions;

                export.ExportDestinationType = ExportDestinationType.DiskFile;

                export.ExportFormatType = ExportFormatType.PortableDocFormat;

                export.ExportFormatOptions = pdfformat;

                export.ExportDestinationOptions = dfoption;

                myReport.Export();

                MessageBox.Show("Liste Exportée avec Succès", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImprimerSingle_Click(object sender, EventArgs e)
        {
            RPT.rpt_product_single myreport = new RPT.rpt_product_single();
            RPT.RPT_PRODUCT frm = new RPT.RPT_PRODUCT();
            myreport.SetParameterValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.crystalReportViewer1.ReportSource = myreport;
            frm.ShowDialog();
        }
    }
}
