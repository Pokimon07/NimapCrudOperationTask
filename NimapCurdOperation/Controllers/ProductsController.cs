using NimapCurdOperation.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using System.Data.Entity;

namespace NimapCurdOperation.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        db_ProductNimapTestEntities dbObj = new db_ProductNimapTestEntities();
        public ActionResult AllProducts(tbl_Products obj)
        {
            
                return View();
        }

        public ActionResult AddProducts(tbl_Products model)
        {
            tbl_Products obj = new tbl_Products();
           
                obj.ProductId = model.ProductId;
                obj.ProductName = model.ProductName;
                obj.CategoryId = model.CategoryId;
                obj.CategoryName = model.CategoryName;

                if (model.ProductId == 0)
                {
                    dbObj.tbl_Products.Add(obj);
                    dbObj.SaveChanges();
                   

                }
                else
                {
                    dbObj.Entry(obj).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }

                ModelState.Clear();
            
            return View("AllProducts");
        }

        public ActionResult ProductsList(int? i)
        {
            var res = dbObj.tbl_Products.ToList().ToPagedList(i ?? 1, 10);
            return View(res);
        }
        public ActionResult DeleteProducts(int ProductId)
        {
            var res = dbObj.tbl_Products.Find(ProductId);
            dbObj.tbl_Products.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.tbl_Products.ToList();

            return RedirectToAction("ProductsList", list);
        }


	}
}