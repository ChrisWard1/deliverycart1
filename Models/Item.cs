#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deliverycart.Models
{
    public class Item
    {
        public int ItemID {get;set;}                
        public int itemQty {get;set;}
        public string itemName {get;set;}= default!;
        public int VendorID {get;set;}
        public Vendor Vendor {get;set;}

        public List<Order> Orders {get;set;}
        
    }
}