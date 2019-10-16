using System;
namespace Hotell
{
    public class LoyaltyCard
    {
        int points = 100;

        public LoyaltyCard()
        {
        }

        public void bonusPoints(int points)
        {
            Customer customer = new Customer();
            points += 10;
            Console.WriteLine($"Your loyalty points are: {points}");

        }
    }
}
