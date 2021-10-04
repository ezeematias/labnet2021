using LabNet2021.Entities;
using LabNet2021.Logic;
using LabNet2021.WebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LabNet2021.WebApi.Controllers
{
    public class ShippersController : ApiController
    {
        ShippersLogic logic = new ShippersLogic();

        // GET: Alls Shippers
        /// <summary>
        /// asdasdadasdasd
        /// </summary>
        /// <returns>Progbando</returns>
        /// <response> PRueba</response>
        /// <remarks> Probando </remarks>       
        public List<ShippersView> Get()
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
                return shippersViews;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // GET: Shippers  
        public ShippersView Get(int id)
        {
            try
            {
                Shippers shippers = logic.Get(id);
                ShippersView shippersView = new ShippersView
                {
                    Id = shippers.ShipperID,
                    CompanyName = shippers.CompanyName,
                    Phone = shippers.Phone
                };
                return shippersView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: Add Shippers
        public void Post(string companyName, string phone)
        {
            try
            {
                var shipperEntity = new Shippers { CompanyName = companyName, Phone = phone };
                logic.Add(shipperEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: Update Shipper
        public void Put(int id, string companyName, string phone)
        {
            try
            {
                if (logic.Find(id))
                {
                    var shipperEntity = new Shippers { ShipperID = id, CompanyName = companyName, Phone = phone };
                    logic.Update(shipperEntity);
                }else
                {
                    throw new Exception("The id is not valid.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: Delete Shipper
        public void Delete(int id)
        {
            try
            {
                logic.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





    }
}
