using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova
{
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void tbnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tbnome.Text;
            string comp = tbcomp.Text;
            MessageBox.Show(nome,comp);
           
            

            

        }

        private void cbser_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
