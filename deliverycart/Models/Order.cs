#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace deliverycart.Models
{
    public class Order
    {   
        public int OrderID {get;set;}
        public int UserID {get;set;}
        public int ItemID {get;set;}    
        public int Qty {get;set;}
        //public Item Item {get;set;}= default!;
        //public User User {get;set;}= default!;


    }
}