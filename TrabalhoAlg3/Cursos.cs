using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlg3
{
    public class Cursos
    {
        private string _nome;
        private int _carga;
        private int _vagas;
        private int _professor;
        private int _id_curso;


        public string nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public int carga
        {
            get
            {
                return _carga;
            }
            set
            {
                _carga = value;
            }
        }
        public int vagas
        {
            get
            {
                return _vagas;
            }
            set
            {
                _vagas = value;
            }
        }
        public int professor
        {
            get
            {
                return _professor;
            }
            set
            {
                _professor = value;
            }
        }
        public int Id_Curso
        {
            get
            {
                return _id_curso;
            }
            set
            {
                _id_curso = value;
            }
        }
    }

}
