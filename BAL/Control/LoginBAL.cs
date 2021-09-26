using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BAL;

namespace BAL.Control
{
    public class LoginBAL
    {
        public static bool ValidaCredenciais(string login, string senha)
        {
            return DAL.Model.LoginDAL.VerificaCredenciais(login, senha);
        }
    }
}
