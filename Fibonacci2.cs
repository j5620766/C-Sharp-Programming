using System;

namespace Fibonacci2
{
    class Fibonacci2
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();

        public static long Get(int i)
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
            if (memo.ContainsKey(i))
            {
                return memo[i];
            }
            else
            {
                return memo[i] = Get(i - 2) + Get(i - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("몇 번째 수열을 출력할까요? : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci.Get(input));
        }
    }
}
