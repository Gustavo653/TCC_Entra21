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
            var encodedValue = Encoding.UTF8.GetBytes(senha); //Codificação de caracteres em UTF8
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue); //Calcula o hash dos caracteres UTF8

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2")); //Determina que a senha deve ser hexadecimal
            }

            return sb.ToString();
        }

        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada)); //Recebe a senha inserida pelo usuario e converte para hash

            var sb = new StringBuilder();
            foreach (var caractere in encryptedPassword)
            {
                sb.Append(caractere.ToString("X2")); //Determina que a senha deve ser hexadecimal
            }

            return sb.ToString() == senhaCadastrada; //Se a senha for a mesma, retorna true
        }
    }
}

