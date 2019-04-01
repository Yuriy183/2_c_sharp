using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_c_sharp
{
    class Circle
    {
        private const double pi = 3.14;
        private double r;
        
        
        public Circle()
        {

        }

        public Circle(double r)
        {
            this.R = r;
        }

        public double GetSquare()
        {
          return  Pi * Math.Pow(this.R, 2);
        }

        public double GetL()
        {
            return  2 * Pi * this.R;
        }

        override public string ToString()
        {
            return  "\nРадиус: "  + this.R + 
                    "\nДлина: "   + this.GetL() + 
                    "\nПлощадь: " + this.GetSquare()  ;
        }



        public double R { get => R1; set => R1 = value >= 0 ? value : 0; }

        public static double Pi => pi;

        public double R1 { get => r; set => r = value; }
    }
}
