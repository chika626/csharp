using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        static void Main()
        {
            int[][] field = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i][j] == 1) Console.WriteLine("○");
                    else if (field[i][j] == 2) Console.WriteLine("×");
                    else if (field[i][j] == 0) Console.Write("{0}{1} ", i, j);
                }
                Console.WriteLine();
            }
        }
    }
}
