using System;
public class MyFirstProgram()
{
    //Method Overloading, methods share same name but different parameters.
    //Each Method should have Unique Signature, 
    //Name + parameter = Signature
    public static void Main()
    {
        double num1, num2, num3;
        num1 = 10;
        num2 = 3.14;
        num3 = 0.01;
        Console.WriteLine(Multiply(num1, num2, num3));
    }
    static double Multiply(double x, double y) { 
        return x + y;
    }

    static double Multiply(double x, double y, double z)
    {
        return x + y + z;
    }
}