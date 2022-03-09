using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xndir1
{
    class Program
    {
        public static bool IsPalindrom(string word)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if(word[i] != word[word.Length -1 -i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrom("barbados"));
            int[,] nums = { { 1, 2, 6, 5 }, { 8, 7, 12, 13 }, { 9, 12, 10, 11 }, { 14, 3, 15, 4 }, { 20, 60, 40, 33 } };
            int columns = nums.GetUpperBound(0) + 1;
            int columLeng = nums.Length / columns;
            int[] result = new int[columns];
            for (int i = 0; i < columns; i++)
            {
                int max = nums[i, 0];
                for (int j = 1; j < columLeng; j++)
                {
                    if (max < nums[i, j])
                    {
                        max = nums[i, j];
                    }
                }
                result[i] = max;
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
