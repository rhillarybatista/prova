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
            string nom = tbnome.Text;
            string comp = tbcomp.Text;
            
            MessageBox.Show(nom);
            MessageBox.Show(comp);
            



        }

        private void cbser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbser.SelectedIndex == 0) 
            {
                int formatacao = cbser.SelectedIndex;
                int limpeza = cbser.SelectedIndex;
                int troca = cbser.SelectedIndex;
                if (formatacao == 100)
                {
                    formatacao = 100;
                    MessageBox.Show(Convert.ToString(formatacao));
                }
                if (limpeza == 50)
                {
                    limpeza = 50;
                    MessageBox.Show(Convert.ToString(limpeza));
                }
                if (troca == 200)
                {
                    troca = 200;
                    MessageBox.Show(Convert.ToString(troca));
                }

            }
        }
    }
}
