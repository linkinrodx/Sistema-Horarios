using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horarios4.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void catálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCatalogo nuevo = new FormCatalogo();
            nuevo.Show();
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHorarios nuevo = new FormHorarios();
            nuevo.Show();
        }
    }
}
