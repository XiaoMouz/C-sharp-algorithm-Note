using System;

namespace xoh6Oh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LeetCode-cn.com / problems:剑指 Offer II 001. 整数除法
            Random random = new Random();
            int num_a = random.Next(-2147483647, 2147483647);
            int num_b = random.Next(-2147483647, 2147483647);
            Console.WriteLine("a={0},b={1}", num_a, num_b);
        }
        static int Divide(int a, int b)
        {
            if (a == b)
            {
                return 1;
            }
            else if (a == 0 || b == 0)
            {
                return 0;
            }

            return 2147483647;
        }
    }
}
