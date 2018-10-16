using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAlg3
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadMat_Click(object sender, EventArgs e)
        {
            PnlInicial.Visible = false;
            PnlCursos.Visible = false;
            PnlVisualisa.Visible = false;
            PnlMatricula.Visible = false;
            PnlInicial.Visible = false;
            PnlCadastrar.Visible = false;
            PnlCMatricula.Visible = true;
            Pnl_Atualiza.Visible = false;
            Pnl_Monitor.Visible = false;
            PnlArquivo.Visible = false;

        }

        private void btnCad_Click(object sender, EventArgs e)//cadastro
        {
            PnlInicial.Visible = false;
            PnlCursos.Visible = false;
            PnlVisualisa.Visible = false;
            PnlMatricula.Visible = false;
            PnlCMatricula.Visible = false;
            PnlInicial.Visible = false;
            PnlCadastrar.Visible = true;
            Pnl_Atualiza.Visible = false;
            Pnl_Monitor.Visible = false;
            PnlArquivo.Visible = false;


        }

        private void btnCurDis_Click(object sender, EventArgs e)//cursos
        {
            PnlInicial.Visible = false;
            PnlVisualisa.Visible = false;
            PnlMatricula.Visible = false;
            PnlCMatricula.Visible = false;
            PnlInicial.Visible = false;
            PnlCadastrar.Visible = false;
            PnlCursos.Visible = true;
            Pnl_Atualiza.Visible = false;
            Pnl_Monitor.Visible = false;
            PnlArquivo.Visible = false;

            Conexão conectar = new Conexão();
            DataTable tabela = new DataTable();
            try
            {
                tabela = conectar.Cursos();
                GridCurso.DataSource = (tabela);
                GridCurso.Visible = true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void BtnTelefone_Click(object sender, EventArgs e)
        {
            PnlInicial.Visible = false;
            PnlCursos.Visible = false;
            PnlMatricula.Visible = false;
            PnlCMatricula.Visible = false;
            PnlInicial.Visible = false;
            PnlCadastrar.Visible = false;
            PnlVisualisa.Visible = false;
            PnlArquivo.Visible = false;
            Pnl_Monitor.Visible = false;
            Pnl_Atualiza.Visible = true;
        }

        private void Btn_Cad_Monitor_Click(object sender, EventArgs e)
        {
            PnlInicial.Visible = false;
            PnlCursos.Visible = false;
            PnlMatricula.Visible = false;
            PnlCMatricula.Visible = false;
            PnlInicial.Visible = false;
            PnlCadastrar.Visible = false;
            PnlVisualisa.Visible = false;
            PnlArquivo.Visible = false;
            Pnl_Atualiza.Visible = false;
            Pnl_Monitor.Visible = true;

        }

        private void Cadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            PnlInicial.Visible = false;
            PnlCursos.Visible = false;
            PnlVisualisa.Visible = false;
            PnlCMatricula.Visible = false;
            PnlInicial.Visible = false;
            PnlCadastrar.Visible = false;
            PnlMatricula.Visible = true;
            Pnl_Atualiza.Visible = false;
            Pnl_Monitor.Visible = false;
            PnlArquivo.Visible = false;

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            PnlInicial.Visible = false;
            PnlCursos.Visible = false;
            PnlMatricula.Visible = false;
            PnlCMatricula.Visible = false;
            PnlInicial.Visible = false;
            PnlCadastrar.Visible = false;
            Pnl_Atualiza.Visible = false;
            PnlVisualisa.Visible = true;
            Pnl_Monitor.Visible = false;
            PnlArquivo.Visible = false;

        }
        private void BtnArquivo_Click(object sender, EventArgs e)
        {
            PnlInicial.Visible = false;
            PnlCursos.Visible = false;
            PnlMatricula.Visible = false;
            PnlCMatricula.Visible = false;
            PnlInicial.Visible = false;
            PnlCadastrar.Visible = false;
            PnlVisualisa.Visible = false;
            Pnl_Atualiza.Visible = false;
            Pnl_Monitor.Visible = false;
            PnlArquivo.Visible = true;
        }


        private void Cursos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Aluno C_Aluno = new Aluno();
            C_Aluno.nome = TxtNome.Text;
            C_Aluno.cpf = TxtCpf.Text;
            C_Aluno.rg = TxtRg.Text;
            C_Aluno.telefone = TxtTelefone.Text;
            if (C_Aluno.nome != "" && C_Aluno.cpf != "" && C_Aluno.rg != "" && C_Aluno.telefone != "")
            {

                try
                {
                    Conexão Conect = new Conexão();

                    Conect.SalvarCadastro(C_Aluno);
                    MessageBox.Show("cadastrado com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("impossivel cadastrar");
                }
            }
            else
            {
                MessageBox.Show("Erro,todos os campos são obrigatorios!");
            }
        }
        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            Conexão conectar = new Conexão();
            try
            {
                DataTable tabela = new DataTable();
                tabela = conectar.Consulta(textBox2.Text);
                if (tabela.Rows.Count > 0)
                {
                    GridConsultas.DataSource = (tabela);
                    GridConsultas.Visible = true;
                }
                else
                {
                    MessageBox.Show("não existem cursos matriculados para esse cpf.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void GridConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void LblConsulta_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Btn_Matricula_Click(object sender, EventArgs e)
        {
            try
            {
                Conexão Conectar = new Conexão();
                Conectar.matricular(TXT_CPFM.Text, TXT_CODIGOM.Text);
                MessageBox.Show("matricula Comcluida.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("não foi possivel matricular verifique os dados.");
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Conexão Conectar = new Conexão();
            Cursos curso = new Cursos();
            Aluno aluno = new Aluno();
            try
            {
                curso.Id_Curso = Convert.ToInt32(Txt_codigo_cancelar.Text);
                aluno.cpf = TXT_Cpf_Cancelar.Text;
                Conectar.Cancelar(curso, aluno);
                MessageBox.Show("cancelada com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("impossivel cancelar Dados não existem");
            }
        }
        private void GridCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void BtnEscrita_Click(object sender, EventArgs e)
        {
            Escrita escrever = new Escrita();
            escrever.Escrever(TxtEscrita.Text);
        }
        private void BtnLer_Click(object sender, EventArgs e)
        {
            string Arquivo = "O arquivo esta vazio";
            Leitura ler = new Leitura();
            string arquivo2 = ler.Ler();
            if (arquivo2.Length == 0)
            {
                TxTLeitura.Text = Arquivo;
            }
            else
            {
                TxTLeitura.Text = arquivo2;
            }
        }
        private void TxTLeitura_TextChanged(object sender, EventArgs e)
        {
        }
        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            Aluno alunos = new Aluno();
            alunos.cpf = Txt_Up_Cpf.Text;
            alunos.telefone = Txt_Up_Telefone.Text;
            if (alunos.cpf != "" && alunos.telefone != "")
            {
                try
                {
                    Conexão Conectar = new Conexão();
                    Conectar.Atualizar_Telefone(alunos);
                    MessageBox.Show("Telefone Atualizado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("não foi possivel atualizar verifique os dados.");
                }
            }
            else
            {
                MessageBox.Show("preenchimento dos campos é obrigatorio");
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {
        }
        private void Btn_Cadastro_Monitor_Click(object sender, EventArgs e)
        {
            try
            {
                Monitor Cmonitor = new Monitor();
                Conexão conect = new Conexão();
                Cmonitor.CargaHoraria = Convert.ToInt32(Txt_Monitor_Cargah.Text);
                try
                {
                    Cmonitor.cpf = Txt_Monitor_Cpf.Text;
                    Cmonitor.rg = Txt_monitor_Rg.Text;
                    Cmonitor.telefone = TxT_Monitor_Telefone.Text;
                    Cmonitor.disciplina = Txt_Monitor_Diciplina.Text;
                    Cmonitor.nome = Txt_Monitor_Nome.Text;
                    if (Cmonitor.cpf != "" && Cmonitor.rg != "" && Cmonitor.telefone != "" && Cmonitor.disciplina != "" && Cmonitor.CargaHoraria != 0 && Cmonitor.nome != "")
                    {
                        conect.Cadastrar_Monitor(Cmonitor);
                        MessageBox.Show("Cadastrado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("preencha todos os campos.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("preencha todos os campos corretamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("preencha os campos corretamente.");
            }
        }
    }
}
