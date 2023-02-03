using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter the amount to covert");
      string converting = Console.ReadLine();
      Console.WriteLine("Enter the amount to capture");
      string capture = Console.ReadLine();
      
      double newConvert= Convert.ToDouble(converting);
      Console.WriteLine(converting + " coins equals to ...");

      int gold = 10;
      int silver = 5;

      double goldcoins = Math.Floor(newConvert/gold);
      double remaining = newConvert%gold;

      double silvercoins = Math.Floor(remaining%silver);

      Console.WriteLine("Gold coins: " + goldcoins);
Console.WriteLine("Silver coins: " + silvercoins);



    }
  }
}
