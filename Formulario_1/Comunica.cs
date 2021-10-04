using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_1
{
    public partial class Comunica : Form
    {
        public Comunica()
        {
            InitializeComponent();
        }

        private void btnTCP_Click(object sender, EventArgs e)
        {
            Formulario novaform = new Formulario();
            novaform.Show();
        }

        private void btnUDP_Click(object sender, EventArgs e)
        {
            gbComunica.Visible = true;
        }
    }
}
