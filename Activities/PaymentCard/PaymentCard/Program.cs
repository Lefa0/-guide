using System;

namespace PaymentCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(100);
            Console.WriteLine(card.ToString());

            //card.EatLunch();
            card.AddMoney(49.99);
            Console.WriteLine(card);

            //card.DrinkCoffee();
            card.AddMoney(1000.0);
            Console.WriteLine(card);

            card.AddMoney(-10);
            Console.WriteLine(card);
        }
    }
}
