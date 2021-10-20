using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Consultas
{
    public class Log
    {
        public static void GerarErro(Exception e, string localErro)
        {
            string data = DateTime.Now.ToString().Replace(":", "-").Replace("/", "=");
            string nomeArquivo = "Local do erro - " + localErro + " - Horario e data - " + data;
            string caminhoerro = @"C:\Users\Public\Documents\FarmaTech\Erros\" + nomeArquivo + ".txt";
            StreamWriter erro;
            erro = File.CreateText(caminhoerro);
            erro.WriteLine("Erro detectado");
            erro.WriteLine("Data do erro:" + DateTime.Now);
            erro.WriteLine("Detalhes: " + e.ToString());
            erro.WriteLine("Detalhes simplificados: " + e.Message);
            erro.WriteLine("Erro finalizado!");
            erro.Close();
        }

        public static void GerarCommands(string command)
        {
            if (!File.Exists(DbConnection.caminhoCommands))
            {
                StreamWriter commands = File.CreateText(DbConnection.caminhoCommands);
                commands.WriteLine(command);
                commands.Close();
            }
            else
            {
                StreamWriter commands = File.AppendText(DbConnection.caminhoCommands);
                commands.WriteLine(command);
                commands.Close();
            }
        }

        public static void ApagarCommands()
        {            
            if (File.Exists(DbConnection.caminhoCommands))
                File.Delete(DbConnection.caminhoCommands);
        }

        public static void GerarCupom(string codigoCupom, string localCupom, string razaoSocial, string cnpj, string produto, string quant, string precoUnit, string precoTotalProduto, string valorTotal, string formaPagamento)
        {
            string data = DateTime.Now.ToString().Replace(":", "-").Replace("/", "=");
            string nomeArquivo = "Local do cupom - " + localCupom + " - Horario e data - " + data;
            string caminhoCupom = @"C:\Users\Public\Documents\FarmaTech\Cupom" + nomeArquivo + ".txt";

            StreamWriter cupomText;
            cupomText = File.CreateText(caminhoCupom);
            cupomText.WriteLine("............................CUPOM FISCAL............................");
            cupomText.WriteLine();
            cupomText.WriteLine("Número: " + codigoCupom);
            cupomText.WriteLine();
            cupomText.WriteLine("Fornecedor:  FarmaTech    " + "Filial:   " + "CNPJ: ");
            cupomText.WriteLine("-------------------------------------------------------------------- ");
            cupomText.WriteLine("-------------------------------------------------------------------- ");
            cupomText.WriteLine("Cliente: " + razaoSocial + "\tCPF/CNPJ: " + cnpj);
            cupomText.WriteLine("=====================================================================");            
            cupomText.WriteLine("Produto:                       Quant.:          Unit. R$:            ");
            cupomText.WriteLine(produto + "\t\t" + quant + "\t\t" + precoTotalProduto);
            cupomText.WriteLine();
            cupomText.WriteLine("Valor Total: R$ " + valorTotal);
            cupomText.WriteLine("Forma de Pagamento: " + formaPagamento);
            cupomText.WriteLine("=====================================================================");
            cupomText.WriteLine("Volte sempre - Obrigado");
            cupomText.WriteLine("FarmaTech by Query Lab - 2021®");
            cupomText.Close();
        }

    }
}
