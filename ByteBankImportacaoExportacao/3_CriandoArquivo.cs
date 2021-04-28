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
    }
}