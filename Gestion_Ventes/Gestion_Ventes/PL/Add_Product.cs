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

namespace Gestion_Ventes.PL
{
    public partial class Add_Product : Form
    {
        public string state = "Add";

        BL.CLS_Product prd = new BL.CLS_Product();

        public Add_Product()
        {
            InitializeComponent();

            cbCat.DataSource = prd.All_Categorie();
            cbCat.DisplayMember = "DESCRIPTION_CAT";
            cbCat.ValueMember = "ID_CAT";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images Files|*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pbclose.Image = Resources.Close3a;
        }

        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = Resources.Close3b;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "Add")
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();

                    prd.Add_Product(Convert.ToInt32(t1.Text), Convert.ToInt32(cbCat.SelectedValue)
                        , t2.Text, Convert.ToInt32(t3.Text), t4.Text, byteImage);
                    MessageBox.Show("Il a ajouté avec succès", "Processus Ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();

                    prd.UPDATE_PRODUIT(Convert.ToInt32(t1.Text), Convert.ToInt32(cbCat.SelectedValue)
                        , t2.Text, Convert.ToInt32(t3.Text), t4.Text, byteImage);
                    MessageBox.Show("Il a Mise à Jour avec succès", "Processus Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Gestions_Produit.getGestion_Produit.dataGridView1.DataSource = prd.All_Product();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                
        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void t3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void t1_Validated(object sender, EventArgs e)
        {
            try
            {
                if (state == "Add")
                {
                    DataTable dt = new DataTable();
                    dt = prd.VERIFYPRODUCTID(Convert.ToInt32(t1.Text));
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Cet identifiant existe déjà", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        t1.Focus();
                        t1.SelectionStart = 0;
                        t1.SelectionLength = t1.TextLength;

                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void t4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
