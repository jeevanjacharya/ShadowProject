using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProductEFMVC.Models
{
    public class ProductModel
    {
        [DisplayName("Sl.no.")]
        public int Slno { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Price")]
        public int ProductPrice { get; set; }
    }
}