using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    interface IPersistence<T>
    {
        T Read(int Id);
        T Update(T Entity);
        bool Delete(T Entity);
        List<T> GetList();
    }
}
