#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deliverycart.Models
{
    public class Vendor
    {
        public int VendorID {get;set;}    
        public string storeName {get;set;}  
        public string storeAddress {get;set;}= default!;
        public string storeCity {get;set;}= default!;
        public string storeState {get;set;}= default!;
        public int storeZip {get;set;}
        public List<Item> Items {get;set;}
              
        
    }
}