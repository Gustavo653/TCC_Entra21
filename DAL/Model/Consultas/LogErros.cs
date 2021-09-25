using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Consultas
{
    public class LogErros
    {
        public static void GerarErro(Exception e)
        {
            string data = DateTime.Now.ToString().Replace("/", "-");
            string nomeArquivo = "Erro - Horario e data: " + data;
            string caminhoerro = @"C:\Users\Public\Documents\"+nomeArquivo+".txt";
            StreamWriter erro;
            erro = File.CreateText(caminhoerro);
            erro.WriteLine("Erro detectado");
            erro.WriteLine("Data do erro:" + DateTime.Now);
            erro.WriteLine("Detalhes: " + e.ToString());
            erro.WriteLine("Detalhes simplificados: " + e.Message);
            erro.WriteLine("Erro finalizado!");
            erro.Close();
        }
    }
}
