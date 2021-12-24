using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_ООП__9_курс_2
{
    class Test:Trail
    {
        public string rating;
        public Test(string name, double number, string rating) : base(name, number)
        {
            this.Name = name;
            this.Number = number;
            this.Rating = rating;
        }
        public string Rating { get => rating; set => rating = value; }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Rating = {rating}");
        }
    }
}
