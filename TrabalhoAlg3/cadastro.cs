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
            // TODO: esta linha de código carrega dados na tabela 'bANCOFABIODataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            //this.cLIENTESTableAdapter.Fill(this.bANCOFABIODataSet.CLIENTES);


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
            PnlVisualisa.Visible = true;
            PnlArquivo.Visible = false;

        }

        private void Cursos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexão Conect = new Conexão();
                Conect.SalvarCadastro(TxtNome.Text, TxtCpf.Text, TxtRg.Text, TxtTelefone.Text);
                MessageBox.Show("cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw;
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
                //throw;
            }


        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Conexão Conectar = new Conexão();
            try
            {
                Conectar.Cancelar(Txt_codigo_cancelar.Text, TXT_Cpf_Cancelar.Text);
                MessageBox.Show("cancelada com sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("impossivel cancelar Dados não existem");
                //throw;
            }
        }

        private void GridCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid cursos
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
            PnlArquivo.Visible = true;
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
    }
}
