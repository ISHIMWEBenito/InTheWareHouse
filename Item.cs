using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app
{

class Item
{
public int ItemID { get; set; }
public string ItemName { get; set; }
public Item(int ItemID)
{
this.ItemID = ItemID;
this.ItemName = "Microsoft Office 2013";
}
}

}