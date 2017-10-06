using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cria uma lista que armazena o tipo Conta
            List<Usuario> lista = new List<Usuario>();
            Usuario a1 = new Usuario();

          //  listBox1.Items.Add(id.Text);
            listBox1.Items.Add(nome.Text);
            
            id.Text = Convert.ToString(a1.Id);
            nome.Text = Convert.ToString(a1.Nome);


        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
