using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DllUp4
{/// <summary>
/// Класс для второго задания
/// </summary>
    class Second
    {
        int num;
        /// <summary>
        /// Конструктор задает число
        /// </summary>
        /// <param name="num"></param>
        public Second(int num)
        {
            this.num = num;
        }
        /// <summary>
        /// Конструктор задаеьтся случайное число
        /// </summary>
        public Second()
        {
            Random r = new Random(DateTime.Now.Second);
            this.num = r.Next(1, 10000);
        }
        /// <summary>
        /// Конструктор число считывается из файла
        /// </summary>
        /// <param name="path"></param>
        public Second(string path)
        {
            StreamReader sr = new StreamReader(path);
            try
            {
                num = int.Parse(sr.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Неверные данные в файле") ;
                num = 0;
            }
        }
        /// <summary>
        /// Выводит чило в консоль
        /// </summary>
        public void Show()
        {
            Console.WriteLine(num);
        }
        /// <summary>
        /// Индивидуальное задание
        /// </summary>
        /// <returns></returns>
        public int Task()
        {
            int max = 0, min= 9;
            if (num != 0)
            {
                int copyNum = num;
                while (copyNum!=0)
                {
                    if (copyNum%10<min)
                    {
                        min = copyNum % 10;
                    }
                    if (copyNum % 10 > max)
                    {
                        max = copyNum % 10;
                    }
                    copyNum /= 10;
                }
                return int.Parse(Math.Pow(max, min).ToString());
            }
            else return 0;
        }
    }
}
