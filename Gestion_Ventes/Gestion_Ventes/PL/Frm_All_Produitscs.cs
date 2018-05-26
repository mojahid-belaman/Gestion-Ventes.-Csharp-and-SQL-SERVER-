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
    public partial class Frm_All_Produitscs : Form
    {
        CLS_Product prd = new CLS_Product();

        public Frm_All_Produitscs()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.All_Product();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
