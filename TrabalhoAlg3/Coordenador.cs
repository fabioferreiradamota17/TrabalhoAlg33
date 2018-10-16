using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlg3
{
    public class Coordenador : Professor
    {
        private string _professor;
        private string _curso;

        public string professor
        {
            get
            {
                return _professor;
            }
            set
            {
                _professor = professor;
            }
        }

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
    }
}
