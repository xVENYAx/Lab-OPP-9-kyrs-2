using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_ООП__9_курс_2
{
    class Test:Trail
    {
        private string time;
        private string data;

        public Test()
        {
            data = "0";
            time = "11:15";
        }

        public Test(string name, double number, string data, string time) : base(name, number)
        {
            this.Name = name;
            this.Number = number;
            this.Data = data;
            this.Time = time;
        }

        public string Time { get => time; set => time = value; }
        public string Data { get => data; set => data = value; }
        public new void Print()
        {

            base.Print();
            Console.WriteLine($"Data = {data}");
            Console.WriteLine($"Time = {time}");
        }
    }
}
