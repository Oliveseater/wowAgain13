using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b - ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 +\n2 -\n3 *\n4 /");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
<<<<<<< HEAD

=======
                case 1:
                    Console.WriteLine("Ответ: " + (a + b));
                    break;

                default: Console.WriteLine("wrong"); break;
>>>>>>> addit
            }
            Console.ReadKey();
        }
    }
}