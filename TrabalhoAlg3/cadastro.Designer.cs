namespace TrabalhoAlg3
{
    partial class cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.bANCOFABIODataSet = new TrabalhoAlg3.BANCOFABIODataSet();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESTableAdapter = new TrabalhoAlg3.BANCOFABIODataSetTableAdapters.CLIENTESTableAdapter();
            this.tableAdapterManager = new TrabalhoAlg3.BANCOFABIODataSetTableAdapters.TableAdapterManager();
            this.btnMat = new System.Windows.Forms.Button();
            this.btnCurDis = new System.Windows.Forms.Button();
            this.btnCadMat = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.PnlCadastrar = new System.Windows.Forms.Panel();
            this.Enviar = new System.Windows.Forms.Button();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.Cpf = new System.Windows.Forms.Label();
            this.RG = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.PnlCursos = new System.Windows.Forms.Panel();
            this.GridCurso = new System.Windows.Forms.DataGridView();
            this.labelCursos = new System.Windows.Forms.Label();
            this.bANCOFABIODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PnlInicial = new System.Windows.Forms.Panel();
            this.lblInicial = new System.Windows.Forms.Label();
            this.PnlVisualisa = new System.Windows.Forms.Panel();
            this.GridConsultas = new System.Windows.Forms.DataGridView();
            this.LblConsulta = new System.Windows.Forms.Label();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlCMatricula = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_codigo_cancelar = new System.Windows.Forms.TextBox();
            this.TXT_Cpf_Cancelar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlMatricula = new System.Windows.Forms.Panel();
            this.Btn_Matricula = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_CODIGOM = new System.Windows.Forms.TextBox();
            this.TXT_CPFM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnArquivo = new System.Windows.Forms.Button();
            this.PnlArquivo = new System.Windows.Forms.Panel();
            this.TxTLeitura = new System.Windows.Forms.TextBox();
            this.BtnLer = new System.Windows.Forms.Button();
            this.TxtEscrita = new System.Windows.Forms.TextBox();
            this.BtnEscrita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bANCOFABIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            this.PnlCadastrar.SuspendLayout();
            this.PnlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCOFABIODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).BeginInit();
            this.PnlInicial.SuspendLayout();
            this.PnlVisualisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultas)).BeginInit();
            this.PnlCMatricula.SuspendLayout();
            this.PnlMatricula.SuspendLayout();
            this.PnlArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bANCOFABIODataSet
            // 
            this.bANCOFABIODataSet.DataSetName = "BANCOFABIODataSet";
            this.bANCOFABIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.bANCOFABIODataSet;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = this.cLIENTESTableAdapter;
            this.tableAdapterManager.UpdateOrder = TrabalhoAlg3.BANCOFABIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnMat
            // 
            this.btnMat.Location = new System.Drawing.Point(251, 263);
            this.btnMat.Name = "btnMat";
            this.btnMat.Size = new System.Drawing.Size(75, 23);
            this.btnMat.TabIndex = 0;
            this.btnMat.Text = "Matricula";
            this.btnMat.UseVisualStyleBackColor = true;
            this.btnMat.Click += new System.EventHandler(this.btnMat_Click);
            // 
            // btnCurDis
            // 
            this.btnCurDis.Location = new System.Drawing.Point(133, 263);
            this.btnCurDis.Name = "btnCurDis";
            this.btnCurDis.Size = new System.Drawing.Size(75, 23);
            this.btnCurDis.TabIndex = 1;
            this.btnCurDis.Text = "Cursos Disp.";
            this.btnCurDis.UseVisualStyleBackColor = true;
            this.btnCurDis.Click += new System.EventHandler(this.btnCurDis_Click);
            // 
            // btnCadMat
            // 
            this.btnCadMat.Location = new System.Drawing.Point(386, 263);
            this.btnCadMat.Name = "btnCadMat";
            this.btnCadMat.Size = new System.Drawing.Size(75, 23);
            this.btnCadMat.TabIndex = 2;
            this.btnCadMat.Text = "C.Matricula";
            this.btnCadMat.UseVisualStyleBackColor = true;
            this.btnCadMat.Click += new System.EventHandler(this.btnCadMat_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(17, 263);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 3;
            this.btnCad.Text = "Cadastro";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // PnlCadastrar
            // 
            this.PnlCadastrar.Controls.Add(this.Enviar);
            this.PnlCadastrar.Controls.Add(this.TxtCpf);
            this.PnlCadastrar.Controls.Add(this.TxtRg);
            this.PnlCadastrar.Controls.Add(this.TxtTelefone);
            this.PnlCadastrar.Controls.Add(this.Cpf);
            this.PnlCadastrar.Controls.Add(this.RG);
            this.PnlCadastrar.Controls.Add(this.Telefone);
            this.PnlCadastrar.Controls.Add(this.nome);
            this.PnlCadastrar.Controls.Add(this.label1);
            this.PnlCadastrar.Controls.Add(this.TxtNome);
            this.PnlCadastrar.Location = new System.Drawing.Point(23, 12);
            this.PnlCadastrar.Name = "PnlCadastrar";
            this.PnlCadastrar.Size = new System.Drawing.Size(757, 238);
            this.PnlCadastrar.TabIndex = 4;
            this.PnlCadastrar.Visible = false;
            this.PnlCadastrar.Paint += new System.Windows.Forms.PaintEventHandler(this.Cadastrar_Paint);
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(38, 187);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 9;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(179, 80);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(100, 20);
            this.TxtCpf.TabIndex = 8;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(179, 113);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(100, 20);
            this.TxtRg.TabIndex = 7;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(179, 142);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefone.TabIndex = 6;
            // 
            // Cpf
            // 
            this.Cpf.AutoSize = true;
            this.Cpf.Location = new System.Drawing.Point(35, 80);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(23, 13);
            this.Cpf.TabIndex = 5;
            this.Cpf.Text = "Cpf";
            // 
            // RG
            // 
            this.RG.AutoSize = true;
            this.RG.Location = new System.Drawing.Point(35, 113);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(23, 13);
            this.RG.TabIndex = 4;
            this.RG.Text = "RG";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(35, 142);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 3;
            this.Telefone.Text = "Telefone";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(35, 45);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preencha os campos com  as informações do cliente e clique em  \"enviar\" para efet" +
    "uar o cadastro";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(179, 45);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(670, 263);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // PnlCursos
            // 
            this.PnlCursos.Controls.Add(this.GridCurso);
            this.PnlCursos.Controls.Add(this.labelCursos);
            this.PnlCursos.Location = new System.Drawing.Point(36, 12);
            this.PnlCursos.Name = "PnlCursos";
            this.PnlCursos.Size = new System.Drawing.Size(757, 238);
            this.PnlCursos.TabIndex = 10;
            this.PnlCursos.Visible = false;
            this.PnlCursos.Paint += new System.Windows.Forms.PaintEventHandler(this.Cursos_Paint);
            // 
            // GridCurso
            // 
            this.GridCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCurso.Location = new System.Drawing.Point(8, 45);
            this.GridCurso.Name = "GridCurso";
            this.GridCurso.Size = new System.Drawing.Size(563, 110);
            this.GridCurso.TabIndex = 2;
            this.GridCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCurso_CellContentClick);
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelCursos.Location = new System.Drawing.Point(4, 9);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(347, 20);
            this.labelCursos.TabIndex = 1;
            this.labelCursos.Text = "Abaixo segue a relação de cursos existentes.";
            // 
            // bANCOFABIODataSetBindingSource
            // 
            this.bANCOFABIODataSetBindingSource.DataSource = this.bANCOFABIODataSet;
            this.bANCOFABIODataSetBindingSource.Position = 0;
            // 
            // cLIENTESBindingSource1
            // 
            this.cLIENTESBindingSource1.DataMember = "CLIENTES";
            this.cLIENTESBindingSource1.DataSource = this.bANCOFABIODataSetBindingSource;
            // 
            // PnlInicial
            // 
            this.PnlInicial.Controls.Add(this.lblInicial);
            this.PnlInicial.Location = new System.Drawing.Point(39, 12);
            this.PnlInicial.Name = "PnlInicial";
            this.PnlInicial.Size = new System.Drawing.Size(757, 238);
            this.PnlInicial.TabIndex = 3;
            // 
            // lblInicial
            // 
            this.lblInicial.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.Location = new System.Drawing.Point(64, 80);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(623, 61);
            this.lblInicial.TabIndex = 0;
            this.lblInicial.Text = "Selecione Abaixo a Opção Desejada.";
            // 
            // PnlVisualisa
            // 
            this.PnlVisualisa.Controls.Add(this.GridConsultas);
            this.PnlVisualisa.Controls.Add(this.LblConsulta);
            this.PnlVisualisa.Controls.Add(this.BtnConsulta);
            this.PnlVisualisa.Controls.Add(this.textBox2);
            this.PnlVisualisa.Controls.Add(this.label2);
            this.PnlVisualisa.Location = new System.Drawing.Point(12, 19);
            this.PnlVisualisa.Name = "PnlVisualisa";
            this.PnlVisualisa.Size = new System.Drawing.Size(760, 238);
            this.PnlVisualisa.TabIndex = 11;
            this.PnlVisualisa.Visible = false;
            // 
            // GridConsultas
            // 
            this.GridConsultas.AllowUserToOrderColumns = true;
            this.GridConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridConsultas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsultas.Location = new System.Drawing.Point(215, 49);
            this.GridConsultas.MinimumSize = new System.Drawing.Size(0, 100);
            this.GridConsultas.Name = "GridConsultas";
            this.GridConsultas.Size = new System.Drawing.Size(443, 100);
            this.GridConsultas.TabIndex = 5;
            this.GridConsultas.Visible = false;
            // 
            // LblConsulta
            // 
            this.LblConsulta.AutoSize = true;
            this.LblConsulta.Location = new System.Drawing.Point(212, 33);
            this.LblConsulta.Name = "LblConsulta";
            this.LblConsulta.Size = new System.Drawing.Size(102, 13);
            this.LblConsulta.TabIndex = 4;
            this.LblConsulta.Text = "Cursos Matriculados";
            this.LblConsulta.Click += new System.EventHandler(this.LblConsulta_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(14, 90);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta.TabIndex = 2;
            this.BtnConsulta.Text = "Consultar.";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o Cpf para consulta.";
            // 
            // PnlCMatricula
            // 
            this.PnlCMatricula.Controls.Add(this.Btn_Cancelar);
            this.PnlCMatricula.Controls.Add(this.label7);
            this.PnlCMatricula.Controls.Add(this.label8);
            this.PnlCMatricula.Controls.Add(this.Txt_codigo_cancelar);
            this.PnlCMatricula.Controls.Add(this.TXT_Cpf_Cancelar);
            this.PnlCMatricula.Controls.Add(this.label4);
            this.PnlCMatricula.Location = new System.Drawing.Point(17, 12);
            this.PnlCMatricula.Name = "PnlCMatricula";
            this.PnlCMatricula.Size = new System.Drawing.Size(770, 245);
            this.PnlCMatricula.TabIndex = 12;
            this.PnlCMatricula.Visible = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(70, 169);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 41);
            this.Btn_Cancelar.TabIndex = 10;
            this.Btn_Cancelar.Text = "Cancelar a Matricula.";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "CPF.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Código.";
            // 
            // Txt_codigo_cancelar
            // 
            this.Txt_codigo_cancelar.Location = new System.Drawing.Point(70, 121);
            this.Txt_codigo_cancelar.Name = "Txt_codigo_cancelar";
            this.Txt_codigo_cancelar.Size = new System.Drawing.Size(146, 20);
            this.Txt_codigo_cancelar.TabIndex = 7;
            // 
            // TXT_Cpf_Cancelar
            // 
            this.TXT_Cpf_Cancelar.Location = new System.Drawing.Point(70, 55);
            this.TXT_Cpf_Cancelar.Name = "TXT_Cpf_Cancelar";
            this.TXT_Cpf_Cancelar.Size = new System.Drawing.Size(146, 20);
            this.TXT_Cpf_Cancelar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cancelamento";
            // 
            // PnlMatricula
            // 
            this.PnlMatricula.Controls.Add(this.Btn_Matricula);
            this.PnlMatricula.Controls.Add(this.label6);
            this.PnlMatricula.Controls.Add(this.label5);
            this.PnlMatricula.Controls.Add(this.TXT_CODIGOM);
            this.PnlMatricula.Controls.Add(this.TXT_CPFM);
            this.PnlMatricula.Controls.Add(this.label3);
            this.PnlMatricula.Location = new System.Drawing.Point(8, 6);
            this.PnlMatricula.Name = "PnlMatricula";
            this.PnlMatricula.Size = new System.Drawing.Size(761, 248);
            this.PnlMatricula.TabIndex = 13;
            this.PnlMatricula.Visible = false;
            // 
            // Btn_Matricula
            // 
            this.Btn_Matricula.Location = new System.Drawing.Point(76, 172);
            this.Btn_Matricula.Name = "Btn_Matricula";
            this.Btn_Matricula.Size = new System.Drawing.Size(75, 23);
            this.Btn_Matricula.TabIndex = 5;
            this.Btn_Matricula.Text = "Matricular.";
            this.Btn_Matricula.UseVisualStyleBackColor = true;
            this.Btn_Matricula.Click += new System.EventHandler(this.Btn_Matricula_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CPF.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Código.";
            // 
            // TXT_CODIGOM
            // 
            this.TXT_CODIGOM.Location = new System.Drawing.Point(76, 95);
            this.TXT_CODIGOM.Name = "TXT_CODIGOM";
            this.TXT_CODIGOM.Size = new System.Drawing.Size(100, 20);
            this.TXT_CODIGOM.TabIndex = 2;
            // 
            // TXT_CPFM
            // 
            this.TXT_CPFM.Location = new System.Drawing.Point(76, 54);
            this.TXT_CPFM.Name = "TXT_CPFM";
            this.TXT_CPFM.Size = new System.Drawing.Size(100, 20);
            this.TXT_CPFM.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Digite o Cpf e o codigo do curso para efetuar a matricula.";
            // 
            // BtnArquivo
            // 
            this.BtnArquivo.Location = new System.Drawing.Point(532, 263);
            this.BtnArquivo.Name = "BtnArquivo";
            this.BtnArquivo.Size = new System.Drawing.Size(75, 23);
            this.BtnArquivo.TabIndex = 14;
            this.BtnArquivo.Text = "Arquivo";
            this.BtnArquivo.UseVisualStyleBackColor = true;
            this.BtnArquivo.Click += new System.EventHandler(this.BtnArquivo_Click);
            // 
            // PnlArquivo
            // 
            this.PnlArquivo.Controls.Add(this.TxTLeitura);
            this.PnlArquivo.Controls.Add(this.BtnLer);
            this.PnlArquivo.Controls.Add(this.TxtEscrita);
            this.PnlArquivo.Controls.Add(this.BtnEscrita);
            this.PnlArquivo.Location = new System.Drawing.Point(8, 2);
            this.PnlArquivo.Name = "PnlArquivo";
            this.PnlArquivo.Size = new System.Drawing.Size(756, 248);
            this.PnlArquivo.TabIndex = 6;
            this.PnlArquivo.Visible = false;
            // 
            // TxTLeitura
            // 
            this.TxTLeitura.Location = new System.Drawing.Point(416, 42);
            this.TxTLeitura.Multiline = true;
            this.TxTLeitura.Name = "TxTLeitura";
            this.TxTLeitura.ReadOnly = true;
            this.TxTLeitura.Size = new System.Drawing.Size(263, 149);
            this.TxTLeitura.TabIndex = 3;
            this.TxTLeitura.TextChanged += new System.EventHandler(this.TxTLeitura_TextChanged);
            // 
            // BtnLer
            // 
            this.BtnLer.Location = new System.Drawing.Point(524, 205);
            this.BtnLer.Name = "BtnLer";
            this.BtnLer.Size = new System.Drawing.Size(75, 23);
            this.BtnLer.TabIndex = 2;
            this.BtnLer.Text = "Ler";
            this.BtnLer.UseVisualStyleBackColor = true;
            this.BtnLer.Click += new System.EventHandler(this.BtnLer_Click);
            // 
            // TxtEscrita
            // 
            this.TxtEscrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxtEscrita.Location = new System.Drawing.Point(53, 58);
            this.TxtEscrita.Name = "TxtEscrita";
            this.TxtEscrita.Size = new System.Drawing.Size(196, 26);
            this.TxtEscrita.TabIndex = 1;
            // 
            // BtnEscrita
            // 
            this.BtnEscrita.Location = new System.Drawing.Point(111, 197);
            this.BtnEscrita.Name = "BtnEscrita";
            this.BtnEscrita.Size = new System.Drawing.Size(75, 23);
            this.BtnEscrita.TabIndex = 0;
            this.BtnEscrita.Text = "Escrever";
            this.BtnEscrita.UseVisualStyleBackColor = true;
            this.BtnEscrita.Click += new System.EventHandler(this.BtnEscrita_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 290);
            this.Controls.Add(this.PnlArquivo);
            this.Controls.Add(this.BtnArquivo);
            this.Controls.Add(this.PnlVisualisa);
            this.Controls.Add(this.PnlMatricula);
            this.Controls.Add(this.PnlCMatricula);
            this.Controls.Add(this.PnlCadastrar);
            this.Controls.Add(this.PnlCursos);
            this.Controls.Add(this.PnlInicial);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnCadMat);
            this.Controls.Add(this.btnCurDis);
            this.Controls.Add(this.btnMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastro";
            this.Text = "Cadastro De Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bANCOFABIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            this.PnlCadastrar.ResumeLayout(false);
            this.PnlCadastrar.PerformLayout();
            this.PnlCursos.ResumeLayout(false);
            this.PnlCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCOFABIODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).EndInit();
            this.PnlInicial.ResumeLayout(false);
            this.PnlVisualisa.ResumeLayout(false);
            this.PnlVisualisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultas)).EndInit();
            this.PnlCMatricula.ResumeLayout(false);
            this.PnlCMatricula.PerformLayout();
            this.PnlMatricula.ResumeLayout(false);
            this.PnlMatricula.PerformLayout();
            this.PnlArquivo.ResumeLayout(false);
            this.PnlArquivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BANCOFABIODataSet bANCOFABIODataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private BANCOFABIODataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private BANCOFABIODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnMat;
        private System.Windows.Forms.Button btnCurDis;
        private System.Windows.Forms.Button btnCadMat;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Panel PnlCadastrar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label Cpf;
        private System.Windows.Forms.Label RG;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Panel PnlCursos;
        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.DataGridView GridCurso;
        private System.Windows.Forms.BindingSource bANCOFABIODataSetBindingSource;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource1;
        private System.Windows.Forms.Panel PnlInicial;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Panel PnlVisualisa;
        private System.Windows.Forms.Panel PnlCMatricula;
        private System.Windows.Forms.Panel PnlMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridConsultas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_CODIGOM;
        private System.Windows.Forms.TextBox TXT_CPFM;
        private System.Windows.Forms.Button Btn_Matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_codigo_cancelar;
        private System.Windows.Forms.TextBox TXT_Cpf_Cancelar;
        private System.Windows.Forms.Button BtnArquivo;
        private System.Windows.Forms.Panel PnlArquivo;
        private System.Windows.Forms.TextBox TxtEscrita;
        private System.Windows.Forms.Button BtnEscrita;
        private System.Windows.Forms.Button BtnLer;
        private System.Windows.Forms.TextBox TxTLeitura;
    }
}

