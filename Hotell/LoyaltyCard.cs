using System;
namespace Hotell
{
    public class LoyaltyCard
    {
        int points = 100;

        public LoyaltyCard()
        {
        }

        public void bonusPoints(Customer customer)
        {
            points += 10;
            Console.WriteLine($"Your loyalty pooints are: {points}");

        }
    }
}
