using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Requisicoes_BAL
    {
        public static List<DAL.Model.Objetos.Requisicao> VerificaSeUsuarioTemRequisicaoRespondida()
        {
            List<DAL.Model.Objetos.Requisicao> lista = DAL.Model.Requisicoes_DAL.VerificaSeUsuarioTemRequisicaoRespondida(DAL.Model.Objetos.UsuarioStatic.Nome, DAL.Model.Objetos.UsuarioStatic.Filial);
            if (lista.Count > 0)
            {
                DAL.Model.Requisicoes_DAL.RemoveRequisicao(lista[0].Nome, lista[0].Assunto);
                return lista;
            }
            return null;
        }
        public static List<DAL.Model.Objetos.Requisicao> GetRequisicoes()
        {
            return DAL.Model.Requisicoes_DAL.GetRequisicoes();
        }
        public static List<DAL.Model.Objetos.Requisicao> GetRequisicoesPorNome(string nome)
        {
            return DAL.Model.Requisicoes_DAL.GetRequisicoesPorNome(nome);
        }
        public static int AdicionaRequisicao(string usuario, string filial, string data, string assunto, string solicitacao)
        {
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(data) && !string.IsNullOrEmpty(assunto) && !string.IsNullOrEmpty(solicitacao))
            {
                if (assunto.Length <= 100 && solicitacao.Length <= 100)
                {
                    try
                    {
                        DAL.Model.Requisicoes_DAL.RegistrarRequisicao(usuario, filial, data, assunto, solicitacao);
                        return 0;
                    }
                    catch (Exception e)
                    {
                        DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Requisicoes_Adicionar");
                        return 2;
                    }
                }
                return 3;
            }
            return 1;
        }
        public static int RespondeRequisicao(string resposta, string usuario, string assunto)
        {
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(resposta) && !string.IsNullOrEmpty(assunto))
            {
                if (resposta.Length <= 100)
                {
                    try
                    {
                        DAL.Model.Requisicoes_DAL.ResponderRequisicao(resposta, usuario, assunto);
                        return 0;
                    }
                    catch (Exception e)
                    {
                        DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Requisicoes_Responder");
                        return 2;
                    }
                }
                return 3;
            }
            return 1;
        }
    }
}
