using System;

class Program
{
    public static void Main(string[] args)
    {
        string feedback = "";
        int[] temps = new int[5];
        int input = 0;

 
            Console.WriteLine("Please enter 5 temperatures");

            for (int i = 0; i < temps.Length;)
            {
                input = Convert.ToInt32(Console.ReadLine());

                if (input > -30 && input < 130)
                {
                    temps[i] = input;
                    i++;
                }
                else
                {
                    Console.WriteLine("Temperature " + input + " is invalid, Please enter a valid temperature between -30  and 130");
                }
            }
        

        if (temps[0] < temps[1] && temps[1] < temps[2] && temps[2] < temps[3] && temps[3] < temps[4])
        {
            feedback = "Getting warmer";

        }
        else if (temps[0] > temps[1] && temps[1] > temps[2] && temps[2] > temps[3] && temps[3] > temps[4])
        {
            feedback = "Getting cooler";
        }
        else
        {
            feedback = "It's a mixed bag";

        }
        double averageTemp = (Convert.ToDouble(temps[0]) + Convert.ToDouble(temps[1]) + Convert.ToDouble(temps[2]) + Convert.ToDouble(temps[3]) + Convert.ToDouble(temps[4])) / 5;
        Console.WriteLine(feedback);
        Console.WriteLine("5-day Temperature [" + temps[0] + "," + temps[1] + "," + temps[2] + "," + temps[3] + "," + temps[4] + "]");
        Console.WriteLine("Average Temperature is " + averageTemp + " degrees");

    }
}