using System;

class Program
{
    public static void Main(string[] args)
    {
        int factor, sum, givenNum, i;

        for (i = 0; i < 4; i++)
        {
            Console.Write("Input the  number : ");
            givenNum = Convert.ToInt32(Console.ReadLine());
            sum = 0;


            for (factor = 1; factor < givenNum; factor++)
            {
                if (givenNum % factor == 0)
                {
                    sum = sum + factor;
                    
                }
            }

            if (sum == givenNum)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }

        }

    }
}