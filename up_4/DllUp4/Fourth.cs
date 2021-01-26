using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DllUp4
{
    /// <summary>
    /// Задание 4
    /// </summary>
    public class Fourth
    {
        List<List<int>> matrix = new List<List<int>>();
        /// <summary>
        /// Вывод элементов
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Конструктор случайные числа
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public Fourth(int n, int m)
        {
            Random rnd = new Random(DateTime.Now.Second);
            for (int i = 0; i < n; i++)
            {
                List<int> temp = new List<int>();
                for (int j = 0; j < m; j++)
                {
                    temp.Add(rnd.Next(0, 15));
                }
                matrix.Add(temp);
            }
        }
        /// <summary>
        /// Конструктор из файла
        /// </summary>
        /// <param name="filename"></param>
        public Fourth(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] els = line.Split(' ');
                    List<int> temp = new List<int>();
                    for (int i = 0; i < els.Length; i++)
                    {
                        temp.Add(int.Parse(els[i]));
                    }
                    matrix.Add(temp);
                }
            }
        }
        /// <summary>
        /// Количество  делителей у числа
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int DelCount(int n)
        {

            int count = 1;
            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {

                        count++;
                    }
                }
            }   
            

            return count;
        }
        /// <summary>
        /// Количество чисел с колвом делителей равным 3 в последнем столбце
        /// </summary>
        /// <returns></returns>
        private int NumCount()
        {
            int count = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                if (DelCount(matrix[i][matrix[0].Count-1]) == 3)
                {
                    count++;
                }
            }
            return count;
        }
          
            /// <summary>
            /// Большей считается та матрица, в которой число чисел, имеющих ровно 3 делителя в последнем столбце больше.
            /// </summary>
            /// <param name="a1"></param>
            /// <param name="a2"></param>
            /// <returns></returns>
        public static bool operator >=(Fourth a1, Fourth a2)
        {
            return a1.NumCount() >= a2.NumCount();
        }
        /// <summary>
        /// Большей считается та матрица, в которой число чисел, имеющих ровно 3 делителя в последнем столбце больше.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator <=(Fourth a1, Fourth a2)
        {
            return a1.NumCount() <= a2.NumCount();
        }
    }
}
