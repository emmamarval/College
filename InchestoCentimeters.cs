using System;

class Program {
  static void Main(string[] args)
  {
    double centimetersIninch = 2.54;
  

    
    Console.WriteLine("Enter inches to convert to centimeters");
    var firstInches = Console.ReadLine();
    int firstInchesint;
    if (int.TryParse(firstInches, out firstInchesint))
    {
        Console.WriteLine(firstInchesint + " inches is " + firstInchesint*centimetersIninch + " centimeters");
    }
  else
    { 
    Console.WriteLine("Invalid Input");
    }
//NEXT UNIT TEST

    var secondInches = Console.ReadLine();
    int secondInchesint;
    if (int.TryParse(secondInches, out secondInchesint))
    {
        Console.WriteLine(secondInchesint + " inches is " + secondInchesint*centimetersIninch + " centimeters");
    }
  else
    { 
    Console.WriteLine("Invalid Input");
    }

//NEXT UNIT TEST
    var thirdInches = Console.ReadLine();
    int thirdInchesint;
    if (int.TryParse(thirdInches, out thirdInchesint))
    {
        Console.WriteLine(thirdInchesint + " inches is " + thirdInchesint*centimetersIninch + " centimeters");
    }
  else
    { 
    Console.WriteLine("Invalid Input");
    }
    //NEXT UNIT TEST
    var fourthInches = Console.ReadLine();
    int fourthInchesint;
    if (int.TryParse(fourthInches, out fourthInchesint))
    {
        Console.WriteLine(fourthInchesint + " inches is " + fourthInchesint*centimetersIninch + " centimeters");
    }
  else
    { 
    Console.WriteLine("Invalid Input");
    } 
  }
}
