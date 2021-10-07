using LabNet2021.Data;
using LabNet2021.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        /// <summary>
        /// Get a list of Shippers
        /// </summary>
        /// <returns>List of Shippers</returns>
        public List<Shippers> GetAll()
        {
            try
            {
                return context.Shippers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Add a Shippers
        /// </summary>
        /// <param name="newShippers">Shippers to add</param>
        public void Add(Shippers newShippers)
        {
            try
            {
                context.Shippers.Add(newShippers);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete a Shippers
        /// </summary>
        /// <param name="id">Shipper ID</param>
        public void Delete(int id)
        {
            try
            {
                var shippersDelete = context.Shippers.Find(id);
                if (shippersDelete != null)
                {
                    context.Shippers.Remove(shippersDelete);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The shippers to delete was not found.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Modify Shippers
        /// </summary>
        /// <param name="updateShipper">Shippers to modify.</param>
        public void Update(Shippers updateShipper)
        {
            try
            {
                var bufferShippers = context.Shippers.Find(updateShipper.ShipperID);
                if (bufferShippers != null)
                {
                    bufferShippers.CompanyName = updateShipper.CompanyName;
                    bufferShippers.Phone = updateShipper.Phone;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The category to modify was not found.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Find Shippers
        /// </summary>
        /// <param name="id">Shippers ID</param>
        /// <returns>If the Shippers exists, return TRUE, otherwise FALSE</returns>
        public bool Find(int id)
        {
            try
            {
                bool output = false;
                var bufferShippers = context.Shippers.Find(id);
                if (bufferShippers != null)
                {
                    output = true;
                }
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Find Shippers
        /// </summary>
        /// <param name="id">Shippers ID</param>
        /// <returns>If the Shippers exists, return Shipper, otherwise NULL</returns>
        public Shippers Get(int id)
        {
            try
            {
                var bufferShippers = context.Shippers.Find(id);
                return bufferShippers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
