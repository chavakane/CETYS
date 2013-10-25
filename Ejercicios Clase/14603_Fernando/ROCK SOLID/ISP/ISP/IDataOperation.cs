using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IDataOperation : IReportOperation
    {
        void saveData(string name);
        bool connectDataBase();
        void createData();
    }

    public interface IReportOperation
    {
        void createData();
    }

}
