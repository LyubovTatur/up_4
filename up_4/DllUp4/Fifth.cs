using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllUp4
{
    /// <summary>
    /// Задание 4
    /// </summary>
    public class Fifth
    {
        //  В результате конкатенации двух строк получается строка в которой идет все
        //  символы первой строки в обратном порядке, затем все символы второй строки в
        //  обратном порядке.Пример С1=’ABCD’, C2=’EFGHJK’,
        //  C1+C2=’DCBAKJHGFE’
        string str { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="s"></param>
        public Fifth(string s)
        {
            str = s;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        public void print()
        {
            Console.WriteLine(str);
        }
        /// <summary>
        /// Переоронделение оператора
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static Fifth operator +(Fifth s1, Fifth s2)
        {
            string temp = "";
            for (int i = s1.str.Length-1; i >=0 ; i--)
            {
                temp += s1.str[i];
            }
            for (int i = s2.str.Length-1; i >= 0; i--)
            {
                temp += s2.str[i];
            }

            return new Fifth(temp);
        }
    }
}

