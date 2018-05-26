using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Gestion_Ventes.Properties;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;


namespace Gestion_Ventes.PL
{
    public partial class Catégorie : Form
    {
        BL.CLS_Product prd = new BL.CLS_Product();

        SqlConnection con = new SqlConnection("Server = ADMINRG-20JDAQU; Database = Gestion_Vente_DB; Integrated Security = true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public Catégorie()
        {
            InitializeComponent();

            da = new SqlDataAdapter("SELECT ID_CAT AS [ID de Catégorie], DESCRIPTION_CAT AS [Description Catégorie] FROM CATEGORIE", con);
            da.Fill(dt);
            dgvCategorie.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "ID de Catégorie");
            txtName.DataBindings.Add("text", dt, "Description Catégorie");
            bmb = this.BindingContext[dt];
            labelPos.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void pictureFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            labelPos.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void pictureLast_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            labelPos.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void picturePreview_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            labelPos.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void pictureNext_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            labelPos.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnAjouter.Enabled = true;
            btnNew.Enabled = false;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtID.Text = id.ToString();
            txtName.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("Saisir Description Catégorie SVP !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }
                else
                {
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBox.Show("Il a ajouté avec succès", "Ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.Enabled = true;
                    btnAjouter.Enabled = false;
                    labelPos.Text = (bmb.Position + 1) + " / " + bmb.Count;
                    this.dgvCategorie.DataSource = prd.All_Categorie();
                }
                
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
                if (MessageBox.Show("Voulez-Vous Vraiment Supprimer Catégorie Sélectionné ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bmb.RemoveAt(bmb.Position);
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBox.Show("Suppression réussie", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelPos.Text = (bmb.Position + 1) + " / " + bmb.Count;
                    this.dgvCategorie.DataSource = prd.All_Categorie();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Mise à Jour avec succès", "Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelPos.Text = (bmb.Position + 1) + " / " + bmb.Count;
                this.dgvCategorie.DataSource = prd.All_Categorie();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimerAll_Click(object sender, EventArgs e)
        {
            //RPT.RPT_ALL_CATEGORIE myReport = new RPT.RPT_ALL_CATEGORIE();
            //RPT.RPT_PRODUCT frm = new RPT.RPT_PRODUCT();
            //myReport.Refresh();
            //frm.crystalReportViewer1.ReportSource = myReport;
            //frm.ShowDialog();
        }

        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Title = "Save to:";
            //saveFileDialog1.FileName = "Categories List.pdf";
            //saveFileDialog1.Filter = "PDF file |*.pdf";

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string Path = saveFileDialog1.FileName;

            //    RPT.RPT_ALL_CATEGORIE myReport = new RPT.RPT_ALL_CATEGORIE();

            //    // Create Export Option
            //    ExportOptions export = new ExportOptions();

            //    // Create Obect For Destination
            //    DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();

            //    PdfFormatOptions pdfformat = new PdfFormatOptions();

            //    // Set The Path Of Destination
            //    dfoption.DiskFileName = Path;

            //    export = myReport.ExportOptions;

            //    export.ExportDestinationType = ExportDestinationType.DiskFile;

            //    export.ExportFormatType = ExportFormatType.PortableDocFormat;

            //    export.ExportFormatOptions = pdfformat;

            //    export.ExportDestinationOptions = dfoption;

            //    myReport.Refresh();

            //    myReport.Export();

            //    MessageBox.Show("Liste Exportée avec Succès", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnImprimerSingle_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_CATEGORIE myReport = new RPT.RPT_SINGLE_CATEGORIE();
            RPT.RPT_PRODUCT frm = new RPT.RPT_PRODUCT();
            myReport.SetParameterValue("@ID", dgvCategorie.CurrentRow.Cells[0].Value.ToString());
            frm.crystalReportViewer1.ReportSource = myReport;
            frm.ShowDialog();
        }

        private void btnSaveCatPro_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save to:";
            saveFileDialog1.FileName = "Categories Details.pdf";
            saveFileDialog1.Filter = "PDF file |*.pdf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Path = saveFileDialog1.FileName;

                RPT.RPT_SINGLE_CATEGORIE myReport = new RPT.RPT_SINGLE_CATEGORIE();

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

                myReport.SetParameterValue("@ID", Convert.ToInt32(txtID.Text));

                myReport.Export();

                MessageBox.Show("Liste Exportée avec Succès", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //private void textSearch_TextChanged(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    dt = this.prd.Search_Categorie(textSearch.Text);
        //    this.dataGridView1.DataSource = dt;
        //}

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //this.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //this.txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void pbclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void pbclose_MouseHover_1(object sender, EventArgs e)
        {
            pbclose.Image = Resources.Close3a;
        }

        private void pbclose_MouseLeave_1(object sender, EventArgs e)
        {
            pbclose.Image = Resources.Close3b;
        }
    }
}
