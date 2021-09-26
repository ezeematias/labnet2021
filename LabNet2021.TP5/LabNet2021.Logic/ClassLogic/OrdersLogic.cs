using LabNet2021.Entities;
using LabNet2021.Entities.ClassDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic
{
    public class OrdersLogic : BaseLogic, ILogic<Orders>
    {
        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public List<OrdersDTO> CustomersOrdersForRegionAndDate(string region, DateTime dateTime)
        {            
            var query = from o in context.Orders
                        join c in context.Customers
                        on o.CustomerID equals c.CustomerID
                        where c.Region == region
                        where o.OrderDate > dateTime
                        select new OrdersDTO() { OrderID = o.OrderID, CompanyName = c.CompanyName,Region = c.Region ,OrderDate = o.OrderDate };
            return query.ToList();
        }

        public List<OrdersDTO> CustomerRegionWAJoinOrdersDateOver111997()
        {
            DateTime date = new DateTime(1997, 01, 01, 0, 00, 0);

            var query = from o in context.Orders
                        join c in context.Customers
                        on o.CustomerID equals c.CustomerID
                        where c.Region == "WA"
                        where o.OrderDate > date
                        select new OrdersDTO
                        {
                            CompanyName = c.CompanyName,
                            Region = c.Region,
                            OrderDate = o.OrderDate
                        };

            if (query is null)
            {
                //throw new CustomException(" NO EXISTEN REGISTROS QUE CUMPLAN LA CONDICION ESPECIFICADA");
            }

            return query.ToList();
        }
    }
}
