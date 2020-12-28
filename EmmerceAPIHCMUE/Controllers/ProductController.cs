﻿using EmmerceAPIHCMUE.Models;
using EmmerceAPIHCMUE.Provider;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EmmerceAPIHCMUE.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("/product")]

    public class ProductController : Controller
    {
        [HttpPost("add")]
        public ResponseData AddVouchers([FromBody] Product product)
        {
            try
            {
                if (Request.Headers["Authorization"] != "")
                {
                    CustomMiddleware middleware = new CustomMiddleware(Request.Headers["Authorization"]);
                    if (middleware.ValidateToken(Constants.Instance.ADMIN_ROLE1))
                    {
                        if (product.AddProduct())
                        {
                            return new ResponseData(Constants.Instance.SUCCESS_CODE, Constants.Instance.ADD_SUCESS1, null);
                        }
                        return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
                    }
                    else
                    {
                        return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SESSION_EXPIRED, null);
                    }
                }
                else
                {
                    return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SESSION_EXPIRED, null);
                }
            }
            catch (Exception e)
            {
                return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
            }
        }

        [HttpPost("delete")]
        public ResponseData DeleteProduct([FromBody] Product product)
        {
            try
            {
                if (Request.Headers["Authorization"] != "")
                {
                    CustomMiddleware middleware = new CustomMiddleware(Request.Headers["Authorization"]);
                    if (middleware.ValidateToken(Constants.Instance.ADMIN_ROLE1))
                    {
                        if (product.DeleteProduct())
                        {
                            return new ResponseData(Constants.Instance.SUCCESS_CODE, Constants.Instance.DELETE_SUCESS1, null);
                        }
                        return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
                    }
                    else
                    {
                        return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SESSION_EXPIRED, null);
                    }
                }
                else
                {
                    return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SESSION_EXPIRED, null);
                }
            }
            catch (Exception e)
            {
                return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
            }
        }

        [HttpPost("update")]
        public ResponseData UpdateProduct([FromBody] Product product)
        {
            try
            {
                if (Request.Headers["Authorization"] != "")
                {
                    CustomMiddleware middleware = new CustomMiddleware(Request.Headers["Authorization"]);
                    if (middleware.ValidateToken(Constants.Instance.ADMIN_ROLE1))
                    {
                        if (product.UpdateProduct())
                        {
                            return new ResponseData(Constants.Instance.SUCCESS_CODE, Constants.Instance.UPDATE_SUCESS1, null);
                        }
                        return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.UPDATE_FAIL1, null);
                    }
                    else
                    {
                        return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SESSION_EXPIRED, null);
                    }
                }
                else
                {
                    return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SESSION_EXPIRED, null);
                }

            }
            catch (Exception e)
            {
                return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
            }
        }

        [HttpGet("all")]
        public ResponseData GetAllProduct()
        {
            try
            {
                Product product = new Product();
                DataTable dt = product.GetAllProduct();

                List<Product> resData = new List<Product>();
                foreach (DataRow row in dt.Rows)
                {
                    Product a = new Product();
                    a.IdProduct = row["idProduct"].ToString();
                    a.IdSize = row["idSize"].ToString();
                    a.IdBrand = row["idBrand"].ToString();
                    a.IdColor = row["idColor"].ToString();
                    a.IdCategory = row["idCategory"].ToString();
                    a.IdType = row["idType"].ToString();
                    a.ProductName = row["productName"].ToString();
                    a.Price = row["price"].ToString();
                    a.SalePrice = row["salePrice"].ToString();
                    a.PhotoReview = row["photoReview"].ToString();
                    a.Detail = row["detail"].ToString();
                    a.IsSaling = Int32.Parse(row["isSaling"].ToString());
                    a.ExpiredSalingDate = row["expiredSalingDate"].ToString();
                    a.DateAdded = row["dateAdded"].ToString();

                    resData.Add(a);
                }
                return new ResponseData(Constants.Instance.SUCCESS_CODE, Constants.Instance.SUCCESS_MESSAGE1, resData);
            }
            catch (Exception e)
            {
                return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
            }
        }
        [HttpPost("find-by-id")]
        public ResponseData GetProductById([FromBody] Product p)
        {
            try
            { //idProduct
                Product data = p.GetProductById();
                return new ResponseData(Constants.Instance.SUCCESS_CODE, Constants.Instance.SUCCESS_MESSAGE1, data);

            }
            catch (Exception e)
            {
                return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
            }
        }
        [HttpPost("get-by-type")]
        public ResponseData GetProductByType([FromBody] Product p)
        {
            try
            {
                DataTable dt = p.GetProductByType();

                List<Product> resData = new List<Product>();
                foreach (DataRow row in dt.Rows)
                {
                    Product a = new Product();
                    a.IdProduct = row["idProduct"].ToString();
                    a.IdSize = row["idSize"].ToString();
                    a.IdBrand = row["idBrand"].ToString();
                    a.IdColor = row["idColor"].ToString();
                    a.IdCategory = row["idCategory"].ToString();
                    a.IdType = row["idType"].ToString();
                    a.Price = row["price"].ToString();
                    a.ProductName = row["productName"].ToString();
                    a.SalePrice = row["salePrice"].ToString();
                    a.PhotoReview = row["photoReview"].ToString();
                    a.Detail = row["detail"].ToString();
                    a.IsSaling = Int32.Parse(row["isSaling"].ToString());
                    a.ExpiredSalingDate = row["expiredSalingDate"].ToString();
                    a.DateAdded = row["dateAdded"].ToString();

                    resData.Add(a);
                }
                return new ResponseData(Constants.Instance.SUCCESS_CODE, Constants.Instance.SUCCESS_MESSAGE1, resData);
            }
            catch (Exception e)
            {
                return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
            }
        }
        [HttpGet("bestseller")]
        public ResponseData GetBestSeller()
        {
            try
            {
                Product product = new Product();
                DataTable dt = product.GetBestSeller();


                List<BestSeller> response = new List<BestSeller>();
;                foreach (DataRow row in dt.Rows)
                {
                    Product pr = new Product();
                    pr.IdProduct = row[0].ToString();
                    Product aa = pr.GetProductById();
                    BestSeller best = new BestSeller(aa, Int32.Parse(row[1].ToString()));
                    response.Add(best);
                    /*
                    Product a = new Product();
                    a.IdProduct = row["idProduct"].ToString();
                    a.IdSize = row["idSize"].ToString();
                    a.IdBrand = row["idBrand"].ToString();
                    a.IdColor = row["idColor"].ToString();
                    a.IdCategory = row["idCategory"].ToString();
                    a.IdType = row["idType"].ToString();
                    a.ProductName = row["productName"].ToString();
                    a.Price = row["price"].ToString();
                    a.SalePrice = row["salePrice"].ToString();
                    a.PhotoReview = row["photoReview"].ToString();
                    a.Detail = row["detail"].ToString();
                    a.IsSaling = Int32.Parse(row["isSaling"].ToString());
                    a.ExpiredSalingDate = row["expiredSalingDate"].ToString();
                    a.DateAdded = row["dateAdded"].ToString();

                    resData.Add(a);*/
                }
                return new ResponseData(Constants.Instance.SUCCESS_CODE, Constants.Instance.SUCCESS_MESSAGE1, response);
            }
            catch (Exception e)
            {
                return new ResponseData(Constants.Instance.FAIL_CODE, Constants.Instance.SOMETHING_WAS_WRONG, null);
            }
        }
    }
    class BestSeller
    {
        public Product product { get; set; }
        public int popular { get; set; }

        public BestSeller(Product p, int popular)
        {
            this.product = p;
            this.popular = popular;
        }
    }
}
