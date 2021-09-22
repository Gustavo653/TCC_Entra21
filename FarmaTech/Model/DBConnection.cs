using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTech
{
    class DbConnection
    {
        //internal static SqlConnection conn = new SqlConnection("Data Source=BUE205D20;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        //internal static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9OFNM36;Initial Catalog=master;Integrated Security=True");
        internal static SqlConnection conn = new SqlConnection("workstation id=BDEntra21.mssql.somee.com;packet size=4096;user id=Gustavo10_SQLLogin_1;pwd=dg6kzsavsg;data source=BDEntra21.mssql.somee.com;persist security info=False;initial catalog=BDEntra21");

    }
}
