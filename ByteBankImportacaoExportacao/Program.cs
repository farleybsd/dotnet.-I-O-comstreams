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
        static void Main(string[] args) 
        {
            // lista de caracters Unicode

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo,FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxoDoArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();

                        Console.WriteLine(linha);
                    }
                }
            }

            Console.ReadLine();
        }

       
    }
} 
 