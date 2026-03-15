using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Inventory inventory = new Inventory();
InventoryUI inventoryUI = new InventoryUI();
AutoBuyer autoBuyer = new AutoBuyer();

inventory.ItemChanged += inventoryUI.OnInventoryUI;
inventory.ItemChanged += autoBuyer.OnAutoBuyer;

inventory.AddItem("포션", 5);
inventory.AddItem("화살", 10);
inventory.AddItem("포션", 3);
inventory.RemoveItem("화살", 7);
inventory.RemoveItem("화살", 7);