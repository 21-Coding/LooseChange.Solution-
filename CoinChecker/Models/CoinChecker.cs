using System.Collections.Generic;



namespace CoinChecker.Models
{
  public class CoinPurse
  {
    public static List<int> Coins = new List<int>(4) { 500, 100, 25, 10, 5, 1 };
    public static List<int> MakeChange(int monies)
    {
      List<int> results = new List<int>(1);
      int index = 0;
      int newMonies = monies;

      while (newMonies > 0)
      {
        if (newMonies >= Coins[index])
        {
          newMonies -= Coins[index];
          results.Add(Coins[index]);
        }
        else if (newMonies <= Coins[index])
        {
          index++;
        }
        else
        {
          break;
        }
      }
      return results;
    }


  }
  //array of denom
  //taking input number
  //while loop to check if current number is equal to any denom
  //return total denom array
}