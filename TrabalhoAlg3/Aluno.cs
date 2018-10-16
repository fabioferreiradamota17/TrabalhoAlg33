using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlg3
{
    class Aluno : Base
    {
        private string _curso;
        private string _matricula;

        public string curso
        {
            get
            {
                return _curso;
            }
            set
            {
                _curso = curso;
            }
        }

        public string matricula
        {
            get
            {
                return _matricula;
            }
            set
            {
                _matricula = matricula;
            }
        }
    }
}
