using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsarStreamDeEntrada()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using (var fs = new FileStream("EntradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024]; // 1Kb
                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);

                    fs.Write(buffer,0,bytesLidos);

                    fs.Flush();

                    Console.WriteLine($"Bytes Lidos da Console:{bytesLidos}");
                }
            }


        }
    }
}