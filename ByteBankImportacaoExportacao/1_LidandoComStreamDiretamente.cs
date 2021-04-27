using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{ 
   partial class Program
    {
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))  // abrindo arquivo texto
            {
                var buffer = new byte[1024]; //numero de posiçoes

                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); // Parametro 1 numero de posices pametro 2 inicio da leitura parameto 3 final da leitura
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }
        }
        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = new UTF8Encoding();
            var texto = utf8.GetString(buffer, 0, bytesLidos); // Parametro 1 numero de posices pametro 2 inicio da leitura parameto 3 final da leitura

            Console.WriteLine(texto);
            //foreach (var meubyte in buffer)
            //{
            //    Console.Write(meubyte);
            //    Console.Write(" ");
            //}
        }
    }
}