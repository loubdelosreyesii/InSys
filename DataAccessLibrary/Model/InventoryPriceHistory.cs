//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLibrary.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryPriceHistory
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal DistributorPrice { get; set; }
        public decimal SuggestedRetailPrice { get; set; }
        public int ProductId { get; set; }
        public System.DateTime TransactionDateTime { get; set; }
    }
}
