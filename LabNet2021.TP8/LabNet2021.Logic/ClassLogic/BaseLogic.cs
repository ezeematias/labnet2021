using LabNet2021.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;
       
        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
