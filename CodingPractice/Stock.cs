using System;

class PriceChangedEventArgs : EventArgs
{
    public decimal OldPrice { get; }
    public decimal NewPrice { get; }
    public decimal ChangePercent { get; }

    public PriceChangedEventArgs(decimal oldPrice, decimal newPrice)
    {
        OldPrice = oldPrice;
        NewPrice = newPrice;
        
        if (oldPrice != 0)
        {
            ChangePercent = (newPrice - oldPrice) / oldPrice * 100;
        }
    }
}

class Stock
{
    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    private string _symbol;
    private decimal _price;

    public Stock(string symbol, decimal price)
    {
        _symbol = symbol;
        _price = price;
    }

    public decimal Price
    {
        get => _price;

        set
        {
            if (_price == value)
            {
                return;
            }

            decimal oldPrice = _price;
            _price = value;

            OnPriceChanged(new PriceChangedEventArgs(oldPrice, _price));
        }
    }

    public virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public override string ToString()
    {
        return $"[{_symbol}: {_price:C}]";
    }
}