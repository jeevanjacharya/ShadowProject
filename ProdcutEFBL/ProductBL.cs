using ProductEFDAL;
using ProductEFDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdcutEFBL
{
    public class ProductBL
    {
        ProductDAL dalObj;
        public ProductBL()
        {
            dalObj = new ProductDAL();
        }

        public List<ProductDTO> GetAllProducts()
        {
            return dalObj.GetAllProducts();
        }

        public int AddNewProduct(ProductDTO newProductObj)
        {
            int result = dalObj.InsertNewProduct(newProductObj);
            return result;
        }

        public int UpdateProduct(ProductDTO newProductObj)
        {
            int result = dalObj.UpdateProduct(newProductObj);
            return result;
        }
    }
}
