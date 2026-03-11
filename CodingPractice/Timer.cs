using System;

class Timer
{
    public event Action Tick;
    private int _count;

    public void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            _count++;
            Console.WriteLine($"타이머: {_count}초");
            Tick?.Invoke();
        }
    }

    public void Logger()
    {
        Console.WriteLine("[Logger] 틱 기록됨");
    }
}