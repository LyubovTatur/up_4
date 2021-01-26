using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllUp4
{
    /// <summary>
    /// Задание 6
    /// </summary>
    class Sixth
    {
        /// <summary>
        /// Входит ли в область точка
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool IsInArea(double x, double y, double r)
        {
            if 
                (
                    (
                        x>=0 
                        && 
                        y>=0 
                        && 
                        y > (x - 1) * (x - 1)
                        &&
                        Math.Sqrt(x*x+y*y)<=r
                    ) 
                    || 
                    (
                        x <= 0 
                        && 
                        y <= 0 
                        && 
                        Math.Sqrt(x * x + y * y) <= r
                    )
                )
            {
                return true;
            }
            return false;
        }
    }
}
