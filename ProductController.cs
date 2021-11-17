using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectWebApplication.Models;
using BalLibrary;
using DalLibrary;

namespace ProjectWebApplication.Controllers
{
    public class ProductController : ApiController
    {
        public string Get()
        {
            return "value";
        }



        [HttpPost]
        public IHttpActionResult ProductInsert(ProductModel prod)
        {
            ProductDAL ds = new ProductDAL();
            ProductBAL ba = new ProductBAL();

            ba.ProductName = prod.ProductName;
            ba.ActualPrice = prod.ActualPrice;
            ba.Discount = prod.Discount;
            ba.Quantity = prod.Quantity;
            ba.Description = prod.Description;
            ba.Image = prod.Image;
            ba.CategoryId = prod.CategoryId;

            string s1 = ds.AddProduct(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur logged sucess", });

        }


        [HttpPost]
        public IHttpActionResult ProductDelete(ProductModel prod1)
        {
            ProductDAL ds = new ProductDAL();
            ProductBAL ba = new ProductBAL();

            ba.ProductId = prod1.ProductId;
            string s1 = ds.DeleteProduct(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur product deleted", });
        }



        [HttpPost]
        public IHttpActionResult ProductUpdate(ProductModel prod2)
        {
            ProductDAL ds = new ProductDAL();
            ProductBAL ba = new ProductBAL();

            ba.ProductId = prod2.ProductId;
            ba.ProductName = prod2.ProductName;
            ba.ActualPrice = prod2.ActualPrice;
            ba.Discount = prod2.Discount;
            ba.Quantity = prod2.Quantity;
            ba.Description = prod2.Description;
            ba.Image = prod2.Image;
            ba.CategoryId = prod2.CategoryId;

            string s1 = ds.UpdateProduct(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur product updated", });
        }


        [HttpPost]
        public IHttpActionResult ProductDetails(ProductModel prod3)
        {
            ProductDAL ds = new ProductDAL();
            ProductBAL ba = new ProductBAL();

            ba.ProductId = prod3.ProductId;
            ba.ProductName = prod3.ProductName;
            ba.ActualPrice = prod3.ActualPrice;
            ba.Discount = prod3.Discount;
            ba.Quantity = prod3.Quantity;
            ba.Description = prod3.Description;
            ba.Image = prod3.Image;
            ba.CategoryId = prod3.CategoryId;

            string s1 = ds.DisplayAllProduct(ba);
            return Ok(new { status = 200, isSuccess = true, message = "ur product updated", });
        }
    }
}





