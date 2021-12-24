using System;

namespace Лаб_ООП__9_курс_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Trail p1 = new Trail("Випробування", 3);
            Console.WriteLine("Класс Trial");
            p1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Test");
            Test b1 = new Test("Тест", 2, "95/100");
            b1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Exam");
            Exam mb1 = new Exam("Іспит", 3, "10/10/20", "12:30", 415);
            mb1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Final_exam");
            Final_exam s1 = new Final_exam("Випускний іспит", 1, "15/10/20", "15:30", 415, "Molotkov O. K.", "Yes", "Yes");
            s1.Print();
            Console.WriteLine("--------------");
        }
    }
}