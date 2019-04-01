using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_c_sharp
{
    class Cylinder : Circle
    {
        
        private double h;

        public double H { get => h; set => h = value; }

        public Cylinder()
        {

        }

        public Cylinder(double h)
        {
            this.H = h;
        }

        public double GetVolume()
        {
            return Pi * Math.Pow(base.R, 2) * this.H;
        }

        new public double GetSquare()
        {
            return 2 * Pi * base.R * (base.R + this.H);
            
        }

        public double GetSquareOfSideSurface()
        {
            return 2 * Pi * base.R * this.H;
        }

        new public string ToString()
        {
            return  "\nРадиус:"  + this.R + 
                    "\nВысота:"  + this.H + 
                    "\nОбъем:"   + this.GetVolume() + 
                    "\nПлощадь боковой поверхности: " + this.GetSquareOfSideSurface() + 
                    "\nПлощадь полной поверхности: " + this.GetSquare();
        } 
    } 
}
