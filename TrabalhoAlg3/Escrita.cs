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
            string Caminho = @"C:\Users\fabio\Desktop\Git\FabioDev\TrabalhoAlg33Escrita.txt";
            File.WriteAllText(Caminho, escreve);
        }

    }
}
