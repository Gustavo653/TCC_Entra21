using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class CRUD_Enderecos_BAL
    {
        public static List<DAL.Model.Objetos.Endereco> GetEndereco(int enumEndereco)
        {
            return DAL.Model.CRUD_Enderecos_DAL.GetEnderecos(enumEndereco);
        }
        public static List<DAL.Model.Objetos.Endereco> GetEnderecoPorNome(int enumEndereco, string nome)
        {
            return DAL.Model.CRUD_Enderecos_DAL.GetEnderecosPorNome(nome, enumEndereco);
        }
        public static int AdicionarEndereco(int enumEndereco, string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado)
        {
            if (!string.IsNullOrEmpty(razaoSocial) &&
                !string.IsNullOrEmpty(nomeFantasia) &&
                !string.IsNullOrEmpty(cNPJCPF) &&
                !string.IsNullOrEmpty(contato) &&
                !string.IsNullOrEmpty(rua) &&
                !string.IsNullOrEmpty(numero) &&
                !string.IsNullOrEmpty(complemento) &&
                !string.IsNullOrEmpty(cidade) &&
                !string.IsNullOrEmpty(estado))
            {
                if (!DAL.Model.CRUD_Enderecos_DAL.VerificaSeEnderecoRepete(contato)) //Verificar se deu certo
                {
                    try
                    {
                        DAL.Model.CRUD_Enderecos_DAL.InsereEndereco(enumEndereco, razaoSocial, nomeFantasia, cNPJCPF, contato, rua, numero, complemento, cidade, estado);
                        return 0; //Deu tudo certo
                    }
                    catch (Exception e)
                    {
                        DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Enderecos_Adicionar");
                        return 3; //Algo inesperado ocorreu
                    }
                }
                return 2; //Erro usuario ja existe
            }
            return 1; //Erro algum campo está vazio
        }
        public static int RemoveEndereco(string contato)
        {
            if (!string.IsNullOrEmpty(contato))
            {
                try
                {
                    DAL.Model.CRUD_Enderecos_DAL.RemoveEndereco(contato);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Enderecos_Remover");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaEndereco(string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado)
        {
            if (!string.IsNullOrEmpty(razaoSocial) &&
               !string.IsNullOrEmpty(nomeFantasia) &&
               !string.IsNullOrEmpty(cNPJCPF) &&
               !string.IsNullOrEmpty(contato) &&
               !string.IsNullOrEmpty(rua) &&
               !string.IsNullOrEmpty(numero) &&
               !string.IsNullOrEmpty(complemento) &&
               !string.IsNullOrEmpty(cidade) &&
               !string.IsNullOrEmpty(estado))
            {
                if (!DAL.Model.CRUD_Enderecos_DAL.VerificaSeEnderecoRepete(contato))
                {
                    try
                    {
                        DAL.Model.CRUD_Enderecos_DAL.AtualizaEndereco(razaoSocial, nomeFantasia, cNPJCPF, contato, rua, numero, complemento, cidade, estado);
                        return 0; //Deu tudo certo
                    }          
                    catch (Exception e)
                    {
                        DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Enderecos_Atualizar");
                        return 3; //Algo inesperado ocorreu
                    }
                }
                return 2; //Erro usuario ja existe
            }
            return 1; //Erro algum campo está vazio
        }
    }
}
