Причина редактировани, залил .cs


/*3. Создать класс окружность, член класса – R. Предусмотреть в классе методы вычисления и вывода
сведений о фигуре – площади, длины окружности.Создать производный класс – круглый прямой
цилиндр с высотой h, добавить в класс метод определения объема фигуры, перегрузить методы
расчета площади и вывода сведений о фигуре.Написать программу, демонстрирующую работу с
классом: дано N окружностей и M цилиндров, найти окружность максимальной площади и средний
объем цилиндров.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Circle
    {
        private const double pi = 3.14;
        private double r;

        public static double Pi => pi;

        public double R { get => r; set => r = value; }

        public Circle()
        {

        }

        public Circle(double r)
        {
            //переменная используемая в поле класса
            this.R = r;
        }

        public double GetSquare()//площадь
        {
          return  Pi * Math.Pow(this.R, 2);
        }

        public double GetL()//длина
        {
            return  2 * Pi * this.R;
        }

        public override string ToString()//вывод информации
        {
            return  "\nРадиус:" + this.R + 
                    "\nДлина:"   + this.GetL() + 
                    "\nПлощадь:" + this.GetSquare()  ;
        }

    }
}
