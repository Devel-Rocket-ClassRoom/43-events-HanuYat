using System;

class AutoBuyer
{
    public void OnAutoBuyer(string name, int oldAmount, int newAmount)
    {
        if (newAmount == 0 && oldAmount > 0)
        {
            Console.WriteLine($"[자동구매] {name} 재고 소진! 자동 구매 요청");
        }        
    }
}