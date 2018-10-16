using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlg3
{
    public abstract class Base
    {
        private string _nome;
        private string _cpf;
        private string _rg;
        private string _telefone;

        public string nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = nome;
            }
        }

        public string cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = cpf;
            }
        }

        public string rg
        {
            get
            {
                return _rg;
            }
            set
            {
                _rg = rg;
            }
        }

        public string telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = telefone;
            }
        }

    }
}
