using LabNet2021.Entities;
using LabNet2021.Entities.ClassDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic
{
    public class CustomersLogic : BaseLogic, ILogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers ObjectCustomers()
        {
            var query = context.Customers.FirstOrDefault();
            return query;
        }

        public List<CustomersDTO> AllCustomersFromRegion(string region)
        {
            var query = from c in context.Customers
                        where c.Region == region
                        select new CustomersDTO() { CustomerID = c.CustomerID, ContactName = c.ContactName, CompanyName = c.CompanyName, Region = c.Region, PostalCode = c.PostalCode };
            return query.ToList();
        }

        public List<CustomersDTO> NameCustomersUppercaseLowercase()
        {
            var query = from c in context.Customers
                        select new CustomersDTO() { CustomerID = c.CustomerID, CompanyNameUpper = c.CompanyName.ToUpper(), CompanyNameLower = c.CompanyName.ToLower() };
            return query.ToList();
        }

    }
}
