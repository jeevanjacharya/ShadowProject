using ProdcutEFBL;
using ProductEFDTO;
using ProductEFMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductEFMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ViewProducts()
        {
            List<ProductModel> lstProduct = new List<ProductModel>();
            ProductBL blObj = new ProductBL();
            var dbResult = blObj.GetAllProducts();
            foreach (var item in dbResult)
            {
                lstProduct.Add(new ProductModel()
                {
                    Slno = item.Slno,
                    ProductName = item.ProductName,
                    ProductPrice = item.ProductPrice
                });
            }
            return View(lstProduct);            
        }

        [HttpGet]
        public ActionResult AddNewProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewProductPost(ProductModel newProdObj)
        {
            try
            {
                ProductBL blObj = new ProductBL();
                ProductDTO dtoObj = new ProductDTO();
                dtoObj.ProductName = newProdObj.ProductName;
                dtoObj.ProductPrice = newProdObj.ProductPrice;
                int result = blObj.AddNewProduct(dtoObj);
                if (result == 1)
                {
                    TempData["AlertMessage"] = "Product added successfully!!";
                    return RedirectToAction("ViewProducts");
                }
                else
                {
                    return View("AddNewProduct");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }

        }

        [HttpGet]
        public ActionResult UpdateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateProductPost(ProductModel newProdObj)
        {
            try
            {
                ProductBL blObj = new ProductBL();
                ProductDTO dtoObj = new ProductDTO();
                dtoObj.Slno = newProdObj.Slno;
                dtoObj.ProductName = newProdObj.ProductName;
                dtoObj.ProductPrice = newProdObj.ProductPrice;
                int result = blObj.AddNewProduct(dtoObj);
                if (result == 1)
                {
                    TempData["AlertMessage"] = "Product Updated successfully!!";
                    return RedirectToAction("ViewProducts");
                }
                else
                {
                    return View("UpdateProduct");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }

        }


    }
}