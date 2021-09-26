using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic
{
    interface ILogic<T>
    {
        List<T> GetAll();
    }
}
