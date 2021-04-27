﻿using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {

            var enderecoDoArquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open); // abrindo arquivo texto

            var buffer = new byte[1024]; //numero de posiçoes

            var numeroDeBytesLidos = -1;

            while (numeroDeBytesLidos !=0) 
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); // Parametro 1 numero de posices pametro 2 inicio da leitura parameto 3 final da leitura
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meubyte in buffer)
            {
                Console.Write(meubyte);
                Console.Write(" ");
            }
        }
    }
} 
 