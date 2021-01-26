using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DllUp4
{
    /// <summary>
    /// Класс для первого задания
    /// </summary>
    public class First
    {
        int num1;
        int num2;
        private Random random = new Random(DateTime.Now.Second);
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public First(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="limit">Числа задаются случайно в заданном пределе</param>
        public First(int limit)
        {
            num1 = random.Next(1, limit);
            num2 = random.Next(1, limit);
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="path">Числа считываются из файла с заданным именем</param>
        public First(string path)
        {
            StreamReader sr = new StreamReader(path);
            try
            {
                num1 = int.Parse(sr.ReadLine());
                num1 = int.Parse(sr.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Неверные данные в файле.");
                num1 = num2 = 0;
            }
            sr.Close();
        }
        /// <summary>
        /// Возвращает разность чисел
        /// </summary>
        /// <returns></returns>
        public int Difference()
        {
            return num1 / num2;
        }
    }
}
