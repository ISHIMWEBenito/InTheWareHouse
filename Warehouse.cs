using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app
{

 class Warehouse
{

public string WarehouseLocation {get; set;}

public Warehouse (string WarehouseLocation)
{
this.WarehouseLocation = WarehouseLocation;
}

public Item FindandReturnItem(int ItemID)
{

Item RequestedItem = new Item(ItemID);
return RequestedItem;
}
}

}