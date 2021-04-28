using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoDoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo= new FileStream(caminhoDoArquivo,FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50,Farley Rufino";

                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes,0,bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoDoArquivo = "contasExportadas.csv";

            using (var fluxoDoArquivo = new FileStream(caminhoDoArquivo,FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDoArquivo,Encoding.UTF8))
                {
                    escritor.Write("456,78945,4785.50,Thalita Rabelo");
                }
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDoArquivo = new FileStream(caminhoArquivo,FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDoArquivo))
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        escritor.WriteLine($"Linha {i}");
                        escritor.Flush(); // Despeja o buffer para o stream! ou seja escreve no arquivo em tempo real
                        Console.WriteLine($"Linha {i}, foi escrita no arquivo.Aperte enter para adicionar uma nova");
                        Console.ReadLine();
                    }
                    
                }
            }
        }
    }
}