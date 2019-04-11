using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheff
{
    class Program
    {
        public static void Shifrator(string stroka)
        {
            foreach (var c in stroka)
            {
                int _с = c + 2;
                char res = Convert.ToChar(_с);
                Console.Write(res);
            }
        }

        public static void Deshifrator(string stroka)
        {
            foreach (var c in stroka)
            {
                int _с = c - 2;
                char res = Convert.ToChar(_с);
                Console.Write(res);
            }
        }

        static void Main(string[] args)
        {
            int a; string strok;
            Console.WriteLine("Если Вы хотите зашифровать строку, впишите 1. Если расширофвать - впишите 2");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Введите строку для зашифровки");
                strok = Console.ReadLine();
                Shifrator(strok);
            }
            else if (a == 2)
            {
                Console.WriteLine("Введите строку для дешифровки");
                strok = Console.ReadLine();
                Deshifrator(strok);
            }
            else Console.WriteLine("Ошибка!");
            Console.ReadKey();
        }

    }
}
