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
        private int _CargaHoraria;

        public string disciplina
        {
            get
            {
                return _mDisciplina;
            }
            set
            {
                _mDisciplina = value;
            }
        }
        public int CargaHoraria
        {
            get
            {
                return _CargaHoraria;
            }
            set
            {
                _CargaHoraria = value;
            }
        }
    }
}
