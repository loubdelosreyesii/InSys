﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class X2MO_InSysEntities : DbContext
    {
        public X2MO_InSysEntities()
            : base("name=X2MO_InSysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Dealer> Dealers { get; set; }
        public virtual DbSet<Raffle> Raffles { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<PointOfSaleDetail> PointOfSaleDetails { get; set; }
        public virtual DbSet<PointOfSale> PointOfSales { get; set; }
        public virtual DbSet<RaffleEntry> RaffleEntries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<RafflePrize> RafflePrizes { get; set; }
        public virtual DbSet<RaffleWinner> RaffleWinners { get; set; }
        public virtual DbSet<RaffleLuckyDrawPrize> RaffleLuckyDrawPrizes { get; set; }
        public virtual DbSet<LuckyDrawWinner> LuckyDrawWinners { get; set; }
        public virtual DbSet<PingPongPrize> PingPongPrizes { get; set; }
        public virtual DbSet<PingPongWinner> PingPongWinners { get; set; }
        public virtual DbSet<ProfitSharing> ProfitSharings { get; set; }
        public virtual DbSet<InventoryPriceHistory> InventoryPriceHistories { get; set; }
        public virtual DbSet<Capital> Capitals { get; set; }
        public virtual DbSet<CapitalHistory> CapitalHistories { get; set; }
    
        public virtual ObjectResult<PointOfSalesViewModel> PointOfSaleViewModel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PointOfSalesViewModel>("PointOfSaleViewModel");
        }
    
        public virtual ObjectResult<sp_LuckyDraw_SelectForView_Result> sp_LuckyDraw_SelectForView(Nullable<int> raffleId)
        {
            var raffleIdParameter = raffleId.HasValue ?
                new ObjectParameter("RaffleId", raffleId) :
                new ObjectParameter("RaffleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_LuckyDraw_SelectForView_Result>("sp_LuckyDraw_SelectForView", raffleIdParameter);
        }
    
        public virtual ObjectResult<sp_LuckyDraw_PickupWinner_Result> sp_LuckyDraw_PickupWinner(Nullable<int> raffleId, Nullable<int> luckyNumber1, Nullable<int> luckyNumber2, Nullable<int> luckyNumber3, Nullable<int> productId, Nullable<int> luckyDrawPrizeId)
        {
            var raffleIdParameter = raffleId.HasValue ?
                new ObjectParameter("RaffleId", raffleId) :
                new ObjectParameter("RaffleId", typeof(int));
    
            var luckyNumber1Parameter = luckyNumber1.HasValue ?
                new ObjectParameter("LuckyNumber1", luckyNumber1) :
                new ObjectParameter("LuckyNumber1", typeof(int));
    
            var luckyNumber2Parameter = luckyNumber2.HasValue ?
                new ObjectParameter("LuckyNumber2", luckyNumber2) :
                new ObjectParameter("LuckyNumber2", typeof(int));
    
            var luckyNumber3Parameter = luckyNumber3.HasValue ?
                new ObjectParameter("LuckyNumber3", luckyNumber3) :
                new ObjectParameter("LuckyNumber3", typeof(int));
    
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var luckyDrawPrizeIdParameter = luckyDrawPrizeId.HasValue ?
                new ObjectParameter("LuckyDrawPrizeId", luckyDrawPrizeId) :
                new ObjectParameter("LuckyDrawPrizeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_LuckyDraw_PickupWinner_Result>("sp_LuckyDraw_PickupWinner", raffleIdParameter, luckyNumber1Parameter, luckyNumber2Parameter, luckyNumber3Parameter, productIdParameter, luckyDrawPrizeIdParameter);
        }
    
        public virtual ObjectResult<sp_RaffleOverview_Result> sp_RaffleOverview(Nullable<int> raffleId)
        {
            var raffleIdParameter = raffleId.HasValue ?
                new ObjectParameter("RaffleId", raffleId) :
                new ObjectParameter("RaffleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RaffleOverview_Result>("sp_RaffleOverview", raffleIdParameter);
        }
    
        public virtual ObjectResult<sp_RaffleDraw_SelectForView_Result> sp_RaffleDraw_SelectForView(Nullable<int> raffleId)
        {
            var raffleIdParameter = raffleId.HasValue ?
                new ObjectParameter("RaffleId", raffleId) :
                new ObjectParameter("RaffleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RaffleDraw_SelectForView_Result>("sp_RaffleDraw_SelectForView", raffleIdParameter);
        }
    
        public virtual ObjectResult<sp_Raffle_PickupWinner_Result> sp_Raffle_PickupWinner(Nullable<int> raffleId)
        {
            var raffleIdParameter = raffleId.HasValue ?
                new ObjectParameter("RaffleId", raffleId) :
                new ObjectParameter("RaffleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Raffle_PickupWinner_Result>("sp_Raffle_PickupWinner", raffleIdParameter);
        }
    
        public virtual ObjectResult<sp_PingPongDraw_SelectForView_Result> sp_PingPongDraw_SelectForView(Nullable<int> raffleId)
        {
            var raffleIdParameter = raffleId.HasValue ?
                new ObjectParameter("RaffleId", raffleId) :
                new ObjectParameter("RaffleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PingPongDraw_SelectForView_Result>("sp_PingPongDraw_SelectForView", raffleIdParameter);
        }
    }
}
