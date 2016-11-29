using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafica1
{
    class Dista
    {
        public Double resultado;

        public Double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
        public void funcion()
        {
            puntos punto1 = new puntos();
           resultado =   Math.Sqrt(Math.Pow((punto1.X2 - punto1.X2), 2) + Math.Pow((punto1.Y2 - punto1.Y1), 2));
           Console.WriteLine("Total es : " + resultado);
           Console.ReadLine();
        }
    }
}
