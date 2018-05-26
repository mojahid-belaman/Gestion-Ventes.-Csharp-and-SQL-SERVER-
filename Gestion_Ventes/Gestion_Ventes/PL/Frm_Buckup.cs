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

namespace Gestion_Ventes.PL
{
    public partial class Frm_Buckup : Form
    {
        SqlConnection ocon = new SqlConnection("Server = ADMINRG-20JDAQU; Database = Gestion_Vente_DB; Integrated Security = true");
        SqlCommand cmd;
        public Frm_Buckup()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName.Text == string.Empty)
                {
                    MessageBox.Show("S'il Vous Plait Enregistrer Votre Chemin de Sauvegarde Base de Donner de Cette Application", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string fileName = txtFileName.Text + "\\Gestion_Vente_DB" + DateTime.Now.ToShortDateString().Replace('/', '-') + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                cmd = new SqlCommand("Backup Database Gestion_Vente_DB To Disk = '" + fileName + ".bak'", ocon);
                ocon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sauvegarde a été créé avec succès", "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ocon.Close();
            }
        }
    }
}
