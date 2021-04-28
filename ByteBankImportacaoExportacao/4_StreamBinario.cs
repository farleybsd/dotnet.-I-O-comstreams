using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("ContaCorrenteBinaria.txt",FileMode.Create))
            {
                using (var escritor = new BinaryWriter(fs))
                {
                    escritor.Write(456); //CC
                    escritor.Write(546544); //AG
                    escritor.Write(4000.50); // R$
                    escritor.Write("Farley Rufino"); // Titular
                }
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("ContaCorrenteBinaria.txt", FileMode.Open))
            {
                using (var leitor = new BinaryReader(fs))
                {
                    var agencia = leitor.ReadInt32();
                    var numeroconta = leitor.ReadInt32();
                    var saldo = leitor.ReadDouble();
                    var titular = leitor.ReadString();

                    Console.WriteLine($"{agencia}/{numeroconta} - {titular} - R$:{saldo}");
                }
            }
        }
    }
}