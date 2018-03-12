using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __1
{
    class rivers   //базовый класс
    {
        private string name;
        private double area;
        private double length;
        public string Name { get; set; }
        public double Area { get; set; }
        public double Length { get; set; }
        public rivers()
        {
            Name = null;
            Area = 0;
            Length = 0;
        }
        public rivers(string name, double area, double length)
        {
            Name = name;
            Area = area;
            Length = length;
        }
        public virtual void Display()
        {
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Площадь: " + Area);
            Console.WriteLine("Длинна: " + Length);
        }
        public virtual void Input()
        {
            Console.WriteLine("Название: ");
            Name = Console.ReadLine();
            Console.WriteLine("Площадь: ");
            Area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длинна: ");
            Length = Convert.ToInt32(Console.ReadLine());
        }

    }
}
