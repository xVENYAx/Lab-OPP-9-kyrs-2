using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_ООП__9_курс_2
{
    class Exam:Trail
    {
        private string time;
        private string data;
        public Exam()
        {
            data = "0";
            time = "11:15";
        }
        private double audience;
        public Exam(string name, double number, string data, string time, double audience) : base(name, number)
        {
            this.Name = name;
            this.Number = number;
            this.Data = data;
            this.Time = time;
            this.Audience = audience;
        }

        public double Audience { get => audience; set => audience = value; }
        public string Time { get => time; set => time = value; }
        public string Data { get => data; set => data = value; }
        public new void Print()
        {

            base.Print();
            Console.WriteLine($"Data = {data}");
            Console.WriteLine($"Time = {time}");
            Console.WriteLine($"Audience = {audience}");
        }

    }
}
