using System;

class InventoryUI
{
    public void OnInventoryUI(string name, int oldAmount, int newAmount)
    {
        Console.WriteLine($"[UI] {name}: {oldAmount} → {newAmount}");
    }
}