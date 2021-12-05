using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_ООП__9_курс_2
{
    class Trail
    {
        private string name;
        private double number;

        public Trail()
        {
            name = "Вид";
            number = 0;
        }
        public Trail(string name, double number)
        {
            this.name = name;
            this.number = number;
        }
        public string Name { get => name; set => name = value; }
        public double Number { get => number; set => number = value; }

        public void Print()
        {
            Console.WriteLine("Значение полей");
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Number = {number}");

        }

    }
}
