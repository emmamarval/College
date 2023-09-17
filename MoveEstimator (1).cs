using System;

class Program {
  public static void Main (string[] args) {
    int basePay = 200;
    int hourly = 150;
    int perMile = 2;
    Console.WriteLine("Enter number of hours");
    var hoursGiven = Console.ReadLine();
    
    Console.WriteLine ("Enter number of miles");
    var milesGiven = Console.ReadLine();
    
    int milesGivenint;
    double hoursGivenint;

     if (double.TryParse(hoursGiven, out hoursGivenint) && int.TryParse(milesGiven, out milesGivenint))
    {
    Console.WriteLine ("Your total is $ {0}", basePay+(milesGivenint*perMile)+(hoursGivenint*hourly));
    }
    else
      {
      Console.WriteLine("Invalid Input");
      }

    //NEXT UNIT TEST

    Console.WriteLine("Enter number of hours");
    hoursGiven= Console.ReadLine();
    
    Console.WriteLine ("Enter number of miles");
    milesGiven = Console.ReadLine();
    
    int milesGivenintTwo;
    double hoursGivenintTwo;

     if (double.TryParse(hoursGiven, out hoursGivenintTwo) && int.TryParse(milesGiven, out milesGivenintTwo))
    {
    Console.WriteLine ("Your total is $ {0}", basePay+(milesGivenintTwo*perMile)+(hoursGivenintTwo*hourly));
    }
    else
      {
      Console.WriteLine("Invalid Input");
      }

    //NEXT UNIT TEST

    Console.WriteLine("Enter number of hours");
    hoursGiven= Console.ReadLine();
    
    Console.WriteLine ("Enter number of miles");
    milesGiven = Console.ReadLine();
    
    int milesGivenintThree;
    double hoursGivenintThree;

     if (double.TryParse(hoursGiven, out hoursGivenintThree) && int.TryParse(milesGiven, out milesGivenintThree))
    {
    Console.WriteLine ("Your total is $ {0}", basePay+(milesGivenintThree*perMile)+(hoursGivenintThree*hourly));
    }
    else
      {
      Console.WriteLine("Invalid Input");
      }

    //NEXT UNIT TEST

    Console.WriteLine("Enter number of hours");
    hoursGiven= Console.ReadLine();
    
    Console.WriteLine ("Enter number of miles");
    milesGiven = Console.ReadLine();
    
    int milesGivenintFour;
    double hoursGivenintFour;

     if (double.TryParse(hoursGiven, out hoursGivenintFour) && int.TryParse(milesGiven, out milesGivenintFour))
    {
    Console.WriteLine ("Your total is $ {0}", basePay+(milesGivenintFour*perMile)+(hoursGivenintFour*hourly));
    }
    else
      {
      Console.WriteLine("Invalid Input");
      }
  }
}