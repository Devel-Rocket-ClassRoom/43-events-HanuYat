using System;
using System.Collections.Generic;

class Inventory
{
    public event Action<string, int, int> ItemChanged;
    private Dictionary<string, int> _items = new Dictionary<string, int>();

    public void AddItem(string name, int count)
    {
        // 1. 이전 수량 확인 (없으면 0)
        int oldAmount = _items.ContainsKey(name) ? _items[name] : 0;
        
        // 2. 수량 갱신
        if (!_items.ContainsKey(name)) _items[name] = 0;
        _items[name] += count;

        // 3. 이벤트 호출 (아이템명, 이전 수량, 현재 수량)
        ItemChanged?.Invoke(name, oldAmount, _items[name]);
    }

    public void RemoveItem(string name, int count)
    {
        if (_items.TryGetValue(name, out int oldAmount))
        {
            // 0 미만 방지 로직
            int newAmount = Math.Max(0, oldAmount - count);
            _items[name] = newAmount;

            // 이벤트 호출
            ItemChanged?.Invoke(name, oldAmount, newAmount);
        }
    }
}