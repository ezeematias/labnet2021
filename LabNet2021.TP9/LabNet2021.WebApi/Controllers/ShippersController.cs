using LabNet2021.Entities;
using LabNet2021.Logic;
using LabNet2021.WebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace LabNet2021.WebApi.Controllers
{
    [System.Web.Http.RoutePrefix("Api/Shippers")]
    public class ShippersController : ApiController
    {
        ShippersLogic logic = new ShippersLogic();

        // GET: Alls Shippers
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                List<Shippers> shippers = logic.GetAll();
                if (shippers != null)
                {
                    List<ShippersView> shippersViews = shippers.Select(s => new ShippersView
                    {
                        Id = s.ShipperID,
                        CompanyName = s.CompanyName,
                        Phone = s.Phone
                    }).ToList();
                    return Ok(shippersViews);
                }
                else
                {
                    return BadRequest("Get shipper failed.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Shippers  
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                Shippers shippers = logic.Get(id);
                if (shippers != null)
                {
                    ShippersView shippersView = new ShippersView
                    {
                        Id = shippers.ShipperID,
                        CompanyName = shippers.CompanyName,
                        Phone = shippers.Phone
                    };
                    return Ok(shippersView);
                }
                else
                {
                    return BadRequest("Get shipper failed.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: Add Shippers
        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(ShippersView shippersView)
        {
            try
            {
                if (shippersView != null)
                {
                    var shipperEntity = new Shippers { CompanyName = shippersView.CompanyName, Phone = shippersView.Phone };
                    logic.Add(shipperEntity);
                    return Ok("Successfully added");
                }
                else
                {
                    return BadRequest("Add failed.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: Update Shipper
        [System.Web.Http.HttpPut]
        public IHttpActionResult Put(ShippersView shippersView)
        {
            try
            {
                if (shippersView != null && logic.Find(shippersView.Id))
                {

                    var shipperEntity = new Shippers { ShipperID = shippersView.Id, CompanyName = shippersView.CompanyName, Phone = shippersView.Phone };
                    logic.Update(shipperEntity);
                    return Ok("Successfully modified");
                }
                else
                {
                    return BadRequest("Modification failed");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: Delete Shipper
        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (logic.Find(id))
                {
                    logic.Delete(id);
                    return Ok("Successfully removed");
                }
                else
                {
                    return BadRequest("The id is not valid.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
