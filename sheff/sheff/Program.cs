using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheff
{
    public class Program
    {
        public static string Shifrator(string stroka)
        {
            string output = "";
            foreach (var c in stroka)
            {
                int _с = c + 2;
                output += Convert.ToChar(_с);                
            }
            return output;
        }

        public static string Deshifrator(string stroka)
        {
            string output = "";
            foreach (var c in stroka)
            {
                int _с = c - 2;
                output += Convert.ToChar(_с);
            }
            return output;
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
                Console.WriteLine(Shifrator(strok));
            }
            else if (a == 2)
            {
                Console.WriteLine("Введите строку для дешифровки");
                strok = Console.ReadLine();
                Console.WriteLine(Deshifrator(strok));
            }
            else Console.WriteLine("Ошибка!");
            Console.ReadKey();
        }

    }
}
