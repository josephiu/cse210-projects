using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction();
       Console.WriteLine(f1.GetfractionString());
       Console.WriteLine(f1.GetDecimalValue());
//needs to undersand more of this concept

       Fraction f2 = new Fraction(5);
       Console.WriteLine(f2.GetfractionString());
       Console.WriteLine(f2.GetDecimalValue());

       Fraction f3 = new Fraction(3, 4);
       Console.WriteLine(f3.GetfractionString());
       Console.WriteLine(f3.GetDecimalValue());

       Fraction f4 = new Fraction(1, 3);
       Console.WriteLine(f4.GetfractionString());
       Console.WriteLine(f4.GetDecimalValue());

    

    }
}