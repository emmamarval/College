using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] total = new int[5];
        total[0] = 0;
        string[] initial = new string[5];
        string[] name = new string[3];
        int e = 0;
        int d = 0;
        int f = 0;
        int aCounter = 0;

        while (initial[aCounter] != "z")
        {
            Console.WriteLine("Enter initial");
            initial[aCounter] = Console.ReadLine();
            if (initial[aCounter] == "e" || initial[aCounter] == "d" || initial[aCounter] == "f")
            {
                Console.WriteLine("Enter sale price");
                int sale = Convert.ToInt32(Console.ReadLine());
                if (initial[aCounter] == "e")
                {
                    name[1] = "Edward";
                    total[aCounter] = sale;
                    aCounter++;
                    e = sale;

                }

                if (initial[aCounter] == "d")
                {
                    name[0] = "Danielle";
                    total[aCounter] = sale;
                    aCounter++;
                    d = sale;
                }

                if (initial[aCounter] == "f")
                {
                    name[2] = "Francis";
                    total[aCounter] = sale;
                    aCounter++;
                    f = sale;

                }
                


            }
            else if (initial[aCounter] != "z")
            {
                Console.WriteLine("Invalid");
            }



        }
        Console.WriteLine("Grand Total: " + (total[0] + total[1] + total[2]+ total[3] + total[4]).ToString("c"));
        string highest = "";
       
        if (d > e && d > f)
        {
            highest = "D";
            
        }
        if (e > d && e > f)
        {
            highest = "D";
        }
        if (f > d && f > e)
        {
            highest = "F";

        }

        Console.WriteLine("Highest Sale: " + highest);
    }
}
