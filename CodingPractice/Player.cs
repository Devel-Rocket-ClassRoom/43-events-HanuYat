using System;

class Player
{
    private int _health = 100;
    public event Action<int> DamageTaken;    

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"플레이어 체력: {_health}");
        DamageTaken?.Invoke(_health);
    }

    public void HealthBar(int health)
    {
        Console.WriteLine($"[UI] 체력바 업데이트: {health}%");
    }

    public void SoundManager(int health)
    {
        Console.WriteLine("[Sound] 피격 효과음 재생");
    }
}