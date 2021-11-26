using ProdcutEFBL;
using ProductEFDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEFUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductBL blObj = new ProductBL();
            var finalResult = blObj.GetAllProducts();
            foreach(var item in finalResult)
            {
                Console.WriteLine(item.Slno + "|" + item.ProductName + "|" + item.ProductPrice);
            }

            //Console.WriteLine("-------------------------------------------------------------");

            //Console.WriteLine("Enter the Produt Name");
            //String newProductName = Console.ReadLine();
            //Console.WriteLine("Enter the Product Price");
            //int newProductPrice = Convert.ToInt32(Console.ReadLine());

            //ProductDTO newProductObj = new ProductDTO()
            //{
            //    ProductName = newProductName,
            //    ProductPrice = newProductPrice
            //};

            //int result = blObj.AddNewProduct(newProductObj);
            //if (result == 1)
            //{
            //    Console.WriteLine("product added successfully");
            //}
            //else
            //{
            //    Console.WriteLine("not successful");
            //}

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Enter the SLNO");
            int slno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product name");
            string prodname = Console.ReadLine();
            Console.WriteLine("Enter the Product price");
            int prodprice = Convert.ToInt32(Console.ReadLine());

            ProductDTO ProdObj = new ProductDTO()
            {
                Slno = slno,
                ProductName = prodname,
                ProductPrice = prodprice
            };

            int retVal1 = blObj.UpdateProduct(ProdObj);

            if (retVal1 == 1)
            {
                Console.WriteLine("department UPDATED");
            }
            else
            {
                Console.WriteLine("something is wrong will get back to you");
            }

            var finalResult2 = blObj.GetAllProducts();
            foreach (var item in finalResult2)
            {
                Console.WriteLine(item.Slno + "|" + item.ProductName + "|" + item.ProductPrice);
            }

        }
    }
}
