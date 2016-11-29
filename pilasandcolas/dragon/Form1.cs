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
    public partial class Form1 : Form
    {
        int i = 0;
        Queue my = new Queue(5);
       Object[] ItemObject = new System.Object[5];

       public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            if (i >= 5)
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
                    my.Enqueue(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
    
            try
            {
                Object[] myStandardArray = my.ToArray();
                listBox1.Items.AddRange(myStandardArray);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                my.Clear();
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
                MessageBox.Show("Primer elemento " + my.Peek().ToString());
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Sea quitado " + my.Dequeue().ToString());
            }
            catch (Exception ar)
            {
                MessageBox.Show(ar.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pilas foc = new Pilas();
            this.Hide();
            foc.Show();
        }

    }
}
