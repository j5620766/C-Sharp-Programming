using System;

namespace LookandSay
{
    class LookandSay
    {
        static void Main(string[] args)
        {
            Console.Write("�� ��° ������ ����ұ��? : ");
            int input = int.Parse(Console.ReadLine());
            string result = "1";

            for (int i = 1; i < input; i++)
            {
                char token = result[0];
                int count = 0;
                string number = "";

                for (int j = 0; j < result.Length; j++)
                {
                    if (token == result[j])
                        count++;
                    else
                    {
                        number += "" + token + count;
                        count = 1;
                        token = result[j];
                    }
                    if (j + 1 == result.Length)
                        number += "" + token + count;
                }
                result = number;
            }
            Console.WriteLine(input + "��° ���� : " + result);
        }
    }
}
