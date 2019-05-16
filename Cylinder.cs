Причина редактировани, залил .cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
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

        public double GetVolume()//объём цилиндра
        {
            return Pi * Math.Pow(base.R, 2) * this.H;
        }

        new public double GetSquare()//полная площадь
        {
            return 2 * Pi * base.R * (base.R + this.H);
            
        }

        public double GetSquareOfSideSurface()//площадь боковой поверхности
        {
            return 2 * Pi * base.R * this.H;
        }

        new public string ToString()
        {
            return  "\nРадиус:"  + this.R  +
                    "\nВысота:"  + this.H  +
                    "\nОбъем:"   + this.GetVolume()  +
                    "\nПлощадь боковой поверхности: " + this.GetSquareOfSideSurface()  +
                    "\nПлощадь полной поверхности: " + this.GetSquare();
        } 
    } 
}
