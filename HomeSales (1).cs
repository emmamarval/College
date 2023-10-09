using System;

class Program
{
    public static void Main(string[] args)
    {
          int total=0;
          int i;

                for (i=0; i<3; i++) 
                    {
                      Console.WriteLine("Enter initial");
                      string initial = Console.ReadLine();
                          if (initial.Equals("e") || initial.Equals("d") || initial.Equals("f"))
                            {
                              Console.WriteLine("Enter sale price");
                              int sale = Convert.ToInt32(Console.ReadLine());        
                              total = total + sale;
                              Console.WriteLine("Total is:", total + "sales that occured", sale);
                              
                           }
                              else if (initial.Equals("z"))
                              {
                                Console.WriteLine("wrote z");
                              }
                                  else 
                                  {
                                    Console.WriteLine("Invalid");
                                  }
                      
                
            
        }
    }
}