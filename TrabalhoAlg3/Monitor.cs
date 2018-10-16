using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlg3
{
    class Monitor : Aluno
    {
        private string _mDisciplina;

        public string disciplina
        {
            get
            {
                return _mDisciplina;
            }
            set
            {
                _mDisciplina = disciplina;
            }
        }
    }
}
