using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TrabalhoAlg3
{
    class Leitura
    {
        public string Ler()
        {
            string Caminho = @"C:\Users\fabio\Desktop\Git\FabioDev\TrabalhoAlg33Escrita.txt";

            string Leitura = File.ReadAllText(Caminho);
            return Leitura;
        }
    }
}
