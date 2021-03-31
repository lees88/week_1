using System;

namespace Revature.Week1.HellowWorld
{
  class Program
  {
    private static void Main()
    {
      Console.WriteLine("Enter your name");
      //stdin to get name
      var input = Console.ReadLine(); //datatype inference
      //stdout to print name
      Console.WriteLine($"Hello my name is {input}"); //string interpolation, template string
    }
    private void UiPath()
    {
    }
  }
}