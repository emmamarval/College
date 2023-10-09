using System;

class Program
{
    public static void Main(string[] args)
    {
        string initial = "";
        int total=0;
        int e = 0;
        int d = 0;
        int f = 0;

        while (initial != "z")
            {
              Console.WriteLine("Enter initial");
              initial = Console.ReadLine();
                  if (initial == "e" || initial == "d" || initial =="f")
                    {
                      Console.WriteLine("Enter sale price");
                      int sale = Convert.ToInt32(Console.ReadLine()); 
                      if(initial == "e")
                      {
                        e = sale;
                      }

                      if(initial == "d")
                      {
                        d = sale;
                      }

                      if(initial == "f")
                      {
                        f = sale;
                      }
                      total = total + sale;
                      
                      
                    }                     
                    else if (initial != "z")
                          {
                            Console.WriteLine("Invalid");
                          }
              
        
    
        }
      Console.WriteLine("Grand Total: " + total.ToString("c"));
      string highest = "";
      if (d>e && d>f)
      {
        highest = "D";
      }
      if (e>d && e>f)
      {
        highest = "E";
      }
      if(f>d && f>e)
      {
        highest = "F";
      }
      
      Console.WriteLine("Highest Sale: " + highest);
    }
}