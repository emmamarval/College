using System;

class Program {
  public static void Main (string[] args) {
    int counter = 4;

    while (counter > 0)
       {
         Console.WriteLine("");
         Console.WriteLine("Enter wind speed in mph");
         var windSpeed = Console.ReadLine();
         double windSpeedint;
         if (double.TryParse(windSpeed, out windSpeedint))
          {
              if (windSpeedint >= 157)
            {
              Console.WriteLine("Category Five Hurricane");
             }
            else if (windSpeedint < 157 && windSpeedint > 130)
                {
                  Console.WriteLine("Category Four Hurricane");
                  }
            else if (windSpeedint < 130 && windSpeedint > 111)
                    {
                      Console.WriteLine("Category Three Hurricane");
                      }
                      else
                        {
                          Console.WriteLine("Category One Hurricane");
                          }
                counter = counter - 1;
           }
               else
               {
                 Console.WriteLine("Invalid Input");
               }
      }
    }
}