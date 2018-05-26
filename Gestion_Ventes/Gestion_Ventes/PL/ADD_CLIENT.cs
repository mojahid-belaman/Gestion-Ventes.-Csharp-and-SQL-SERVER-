using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Gestion_Ventes.BL;
using Gestion_Ventes.Properties;

namespace Gestion_Ventes.PL
{
    public partial class ADD_CLIENT : Form
    {
        public string state = "Add";

        CLS_CUSTOMERS cli = new CLS_CUSTOMERS();

        public int ID;

        public ADD_CLIENT()
        {
            InitializeComponent();
            cbCity.DataSource = cli.All_CITY();
            cbCity.DisplayMember = "CITY_NAME";
            cbCity.ValueMember = "CITY_ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] byteImage;

                if (state == "Add")
                {
                    MemoryStream ms = new MemoryStream();
                    pbImg.Image.Save(ms, pbImg.Image.RawFormat);
                    byteImage = ms.ToArray();

                    cli.ADD_COSTOMERS(txtName.Text, txtPrn.Text, Convert.ToInt32(txtTele.Text)
                        , txtEmail.Text, byteImage, Convert.ToInt32(cbCity.SelectedValue));
                    MessageBox.Show("Il a ajouté avec succès", "Processus Ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbImg.Image.Save(ms, pbImg.Image.RawFormat);
                    byteImage = ms.ToArray();

                    cli.UPDATE_COSTOMERS(txtName.Text, txtPrn.Text, Convert.ToInt32(txtTele.Text)
                        , txtEmail.Text, byteImage, Convert.ToInt32(cbCity.SelectedValue), ID);
                    MessageBox.Show("Il a Mise à Jour avec succès", "Processus Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Gestion_Client.getGestion_Client.dgvClient.DataSource = cli.ALL_CUSTOMERS();
            }
           catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images Files|*.JPG; *.PNG; *.GIF; *.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbImg.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrn.Focus();
            }
        }

        private void txtPrn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTele.Focus();
            }
        }

        private void txtTele_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCity.Focus();
            }
        }

        private void cbCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbclose_MouseHover(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
