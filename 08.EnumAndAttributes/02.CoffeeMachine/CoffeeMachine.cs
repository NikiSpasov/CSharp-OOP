
using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private CoffeePrice coffeePrice;
    private CoffeeType coffeeType;
    public static int CoinsPushed = 0;
    private Coin coinInserted;

    public CoffeeMachine()
    {
        this.CoffeesSold = new List<CoffeeType>();
    }

    public void BuyCoffee(string size, string type)
    {
        if (Enum.TryParse(size, out coffeePrice) && Enum.TryParse(type, out coffeeType))
        {
            if (CoinsPushed >= (int)coffeePrice)
            {
                CoffeesSold.Add(this.coffeeType);
                CoinsPushed = 0;
            }
        }    
    }

    public void InsertCoin(string coin)
    {
        if (Enum.TryParse(coin, out coinInserted))
        {
            CoinsPushed += (int)coinInserted;
        }
        
    }

	public List<CoffeeType> CoffeesSold { get; }

}

