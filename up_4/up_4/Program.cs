using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllUp4;

namespace up_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            First first = new First(30,13);
            Console.WriteLine(first.Difference());

            Console.WriteLine("Задание 2");
            Second second = new Second();
            second.Show();
            Console.WriteLine(second.Task());

            Console.WriteLine("Задание 3");
            Third third1 = new Third(6);
            Third third2 = new Third(8);
            third1.Show();
            third2.Show();
            Console.WriteLine(third1*third2);

            Console.WriteLine("Задание 4");
            Fourth fourth1 = new Fourth(3, 4);
            Fourth fourth2 = new Fourth(3, 4);
            fourth1.Print();
            fourth2.Print();
            if (fourth1>=fourth2)
            {
                Console.WriteLine("Первая больше или равна");
            }
            if (fourth1<=fourth2)
            {
                Console.WriteLine("Вторая больше или равна");

            }

            Console.WriteLine("Задание 5");
            Fifth fifth1 = new Fifth("qwer");
            Fifth fifth2 = new Fifth("zxc");
            (fifth1 + fifth2).print();

            Console.WriteLine("Задание 6");
            if (Sixth.IsInArea(5,3,4))
            {
                Console.WriteLine("подходит");
            }
            else
                Console.WriteLine("не подходит");

            Console.ReadLine();
        }
    }
}
