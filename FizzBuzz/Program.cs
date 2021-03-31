using System;

namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      // allow the user to give us upperBound, lowerBound (think validate)
      // allow the user to set condition for multiple 7, 11
      // count from 0 to 100, and print eaach number per line
      // if number is multiple of 3, print fizz
      // if number is multiple of 5, print buzz
      // if number is multiple of both, print fizzbuzz
      Dailogue();
      RunFizzBuzz(0, 100);
    }
    private static void RunFizzBuzz(int start, int end, int inc = 1)
    {
      for (var x = start; x <= end; x += inc)
      {
        PrintNumber(x);
      }
    }
    private static void PrintNumber(int a, int div1 = 3, int div2 = 5)
    {
      if (a == 0)
      {
        WriteToConsole(a);
      }
      else if (a % (div1 * div2) == 0)
      {
        WriteToConsole($"fizzbuzz {a}");
      }
      else if (a % div1 == 0)
      {
        WriteToConsole($"fizz {a}");
      }
      else if (a % div2 == 0)
      {
        WriteToConsole($"buzz {a}");
      }
      else
      {
        WriteToConsole(a);
      }

    }
    private static void WriteToConsole(Object content)
    {
      Console.WriteLine(content);
    }

    private static Boolean Validator(int a)
    {
      if (a is int) return true;
      else throw new ArgumentException("Wrong");
    }

    private static void Dailogue()
    {
      Console.WriteLine("Enter lowerbound value");
      if (Validator(
          Console.ReadLine())) var lb = Console.ReadLine();

    }
  }
}
