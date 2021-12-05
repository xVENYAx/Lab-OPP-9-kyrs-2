using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_ООП__9_курс_2
{
    class Exam:Test
    {
        private double audience;
        public Exam(string name, double number, string data, string time, double audience) : base(name, number, data, time)
        {
            this.Name = name;
            this.Number = number;
            this.Data = data;
            this.Time = time;
            this.Audience = audience;
        }

        public double Audience { get => audience; set => audience = value; }
        public new void Print()
        {

            base.Print();
            Console.WriteLine($"Audience = {audience}");
        }

    }
}
