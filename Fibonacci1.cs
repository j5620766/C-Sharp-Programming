using System;

namespace Fibonacci1
{
    class Fibonacci1
    {
        static void Main(string[] args)
        {
            Console.Write("�� ��° ������ ����ұ��? : ");
            int input = int.Parse(Console.ReadLine());
            long zero = 0;
            long one = 1;
            long sum = 0;

            for (int i = 1; i < input; i++)
            {
                sum = zero + one;
                zero = one;
                one = sum;
            }
            if (input == 1)
            {
                sum = 1;
            }
            Console.WriteLine(input + "��° ���� : " + sum);
        }
    }
}
