//nowcoder.com NC245375
/** 
    There are two non-negative integers x, y. For each operation, you can select a number to −1 and then another number will +1. During the operation, you should ensure that x, y are non-negative. After some (possibly zero) operations, we can easily work out the maximum value of x2 + y2 by the adjustment method we learned in middle school.
    Now, you have a new operation: you are given three non-negative integers x, y, z. For each operation, you can select two numbers to −1 and then another number will +2. During the operation, you should also ensure that x, y, z are non-negative. After some (possibly zero) operations, what is the maximum value of x2 + y2 + z2 ?
**/

class Program
{
    static void Main(string[] args)
    {
        int C = int.Parse(System.Console.ReadLine());
        while (C > 0)
        {
            string[] ss = System.Console.ReadLine().Split(" ");

            int[] ints = new int[ss.Length];

            for (int i = 0; i < ss.Length; i++)
            {
                ints[i] = int.Parse(ss[i]);
            }
            long r = Com(ints);
            System.Console.WriteLine(r);

            C--;
        }
        return;
    }
    static long Com(int[] x)
    {
        long result = x[0] + x[1] + x[2];

        int a = System.Math.Abs(x[2] - x[1]);
        int b = System.Math.Abs(x[0] - x[2]);
        int c = System.Math.Abs(x[0] - x[1]);

        int t = 0;
        if (a % 3 == 0 || b % 3 == 0 || c % 3 == 0) ;
        else
        {
            result--;
            t = 1;
        }

        return result * result + t;
    }
}