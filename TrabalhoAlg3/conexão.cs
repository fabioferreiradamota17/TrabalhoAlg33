using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace TrabalhoAlg3//carlos
{
    class Conexão

    {
        SqlConnection sqlcon = null;
        //Banco Fabio -> 
        private string StrCon = "Data Source=DESKTOP-BDHQ8NC\\FABIO;" + "Initial Catalog=BANCOFABIO;" + "User id=sa;" + "Password=612914;";
        //private string StrCon = "Data Source=DESKTOP-6N7BJMH;" + "Initial Catalog=alg3;" + "User id=sa;" + "Password=vssql;";

        string StrSql = string.Empty;

        public void SalvarCadastro(string Nome, string Cpf, string Rg, string Telefone)
        {
            StrSql = "insert into cliente (Nome_cliente,Cpf,Rg,Telefone) values (@Nome,@Cpf,@Rg,@Telefone)";
            sqlcon = new SqlConnection(StrCon);
            SqlCommand Comando = new SqlCommand(StrSql, sqlcon);
            Comando.Parameters.Add("@nome", Nome);
            Comando.Parameters.Add("@Cpf", Cpf);
            Comando.Parameters.Add("@Rg", Rg);
            Comando.Parameters.Add("@Telefone", Telefone);
            //teste git

            try
            {
                sqlcon.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }




        }
        public DataTable Consulta(string Cpf)
        {
            StrSql = "Select id_curso as Código, Nome_Curso as curso,Nome_professor as Professor, Carga_horaria as CH from CursosMatriculados where cpf=@cpf";
            sqlcon = new SqlConnection(StrCon);
            SqlCommand Comando = new SqlCommand(StrSql, sqlcon);
            Comando.Parameters.Add("@Cpf", Cpf);
            try
            {
                sqlcon.Open();
                DataTable tabela = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                adaptador.Fill(tabela);
                //Comando.ExecuteNonQuery();
                sqlcon.Dispose();
                sqlcon.Close();
                return tabela;
                
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable Cursos()
        {
            StrSql = "select * from curso";
            sqlcon = new SqlConnection(StrCon);
            SqlCommand Comando = new SqlCommand(StrSql, sqlcon);
            try
            {
                sqlcon.Open();
                DataTable tabela = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                adaptador.Fill(tabela);
                //Comando.ExecuteNonQuery();
                sqlcon.Dispose();
                sqlcon.Close();
                return tabela;


            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Cancelar(string id_curso, string Cpf)
        {
            StrSql = "delete CursosMatriculados where Id_Curso = @id_Curso and cpf=@cpf";
            sqlcon = new SqlConnection(StrCon);
            SqlCommand Comando = new SqlCommand(StrSql, sqlcon);
            Comando.Parameters.Add("@id_Curso", int.Parse(id_curso));
            Comando.Parameters.Add("@Cpf", Cpf);

            try
            {
                sqlcon.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }




        }

        public void matricular(string cpf, string codigo)
        {
            StrSql = "insert into CursosMatriculados(nome_curso,nome_professor,Carga_Horaria,Cpf,Id_Curso) values ((select Nome_Curso from Curso where Id_Curso= @Id_Curso),(select Nome_Professor from Curso where Id_Curso= @Id_Curso),(select Carga_Horaria from Curso where Id_Curso= @Id_Curso), @cpf,@id_curso)";
            sqlcon = new SqlConnection(StrCon);
            SqlCommand Comando = new SqlCommand(StrSql, sqlcon);
            Comando.Parameters.Add("@id_Curso", int.Parse(codigo));
            Comando.Parameters.Add("@Cpf", cpf);

            try
            {
                sqlcon.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
