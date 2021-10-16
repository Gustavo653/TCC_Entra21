using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Consultas
{
    public class HashLogin
    {
        private HashAlgorithm _algoritmo;
        public HashLogin(HashAlgorithm algoritmo) //Construtor que recebe SHA512_Create
        {
            _algoritmo = algoritmo;
        }
        public string CriptografarSenha(string senha)
        {
            return senha;
        }

        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            return senhaDigitada == senhaCadastrada;
        }
    }
}

