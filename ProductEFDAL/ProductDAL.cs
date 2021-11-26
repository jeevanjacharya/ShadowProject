using ProductEFDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProductEFDAL
{
    public class ProductDAL
    {
        public List<ProductDTO> GetAllProducts()
        {
            List<ProductDTO> lstProducts = new List<ProductDTO>();
            try
            {
                ProductEntities1 efObj = new ProductEntities1();
                var result = efObj.Products.ToList();
                foreach(var item in result)
                {
                    lstProducts.Add(new ProductDTO()
                    {
                        Slno = item.Slno,
                        ProductName = item.ProductName,
                        ProductPrice = item.ProductPrice
                    });
                }
                return lstProducts;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public int InsertNewProduct(ProductDTO newProductObj)
        {
            int resultflag = 0;
            try
            {
                ProductEntities1 contextObj = new ProductEntities1();
                Product newDBProductObj = new Product()
                {
                    ProductName = newProductObj.ProductName,
                    ProductPrice = newProductObj.ProductPrice
                };
                contextObj.Products.Add(newDBProductObj);
                resultflag = contextObj.SaveChanges();
                return resultflag;
            }
            catch (Exception)
            {
                resultflag = -99;
               // throw;
            }
            return resultflag;
        }

        public int UpdateProduct(ProductDTO newProductObj)
        {
            int resultflag = 0;
            try
            {
                ProductEntities1 contextObj = new ProductEntities1();
                Product newDBProductObj = new Product()
                {
                    Slno = newProductObj.Slno,
                    ProductName = newProductObj.ProductName,
                    ProductPrice = newProductObj.ProductPrice
                };
                contextObj.Products.Add(newDBProductObj);
                resultflag = contextObj.SaveChanges();
                return resultflag;
            }
            catch (Exception)
            {
                resultflag = -99;
                // throw;
            }
            return resultflag;
        }





    }
}
