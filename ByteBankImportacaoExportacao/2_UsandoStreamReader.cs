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
        static void UsarStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxoDoArquivo, Encoding.UTF8))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();

                        var contaCorrente = ConverterStringParaContaCorrente(linha);

                        var msg = $"{contaCorrente.Titular.Nome},Conta Número: {contaCorrente.Numero}, Agencia {contaCorrente.Agencia},Saldo {contaCorrente.Saldo}";

                        Console.WriteLine(msg);
                    }
                }
            }
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nometitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nometitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}