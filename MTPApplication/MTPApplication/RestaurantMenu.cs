//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTPApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class RestaurantMenu
    {
        public int restaurantID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte[] image { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}
