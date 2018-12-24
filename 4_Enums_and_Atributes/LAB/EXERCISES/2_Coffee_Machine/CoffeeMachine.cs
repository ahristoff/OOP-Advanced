using _2_Coffee_Machine.Models;
using System;
using System.Collections.Generic;

namespace _2_Coffee_Machine
{
    public class CoffeeMachine
    {
        private int totalInsertedCoins;
        private IList<CoffeeType> coffeesSold;       
       
        public CoffeeMachine()
        {
            coffeesSold = new List<CoffeeType>();
            CoffeesSold = this.coffeesSold;
        }

        public IEnumerable<CoffeeType> CoffeesSold { get; }

        public void BuyCoffee(string size, string type)
        {
            CoffeeType coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
            CoffeePrice coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);

            if (totalInsertedCoins >= (int)coffeePrice)
            {
                coffeesSold.Add(coffeeType);
                totalInsertedCoins = 0;
            }
        }

        public void InsertCoin(string coin)
        {
            Coin insertedCoin = (Coin)Enum.Parse(typeof(Coin), coin);
            totalInsertedCoins += (int)insertedCoin;
        }
    }
}

