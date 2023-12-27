using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BakhtiyarovDR.Sprint6.TaskReview.V5.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            if (n1 >= n2 || k >= l || k < 0 || l >= array.GetLength(0) || c < 0 || c >= array.GetLength(1) || n1 >= n2 || k >= l)
            {
                throw new ArgumentException("Некорректные значения ввода.");
            }

            int count = 0;

            for (int i = k; i <= l; i++)
            {
                if (array[i, c] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
