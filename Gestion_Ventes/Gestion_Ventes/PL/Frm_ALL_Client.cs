using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Ventes.BL;

namespace Gestion_Ventes.PL
{

    public partial class Frm_ALL_Client : Form
    {
        CLS_CUSTOMERS cli = new CLS_CUSTOMERS();

        public Frm_ALL_Client()
        {
            InitializeComponent();
            this.dgvClient.DataSource = cli.ALL_CUSTOMERS();
            this.dgvClient.Columns[0].Visible = false;
            this.dgvClient.Columns[6].Visible = false;

        }

        private void dgvClient_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
