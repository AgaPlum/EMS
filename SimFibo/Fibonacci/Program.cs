using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console;

namespace Fibonacci
{
    /* F_n :=
 \begin{cases}
   0             & \mbox{dla } n = 0; \\
   1             & \mbox{dla } n = 1; \\
   F_{n-1}+F_{n-2} & \mbox{dla } n > 1. \\
  \end{cases}
*/
    class Program
    {
        static void Main(string[] args)
        {
         int [] tab=new int [100];
            tab[0] = 0;
            tab[1] = 1;
            for (int i = 2; i < tab.Length; i++)
            {
                tab[i] = tab[i - 1] + tab[i - 2]; 
            }
        }
    }
}
