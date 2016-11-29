using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace dragon
{
    public partial class Pilas : Form
    {
        int i = 0;
        Stack pila = new Stack(5);
        Object[] ItemObject = new System.Object[5];
        public Pilas()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 cola = new Form1();
            this.Hide();
            cola.Show();
            
        }

        private void Pilas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            if (pila.Count== 5)
            {
                MessageBox.Show("Cola llena");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Texto vacio");
                }
                else
                {
                    pila.Push(textBox1.Text);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pila == null)
            {
                MessageBox.Show("llena");
            }
            else
            {
                try
                {
                    Object[] myStandardArray = pila.ToArray();
                    listBox1.Items.AddRange(myStandardArray);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro" + erro.Message);
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pila.Clear();
                listBox1.Items.Clear();

                i = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Quito + "+pila.Pop().ToString());
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Primer elemento + "+pila.Peek().ToString());
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
           
        }
    }
}
