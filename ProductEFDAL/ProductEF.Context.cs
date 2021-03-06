//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductEFDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProductEntities1 : DbContext
    {
        public ProductEntities1()
            : base("name=ProductEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserDetail1> UserDetails1 { get; set; }
    
        public virtual int usp_AddNewProdcut(string pName, Nullable<int> pPrice)
        {
            var pNameParameter = pName != null ?
                new ObjectParameter("pName", pName) :
                new ObjectParameter("pName", typeof(string));
    
            var pPriceParameter = pPrice.HasValue ?
                new ObjectParameter("pPrice", pPrice) :
                new ObjectParameter("pPrice", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddNewProdcut", pNameParameter, pPriceParameter);
        }
    
        public virtual int usp_UpdateProduct(Nullable<int> slno, string pName, Nullable<int> pPrice)
        {
            var slnoParameter = slno.HasValue ?
                new ObjectParameter("slno", slno) :
                new ObjectParameter("slno", typeof(int));
    
            var pNameParameter = pName != null ?
                new ObjectParameter("pName", pName) :
                new ObjectParameter("pName", typeof(string));
    
            var pPriceParameter = pPrice.HasValue ?
                new ObjectParameter("pPrice", pPrice) :
                new ObjectParameter("pPrice", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateProduct", slnoParameter, pNameParameter, pPriceParameter);
        }
    }
}
