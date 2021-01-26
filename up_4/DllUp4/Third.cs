using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DllUp4
{/// <summary>
/// Задание 3
/// </summary>
    class Third
    {
        List<int> elems = new List<int>();
        static Random random = new Random(DateTime.Now.Second);
        /// <summary>
        /// Конструктор со списком
        /// </summary>
        /// <param name="elems"></param>
        public Third(List<int> elems)
        {
            this.elems = elems;
        }
        /// <summary>
        /// Конструктор со случайными числами
        /// </summary>
        /// <param name="count"></param>
        public Third(int count)
        {

            for (int i = 0; i < count; i++)
            {
                elems.Add(random.Next(1, 24));
            }
        }
        /// <summary>
        /// Конструктор считывает из файла
        /// </summary>
        /// <param name="path"></param>
        public Third(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    elems.Add(int.Parse(line));
                }
            }
        }
        /// <summary>
        /// Вывод списка
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < elems.Count; i++)
            {
                Console.Write(elems[i]+" ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Скалярное произведение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int operator *(Third a, Third b)
        {
            int result = 0;
            for (int i = 0; i < Math.Min(a.elems.Count,b.elems.Count); i++)
            {
                result += a.elems[i] * b.elems[i];
            }
            return result;
        }
    }
}
//  Создать класс вектор с полями: элементы вектора и методами:
//  создание объекта, вывод объекта.Реализовать перегрузку операции скалярного
//  произведения для векторов и перегрузку метода создания объекта для двух
//  параметров(целое число — инициализация размерности, элементы вектора случайны в
//  пределах от 1 до 23, строковая переменная – имя файла, из которого происходит чтение
//  вектора).