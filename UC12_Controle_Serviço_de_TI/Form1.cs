using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_Controle_Serviço_de_TI
{
    public partial class Form_MENU_ORDEM : Form
    {
        public Form_MENU_ORDEM()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form nova_ordem = new FormNOVAORDEM();
            nova_ordem.ShowDialog();
            
        }

        private void toolStripMenuItem1_ORDEM_Click(object sender, EventArgs e)
        {

        }
    }
}
