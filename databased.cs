using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    interface databased
    {
         DataTable show();
         bool Insert(int id, string onvan, string matn);
         bool delet(int id) ;
        bool update(int id, string onvan, string matn);
        bool dataRow();

    }
}
