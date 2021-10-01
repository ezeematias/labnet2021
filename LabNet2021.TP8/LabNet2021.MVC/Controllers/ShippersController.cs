using LabNet2021.Entities;
using LabNet2021.Logic;
using LabNet2021.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
            try
            {
                List<Shippers> shippers = logic.GetAll();
                List<ShippersView> shippersViews = shippers.Select(s => new ShippersView
                {
                    Id = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();
                return View(shippersViews);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
                var shipperEntity = new Shippers { CompanyName = shippersView.CompanyName, Phone = shippersView.Phone };
                logic.Add(shipperEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { ex.Message });
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Update(ShippersView shippersView)
        {
            try
            {               
                var shipperEntity = new Shippers { ShipperID = shippersView.Id, CompanyName = shippersView.CompanyName, Phone = shippersView.Phone };
                logic.Update(shipperEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { ex.Message });                
            }
        }

        public ActionResult Update(string id, string companyName, string phone)
        {            
            ViewBag.Id = id;
            ViewBag.CompanyName = companyName;
            ViewBag.Phone = phone;
            return View("Insert");
        }
    }
}