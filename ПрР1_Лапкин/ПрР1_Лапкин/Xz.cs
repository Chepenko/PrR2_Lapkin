using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрР1_Лапкин
{
    public class Xz
    {
        public Xz(int i, int j)
        {
            I = i;
            J = j;

            int n = i;
            int m = j;

            int result = 0;
            int[,] b = new int[n, m];

            for (int ii = 0; ii < n; ii++)
            {
                for (int jj = 0; jj < m; jj++)
                {
                    b[ii, jj] = Convert.ToInt32(Math.Sin((ii + jj) / 2));
                    if (b[ii, jj] > 0) result += 1;
                }
            }

            Solution(result);


            Console.WriteLine("Ответ: число положительных элементов = {0}", result);
            Console.ReadKey();

        }

        public int Solution(int result)
        {
            return result;

        }


        public int I { get; set; }
        public int J { get; set; }



    }
}

