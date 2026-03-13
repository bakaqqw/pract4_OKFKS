using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace pract4_OKFKS
{
    public class Triangle : Shape
    {
        private double sideA = 0.0;

        public double SideA
        {
            get => sideA;
            set
            {
                if (sideA != value)
                {
                    sideA = value;
                }
            }
        }

        private double sideB = 0.0;

        public double SideB
        {
            get => sideB;
            set
            {
                if (sideB != value)
                {
                    sideB = value;
                }
            }
        }

        private double sideC = 0.0;

        public double SideC
        {
            get => sideC;
            set
            {
                if (sideC != value)
                {
                    sideC = value;
                }
            }
        }

        public override double Area()
        {
            if (SideA < 1 || SideB < 1 || SideC < 1)
            {
                throw new ArgumentException("Недопустимые числа, попробуй другие!");
            }
            double p = (SideA * SideB * SideC);
            double s = Math.Sqrt(p * (p - sideA) * (p - SideB) * (SideC));
            return checked(s);
        }

        public override double Perimeter()
        {
            if (SideA < 1 || SideB < 1 || SideC < 1)
            {
                throw new ArgumentException("Недопустимые числа, попробуй другие!");
            }
            return checked(SideA + SideB + SideC);
        }

        public override string ToString()
        {
            return $"Информация о треугольнике: \nСторона 1: {SideA} \nСторона 2: {SideB} \nСторона 3: {SideC}";
        }

    }
}
