﻿using System;

class Fraction
{
    int numerator;
    int denominator;
    public Fraction(int num,int denom)
    {
        numerator = num;
        denominator = denom;
    }
    public void PrintFraction()
    {
        Console.WriteLine(numerator + "/" + denominator);
    }
}
namespace Chapter4-1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(1, 2);
            f.PrintFraction();

        }
    }
}
