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
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.Date.ToShortDateString());
            listBox1.Items.Add(DateTime.Now.TimeOfDay.ToString());
            listBox1.Items.Add(textBox1.Text);
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
    }
}
