using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grafica1
{
    public class puntos
    {
        private int x1;

        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        private int x2;

        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        private int y1;

        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        private int y2;

        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        private int resul;

        public int Resul
        {
            get { return resul; }
            set { resul = value; }
        }

        public void asignar()
        {
            Console.WriteLine("Linea 1");
            Console.WriteLine("x1 :");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1 :");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2 :");
            y2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Linea 2");
            Console.WriteLine("x3 :");            
            X3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y3:");
            Y3 = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
        }

        private int X3;

        public int x3
        {
            get { return X3; }
            set { X3 = value; }
        }

        private int X4;

        public int x4
        {
            get { return X4; }
            set { X4 = value; }
        }
        private int X5;

        public int x5
        {
            get { return X5; }
            set { X5 = value; }
        }
        private int X6;

        public int x6
        {
            get { return X6; }
            set { X6 = value; }
        }

        private int Y3;

        public int y3
        {
            get { return Y3; }
            set { Y3 = value; }
        }
        private int Y4;

        public int y4
        {
            get { return Y4; }
            set { Y4 = value; }
        }
        private int Y5;

        public int y5
        {
            get { return Y5; }
            set { Y5 = value; }
        }

        private int Y6;

        public int y6
        {
            get { return Y6; }
            set { Y6 = value; }
        }


    }
}
