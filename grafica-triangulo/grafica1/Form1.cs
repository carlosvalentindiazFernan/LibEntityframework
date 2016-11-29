using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace grafica1
{
    public partial class Form1 : Form
    {
        double a, b,resultado,resultado2,resultado3,perro, Area=0,TAO;
        public Form1()
        {
            InitializeComponent();
        }
       
            public class Win32
            {
                [DllImport("kernel32.dll")]
                public static extern Boolean AllocConsole();
                [DllImport("kernel32.dll")]
                public static extern Boolean FreeConsole();
            }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            Win32.AllocConsole();
            puntos punto1 = new puntos();
            Dista dimencionVectorial = new Dista();
            punto1.asignar();
            chart1.Series["Series1"].Points.AddXY(punto1.X1,punto1.Y1);
            chart1.Series["Series1"].Points.AddXY(punto1.X2, punto1.Y2);
            //Linea 2
            chart1.Series["Series1"].Points.AddXY(punto1.x3, punto1.y3);

            chart1.Series["Series1"].Points.AddXY(punto1.X1, punto1.Y1);

            resultado = Math.Sqrt( Math.Pow((punto1.X2 - punto1.X2),2) + Math.Pow((punto1.Y2 - punto1.Y1),2));
            resultado2 = Math.Sqrt(Math.Pow((punto1.x3 - punto1.X2), 2) + Math.Pow((punto1.y3 - punto1. Y2), 2));
            resultado3 = Math.Sqrt(Math.Pow((punto1.x3 - punto1.X1), 2) + Math.Pow((punto1.y3 - punto1.Y1), 2));

            if (resultado == resultado2 && resultado2 == resultado3 && resultado3 == resultado)
            {
                label5.Text = "Equilatero";

            }
            else if (resultado < resultado2 && resultado2 < resultado3 && resultado3 > resultado)
            {
                label5.Text = "Escaleno";

            }
            else
            {
                label5.Text = "Izoceles";
            
            }
            Area = resultado * resultado3 * 0.5;
            label6.Text = Area.ToString();
            perro = resultado + resultado2 + resultado3;
            label2.Text = perro.ToString();
         
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
