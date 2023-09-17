using System;

class Program {
  static void Main(string[] args)
  {
    var Inches = 5;
    double centimetersIninch = 2.54;
        Console.WriteLine(Inches + " inches is " + Inches*centimetersIninch + " centimeters");
    
//NEXT UNIT TEST
    Inches = 5;

        Console.WriteLine(Inches + " inches is " + Inches*centimetersIninch + " centimeters");
    
//NEXT UNIT TEST

Inches = -15;
    
        Console.WriteLine(Inches + " inches is " + Inches*centimetersIninch + " centimeters");
    
//NEXT UNIT TEST

Inches = 15994;
    
        Console.WriteLine(Inches + " inches is " + Inches*centimetersIninch + " centimeters");
    }
}