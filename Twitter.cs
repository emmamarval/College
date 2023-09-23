using System;

class Program {
  public static void Main (string[] args) {
    int counter = 4;

    while (counter > 0)
       {
         Console.WriteLine("");
         Console.WriteLine("Enter your tweet!");
         var tweetGiven = Console.ReadLine();
        string output = (tweetGiven.Length <= 140) ? "Posted" : "Rejected";
         Console.WriteLine(output);
         counter = counter - 1;
      }
    }
}