using FarmaTech.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTech.Control
{
    class TelaLoginController
    {
        public static bool ValidaCredenciais(string login, string senha)
        {
            return TelaLoginModel.VerificaCredenciais(login, senha);
        }
    }
}
