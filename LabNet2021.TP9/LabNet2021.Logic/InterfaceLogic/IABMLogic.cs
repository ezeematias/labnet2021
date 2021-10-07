using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T addItem);
        void Delete(int id);
        void Update(T updateItem);
        bool Find(int id);
        T Get(int id);
    }
}
