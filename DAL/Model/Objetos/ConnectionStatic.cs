using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public static class ConnectionStatic
    {
        public static SqlConnection connRemoto { get; set; }
        public static SqlCeConnection connLocal { get; set; }
    }
}
