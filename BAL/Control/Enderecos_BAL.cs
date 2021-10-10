using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Enderecos_BAL
    {
        public static List<DAL.Model.Objetos.Endereco> GetEndereco(int enumEndereco) //Obtem os enderecos, por filial ou todos
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                return DAL.Model.Enderecos_DAL.GetEnderecos(enumEndereco, DAL.Model.Objetos.UsuarioStatic.Filial);
            }
            return DAL.Model.Enderecos_DAL.GetEnderecos(enumEndereco);
        }
        public static List<DAL.Model.Objetos.Endereco> GetEnderecoPorNome(int enumEndereco, string nome) //Obtem os enderecos(pesquisando por nome), por filial ou todos
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                return DAL.Model.Enderecos_DAL.GetEnderecosPorNome(nome, enumEndereco, DAL.Model.Objetos.UsuarioStatic.Filial);
            }
            return DAL.Model.Enderecos_DAL.GetEnderecosPorNome(nome, enumEndereco);
        }
        public static int AdicionarEndereco(int enumEndereco, string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado) //Adiciona um endereco caso tudo esteja coerente
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
                if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 3 && enumEndereco != 1)
                {
                    return 1; //Usuario sem filial
                }
                if (!DAL.Model.Enderecos_DAL.VerificaSeEnderecoRepete(contato)) //Verificar se deu certo
                {
                    try
                    {
                        DAL.Model.Enderecos_DAL.InsereEndereco(enumEndereco, razaoSocial, nomeFantasia, cNPJCPF, contato, rua, numero, complemento, cidade, estado, DAL.Model.Objetos.UsuarioStatic.Filial);
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
        public static int RemoveEndereco(string contato) //Remove um endereco caso tudo esteja coerente
        {
            if (!string.IsNullOrEmpty(contato))
            {
                try
                {
                    DAL.Model.Enderecos_DAL.RemoveEndereco(contato);
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
        public static int RemoveEnderecoTodasTabelas(string idFilial) //Remove todas as referencias de um endereco
        {
            if (!string.IsNullOrEmpty(idFilial))
            {
                try
                {
                    DAL.Model.Enderecos_DAL.RemoveTodasTabelas(idFilial);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Enderecos_RemoverTodasTabelas");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaEndereco(string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado, string where) //Atualiza um endereco
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
                try
                {
                    DAL.Model.Enderecos_DAL.AtualizaEndereco(razaoSocial, nomeFantasia, cNPJCPF, contato, rua, numero, complemento, cidade, estado, where);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Enderecos_Atualizar");
                    return 3; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro algum campo está vazio
        }
    }
}
