using System;

class FuelEventArgs : EventArgs
{
    public int FuelLevel { get; }
    public string Warning { get; }

    public FuelEventArgs(int level, string warning)
    {
        FuelLevel = level;
        Warning = warning;
    }
}

class Car
{
    private int _fuelLevel;

    public event EventHandler<FuelEventArgs> FuelLow;
    public event Action<int> FuelChanged;

    public Car(int fuel)
    {
        _fuelLevel = fuel;
    }

    public int FuelLevel => _fuelLevel;

    protected virtual void OnFuelLow(FuelEventArgs e)
    {
        FuelLow?.Invoke(this, e);
    }

    public void Drive()
    {
        if (_fuelLevel <= 0)
        {
            Console.WriteLine("연료 없음! 운전 불가");
            return;
        }

        _fuelLevel -= 10;
        Console.WriteLine($"운전 중... 연료: {_fuelLevel}%");
        FuelChanged?.Invoke(_fuelLevel);

        if (_fuelLevel <= 0)
        {
            OnFuelLow(new FuelEventArgs(_fuelLevel, "연료가 바닥났습니다!"));
        }
        else if (_fuelLevel <= 20)
        {
            OnFuelLow(new FuelEventArgs(_fuelLevel, "연료가 부족합니다"));
        }
    }
}

class Dashboard
{
    public void OnFuelChanged(int fuelLevel)
    {
        string gauge = new string('█', fuelLevel / 10);
        Console.WriteLine($"[대시보드] 연료 게이지: {gauge}");
    }

    public void OnFuelLow(object sender, FuelEventArgs e)
    {
        Console.WriteLine($"[경고!] {e.Warning} (잔량: {e.FuelLevel}%)");
    }

    public void Subscrbe(Car car)
    {
        car.FuelChanged += OnFuelChanged;
        car.FuelLow += OnFuelLow;
    }

    public void Unsubscrbe(Car car)
    {
        car.FuelChanged -= OnFuelChanged;
        car.FuelLow -= OnFuelLow;
    }
}