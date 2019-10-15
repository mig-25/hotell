using System;
namespace Hotell
{
    public class Customer
    {
        public string Name;

        public Customer()
        {
        }

        public Customer(string name)
        {
            Name = name;
        }

        public void Bonus(LoyaltyCard points)
        {
            points.bonusPoints(this);
        }
    }
}
