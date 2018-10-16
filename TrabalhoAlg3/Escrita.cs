using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlg3
{
    class Escrita
    {
        public void Escrever (string escreve)
        {
            string Caminho = @"C:\Users\Carlos Ramon\source\repos\TrabalhoAlg33\Escrita.txt";
            File.WriteAllText(Caminho, escreve);
        }

    }
}
