namespace COEServer.PlayersVIP.Interface
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.btnCancelarSair = new System.Windows.Forms.Button();
            this.tabCadastroUsuarioSistemaSistema = new System.Windows.Forms.TabPage();
            this.gridUsuariosSistema = new System.Windows.Forms.DataGridView();
            this.colIDUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCadastroUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAvisoNaoAdministrador = new System.Windows.Forms.Label();
            this.grpUsuariosSistema = new System.Windows.Forms.GroupBox();
            this.btnSalvarAlteracaoUsuario = new System.Windows.Forms.Button();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnCancelarAlteracaoUsuario = new System.Windows.Forms.Button();
            this.btnCancelarSalvarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.grpNivelAcessoUsuario = new System.Windows.Forms.GroupBox();
            this.rdbNivelAcessoUsuarioAdministrador = new System.Windows.Forms.RadioButton();
            this.rdbNivelAcessoUsuarioLeitura = new System.Windows.Forms.RadioButton();
            this.txtUsuarioSenhaConfirmacao = new System.Windows.Forms.TextBox();
            this.lblUsuarioSenhaConfirmacao = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.txtUsuarioSenha = new System.Windows.Forms.TextBox();
            this.lblUsuarioSenha = new System.Windows.Forms.Label();
            this.txtUsuarioNome = new System.Windows.Forms.TextBox();
            this.lblUsuarioNome = new System.Windows.Forms.Label();
            this.tabRegPlayersVipConsulta = new System.Windows.Forms.TabPage();
            this.gridBuscaRegistroFiltro = new System.Windows.Forms.DataGridView();
            this.colBuscarIDPlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuscarNomePlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuscarNickPlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuscarDataCadPlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuscarAtivoPlayerVip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBuscarAdminPlayerVip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBuscarQtdDiasPlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBuscaDadosPlayersVip = new System.Windows.Forms.GroupBox();
            this.btnBuscaPlayersVip = new System.Windows.Forms.Button();
            this.lblBuscaDataCadastroPlayerVipFinal = new System.Windows.Forms.Label();
            this.grpBuscaPlayerVipAdmServer = new System.Windows.Forms.GroupBox();
            this.rdbBuscaPlayerVipEhAdminNao = new System.Windows.Forms.RadioButton();
            this.rdbBuscaPlayerVipEhAdminSim = new System.Windows.Forms.RadioButton();
            this.grpBuscaPlayerVipAtivo = new System.Windows.Forms.GroupBox();
            this.rdbBuscaPlayerVipAtivoNao = new System.Windows.Forms.RadioButton();
            this.rdbBuscaPlayerVipAtivoSim = new System.Windows.Forms.RadioButton();
            this.dtpBuscaDataCadastroPlayerVipFinal = new System.Windows.Forms.DateTimePicker();
            this.lblBuscaDataCadastroPlayerVipInicial = new System.Windows.Forms.Label();
            this.lblBuscaQtdDiasPlayerVip = new System.Windows.Forms.Label();
            this.txtBuscaQtdDiasPlayerVip = new System.Windows.Forms.TextBox();
            this.dtpBuscaDataCadastroPlayerVipInicial = new System.Windows.Forms.DateTimePicker();
            this.txtBuscaNickPlayerVip = new System.Windows.Forms.TextBox();
            this.lblBuscaNickPlayerVip = new System.Windows.Forms.Label();
            this.txtBuscaNomePlayerVip = new System.Windows.Forms.TextBox();
            this.lblBuscaNomePlayerVip = new System.Windows.Forms.Label();
            this.tabRegPlayersVip = new System.Windows.Forms.TabPage();
            this.btnCarregarTodosPlayersVip = new System.Windows.Forms.Button();
            this.gridRegistroGeral = new System.Windows.Forms.DataGridView();
            this.colIDPlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomePlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNickPlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCadPlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivoPlayerVip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAdminPlayerVip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colQtdDiasPlayerVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDadosPlayersVip = new System.Windows.Forms.GroupBox();
            this.grpPlayerVipAdmServer = new System.Windows.Forms.GroupBox();
            this.rdbPlayerVipEhAdminNao = new System.Windows.Forms.RadioButton();
            this.rdbPlayerVipEhAdminSim = new System.Windows.Forms.RadioButton();
            this.grpPlayerVipAtivo = new System.Windows.Forms.GroupBox();
            this.rdbPlayerVipAtivoNao = new System.Windows.Forms.RadioButton();
            this.rdbPlayerVipAtivoSim = new System.Windows.Forms.RadioButton();
            this.grpAdminAcoes = new System.Windows.Forms.GroupBox();
            this.lblAvisoNaoAdministradorAcoesPlayersVip = new System.Windows.Forms.Label();
            this.btnSalvarNovoPlayerVip = new System.Windows.Forms.Button();
            this.btnCancelarGravarNovoPlayerVip = new System.Windows.Forms.Button();
            this.btnNovoPlayerVip = new System.Windows.Forms.Button();
            this.btnExcluirPlayerVip = new System.Windows.Forms.Button();
            this.btnEditarPlayerVip = new System.Windows.Forms.Button();
            this.txtQtdDiasPlayerVip = new System.Windows.Forms.TextBox();
            this.lblQtdDiasPlayerVip = new System.Windows.Forms.Label();
            this.lblDataCadastroPlayerVip = new System.Windows.Forms.Label();
            this.dtpDataCadastroPlayerVip = new System.Windows.Forms.DateTimePicker();
            this.txtNickPlayerVip = new System.Windows.Forms.TextBox();
            this.lblNickPlayerVip = new System.Windows.Forms.Label();
            this.txtNomePlayerVip = new System.Windows.Forms.TextBox();
            this.lblNomePlayerVip = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCadastroUsuarioSistemaSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuariosSistema)).BeginInit();
            this.grpUsuariosSistema.SuspendLayout();
            this.grpNivelAcessoUsuario.SuspendLayout();
            this.tabRegPlayersVipConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscaRegistroFiltro)).BeginInit();
            this.grpBuscaDadosPlayersVip.SuspendLayout();
            this.grpBuscaPlayerVipAdmServer.SuspendLayout();
            this.grpBuscaPlayerVipAtivo.SuspendLayout();
            this.tabRegPlayersVip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistroGeral)).BeginInit();
            this.grpDadosPlayersVip.SuspendLayout();
            this.grpPlayerVipAdmServer.SuspendLayout();
            this.grpPlayerVipAtivo.SuspendLayout();
            this.grpAdminAcoes.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.Location = new System.Drawing.Point(9, 521);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(289, 27);
            this.lblUsuarioLogado.TabIndex = 1;
            this.lblUsuarioLogado.Text = "lblUsuarioLogado";
            this.lblUsuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelarSair
            // 
            this.btnCancelarSair.Location = new System.Drawing.Point(313, 524);
            this.btnCancelarSair.Name = "btnCancelarSair";
            this.btnCancelarSair.Size = new System.Drawing.Size(98, 23);
            this.btnCancelarSair.TabIndex = 16;
            this.btnCancelarSair.Text = "Cancelar e Sair";
            this.btnCancelarSair.UseVisualStyleBackColor = true;
            this.btnCancelarSair.Click += new System.EventHandler(this.btnCancelarSair_Click);
            // 
            // tabCadastroUsuarioSistemaSistema
            // 
            this.tabCadastroUsuarioSistemaSistema.Controls.Add(this.gridUsuariosSistema);
            this.tabCadastroUsuarioSistemaSistema.Controls.Add(this.lblAvisoNaoAdministrador);
            this.tabCadastroUsuarioSistemaSistema.Controls.Add(this.grpUsuariosSistema);
            this.tabCadastroUsuarioSistemaSistema.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroUsuarioSistemaSistema.Name = "tabCadastroUsuarioSistemaSistema";
            this.tabCadastroUsuarioSistemaSistema.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastroUsuarioSistemaSistema.Size = new System.Drawing.Size(391, 484);
            this.tabCadastroUsuarioSistemaSistema.TabIndex = 2;
            this.tabCadastroUsuarioSistemaSistema.Text = "Painel do Administrador";
            this.tabCadastroUsuarioSistemaSistema.UseVisualStyleBackColor = true;
            this.tabCadastroUsuarioSistemaSistema.Enter += new System.EventHandler(this.tabCadastroUsuarioSistemaSistema_Enter);
            // 
            // gridUsuariosSistema
            // 
            this.gridUsuariosSistema.AllowUserToAddRows = false;
            this.gridUsuariosSistema.AllowUserToDeleteRows = false;
            this.gridUsuariosSistema.AllowUserToResizeRows = false;
            this.gridUsuariosSistema.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridUsuariosSistema.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUsuariosSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDUsuarioSistema,
            this.colTipoUsuarioSistema,
            this.colNomeUsuarioSistema,
            this.colLoginUsuarioSistema,
            this.colDataCadastroUsuarioSistema});
            this.gridUsuariosSistema.GridColor = System.Drawing.SystemColors.Control;
            this.gridUsuariosSistema.Location = new System.Drawing.Point(6, 185);
            this.gridUsuariosSistema.Name = "gridUsuariosSistema";
            this.gridUsuariosSistema.ReadOnly = true;
            this.gridUsuariosSistema.RowHeadersVisible = false;
            this.gridUsuariosSistema.Size = new System.Drawing.Size(379, 293);
            this.gridUsuariosSistema.TabIndex = 17;
            this.gridUsuariosSistema.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsuariosSistema_CellClick);
            // 
            // colIDUsuarioSistema
            // 
            this.colIDUsuarioSistema.HeaderText = "ID";
            this.colIDUsuarioSistema.Name = "colIDUsuarioSistema";
            this.colIDUsuarioSistema.ReadOnly = true;
            this.colIDUsuarioSistema.Visible = false;
            this.colIDUsuarioSistema.Width = 5;
            // 
            // colTipoUsuarioSistema
            // 
            this.colTipoUsuarioSistema.HeaderText = "Tipo Usuário";
            this.colTipoUsuarioSistema.Name = "colTipoUsuarioSistema";
            this.colTipoUsuarioSistema.ReadOnly = true;
            // 
            // colNomeUsuarioSistema
            // 
            this.colNomeUsuarioSistema.HeaderText = "Nome";
            this.colNomeUsuarioSistema.Name = "colNomeUsuarioSistema";
            this.colNomeUsuarioSistema.ReadOnly = true;
            this.colNomeUsuarioSistema.Width = 90;
            // 
            // colLoginUsuarioSistema
            // 
            this.colLoginUsuarioSistema.FillWeight = 120F;
            this.colLoginUsuarioSistema.HeaderText = "Login";
            this.colLoginUsuarioSistema.Name = "colLoginUsuarioSistema";
            this.colLoginUsuarioSistema.ReadOnly = true;
            this.colLoginUsuarioSistema.Width = 110;
            // 
            // colDataCadastroUsuarioSistema
            // 
            this.colDataCadastroUsuarioSistema.HeaderText = "Cadastro";
            this.colDataCadastroUsuarioSistema.Name = "colDataCadastroUsuarioSistema";
            this.colDataCadastroUsuarioSistema.ReadOnly = true;
            this.colDataCadastroUsuarioSistema.Width = 76;
            // 
            // lblAvisoNaoAdministrador
            // 
            this.lblAvisoNaoAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoNaoAdministrador.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAvisoNaoAdministrador.Location = new System.Drawing.Point(6, 198);
            this.lblAvisoNaoAdministrador.Name = "lblAvisoNaoAdministrador";
            this.lblAvisoNaoAdministrador.Size = new System.Drawing.Size(379, 44);
            this.lblAvisoNaoAdministrador.TabIndex = 11;
            this.lblAvisoNaoAdministrador.Text = "Você não possui acesso às rotinas de Usuário Administrador";
            this.lblAvisoNaoAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvisoNaoAdministrador.Visible = false;
            // 
            // grpUsuariosSistema
            // 
            this.grpUsuariosSistema.Controls.Add(this.btnSalvarAlteracaoUsuario);
            this.grpUsuariosSistema.Controls.Add(this.btnSalvarUsuario);
            this.grpUsuariosSistema.Controls.Add(this.btnExcluirUsuario);
            this.grpUsuariosSistema.Controls.Add(this.btnCancelarAlteracaoUsuario);
            this.grpUsuariosSistema.Controls.Add(this.btnCancelarSalvarUsuario);
            this.grpUsuariosSistema.Controls.Add(this.btnEditarUsuario);
            this.grpUsuariosSistema.Controls.Add(this.btnNovoUsuario);
            this.grpUsuariosSistema.Controls.Add(this.grpNivelAcessoUsuario);
            this.grpUsuariosSistema.Controls.Add(this.txtUsuarioSenhaConfirmacao);
            this.grpUsuariosSistema.Controls.Add(this.lblUsuarioSenhaConfirmacao);
            this.grpUsuariosSistema.Controls.Add(this.txtUsuarioLogin);
            this.grpUsuariosSistema.Controls.Add(this.lblUsuarioLogin);
            this.grpUsuariosSistema.Controls.Add(this.txtUsuarioSenha);
            this.grpUsuariosSistema.Controls.Add(this.lblUsuarioSenha);
            this.grpUsuariosSistema.Controls.Add(this.txtUsuarioNome);
            this.grpUsuariosSistema.Controls.Add(this.lblUsuarioNome);
            this.grpUsuariosSistema.Location = new System.Drawing.Point(6, 3);
            this.grpUsuariosSistema.Name = "grpUsuariosSistema";
            this.grpUsuariosSistema.Size = new System.Drawing.Size(379, 180);
            this.grpUsuariosSistema.TabIndex = 2;
            this.grpUsuariosSistema.TabStop = false;
            this.grpUsuariosSistema.Text = "Cadastrar Novo Usuário";
            // 
            // btnSalvarAlteracaoUsuario
            // 
            this.btnSalvarAlteracaoUsuario.Enabled = false;
            this.btnSalvarAlteracaoUsuario.Location = new System.Drawing.Point(131, 149);
            this.btnSalvarAlteracaoUsuario.Name = "btnSalvarAlteracaoUsuario";
            this.btnSalvarAlteracaoUsuario.Size = new System.Drawing.Size(58, 23);
            this.btnSalvarAlteracaoUsuario.TabIndex = 10;
            this.btnSalvarAlteracaoUsuario.Text = "Salvar";
            this.btnSalvarAlteracaoUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracaoUsuario.Visible = false;
            this.btnSalvarAlteracaoUsuario.Click += new System.EventHandler(this.btnSalvarAlteracaoUsuario_Click);
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Enabled = false;
            this.btnSalvarUsuario.Location = new System.Drawing.Point(6, 149);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(58, 23);
            this.btnSalvarUsuario.TabIndex = 10;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Visible = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Enabled = false;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(255, 149);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(118, 23);
            this.btnExcluirUsuario.TabIndex = 8;
            this.btnExcluirUsuario.Text = "Excluir Usuário";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnCancelarAlteracaoUsuario
            // 
            this.btnCancelarAlteracaoUsuario.Enabled = false;
            this.btnCancelarAlteracaoUsuario.Location = new System.Drawing.Point(191, 149);
            this.btnCancelarAlteracaoUsuario.Name = "btnCancelarAlteracaoUsuario";
            this.btnCancelarAlteracaoUsuario.Size = new System.Drawing.Size(58, 23);
            this.btnCancelarAlteracaoUsuario.TabIndex = 10;
            this.btnCancelarAlteracaoUsuario.Text = "Cancelar";
            this.btnCancelarAlteracaoUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarAlteracaoUsuario.Visible = false;
            this.btnCancelarAlteracaoUsuario.Click += new System.EventHandler(this.btnCancelarAlteracaoUsuario_Click);
            // 
            // btnCancelarSalvarUsuario
            // 
            this.btnCancelarSalvarUsuario.Enabled = false;
            this.btnCancelarSalvarUsuario.Location = new System.Drawing.Point(66, 149);
            this.btnCancelarSalvarUsuario.Name = "btnCancelarSalvarUsuario";
            this.btnCancelarSalvarUsuario.Size = new System.Drawing.Size(58, 23);
            this.btnCancelarSalvarUsuario.TabIndex = 10;
            this.btnCancelarSalvarUsuario.Text = "Cancelar";
            this.btnCancelarSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarSalvarUsuario.Visible = false;
            this.btnCancelarSalvarUsuario.Click += new System.EventHandler(this.btnCancelarSalvarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.CausesValidation = false;
            this.btnEditarUsuario.Location = new System.Drawing.Point(130, 149);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(119, 23);
            this.btnEditarUsuario.TabIndex = 7;
            this.btnEditarUsuario.Text = "Editar Usuário";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Enabled = false;
            this.btnNovoUsuario.Location = new System.Drawing.Point(6, 149);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(118, 23);
            this.btnNovoUsuario.TabIndex = 6;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // grpNivelAcessoUsuario
            // 
            this.grpNivelAcessoUsuario.Controls.Add(this.rdbNivelAcessoUsuarioAdministrador);
            this.grpNivelAcessoUsuario.Controls.Add(this.rdbNivelAcessoUsuarioLeitura);
            this.grpNivelAcessoUsuario.Enabled = false;
            this.grpNivelAcessoUsuario.Location = new System.Drawing.Point(6, 100);
            this.grpNivelAcessoUsuario.Name = "grpNivelAcessoUsuario";
            this.grpNivelAcessoUsuario.Size = new System.Drawing.Size(367, 44);
            this.grpNivelAcessoUsuario.TabIndex = 5;
            this.grpNivelAcessoUsuario.TabStop = false;
            this.grpNivelAcessoUsuario.Text = "Nível de Acesso do Usuário";
            // 
            // rdbNivelAcessoUsuarioAdministrador
            // 
            this.rdbNivelAcessoUsuarioAdministrador.AutoSize = true;
            this.rdbNivelAcessoUsuarioAdministrador.Location = new System.Drawing.Point(124, 19);
            this.rdbNivelAcessoUsuarioAdministrador.Name = "rdbNivelAcessoUsuarioAdministrador";
            this.rdbNivelAcessoUsuarioAdministrador.Size = new System.Drawing.Size(244, 17);
            this.rdbNivelAcessoUsuarioAdministrador.TabIndex = 1;
            this.rdbNivelAcessoUsuarioAdministrador.Text = "Usuário Administrador (permite alterar e excluir)";
            this.rdbNivelAcessoUsuarioAdministrador.UseVisualStyleBackColor = true;
            // 
            // rdbNivelAcessoUsuarioLeitura
            // 
            this.rdbNivelAcessoUsuarioLeitura.AutoSize = true;
            this.rdbNivelAcessoUsuarioLeitura.Checked = true;
            this.rdbNivelAcessoUsuarioLeitura.Location = new System.Drawing.Point(7, 19);
            this.rdbNivelAcessoUsuarioLeitura.Name = "rdbNivelAcessoUsuarioLeitura";
            this.rdbNivelAcessoUsuarioLeitura.Size = new System.Drawing.Size(111, 17);
            this.rdbNivelAcessoUsuarioLeitura.TabIndex = 0;
            this.rdbNivelAcessoUsuarioLeitura.TabStop = true;
            this.rdbNivelAcessoUsuarioLeitura.Text = "Usuário de Leitura";
            this.rdbNivelAcessoUsuarioLeitura.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioSenhaConfirmacao
            // 
            this.txtUsuarioSenhaConfirmacao.Enabled = false;
            this.txtUsuarioSenhaConfirmacao.Location = new System.Drawing.Point(194, 74);
            this.txtUsuarioSenhaConfirmacao.MaxLength = 16;
            this.txtUsuarioSenhaConfirmacao.Name = "txtUsuarioSenhaConfirmacao";
            this.txtUsuarioSenhaConfirmacao.PasswordChar = '*';
            this.txtUsuarioSenhaConfirmacao.Size = new System.Drawing.Size(179, 20);
            this.txtUsuarioSenhaConfirmacao.TabIndex = 4;
            // 
            // lblUsuarioSenhaConfirmacao
            // 
            this.lblUsuarioSenhaConfirmacao.AutoSize = true;
            this.lblUsuarioSenhaConfirmacao.Location = new System.Drawing.Point(193, 58);
            this.lblUsuarioSenhaConfirmacao.Name = "lblUsuarioSenhaConfirmacao";
            this.lblUsuarioSenhaConfirmacao.Size = new System.Drawing.Size(169, 13);
            this.lblUsuarioSenhaConfirmacao.TabIndex = 3;
            this.lblUsuarioSenhaConfirmacao.Text = "Confirmação da Senha do Usuário";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Enabled = false;
            this.txtUsuarioLogin.Location = new System.Drawing.Point(194, 35);
            this.txtUsuarioLogin.MaxLength = 255;
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(179, 20);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(193, 19);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(72, 13);
            this.lblUsuarioLogin.TabIndex = 2;
            this.lblUsuarioLogin.Text = "Usuário Login";
            // 
            // txtUsuarioSenha
            // 
            this.txtUsuarioSenha.Enabled = false;
            this.txtUsuarioSenha.Location = new System.Drawing.Point(6, 74);
            this.txtUsuarioSenha.MaxLength = 16;
            this.txtUsuarioSenha.Name = "txtUsuarioSenha";
            this.txtUsuarioSenha.PasswordChar = '*';
            this.txtUsuarioSenha.Size = new System.Drawing.Size(179, 20);
            this.txtUsuarioSenha.TabIndex = 1;
            // 
            // lblUsuarioSenha
            // 
            this.lblUsuarioSenha.AutoSize = true;
            this.lblUsuarioSenha.Location = new System.Drawing.Point(6, 58);
            this.lblUsuarioSenha.Name = "lblUsuarioSenha";
            this.lblUsuarioSenha.Size = new System.Drawing.Size(92, 13);
            this.lblUsuarioSenha.TabIndex = 0;
            this.lblUsuarioSenha.Text = "Senha do Usuário";
            // 
            // txtUsuarioNome
            // 
            this.txtUsuarioNome.Enabled = false;
            this.txtUsuarioNome.Location = new System.Drawing.Point(6, 35);
            this.txtUsuarioNome.MaxLength = 255;
            this.txtUsuarioNome.Name = "txtUsuarioNome";
            this.txtUsuarioNome.Size = new System.Drawing.Size(179, 20);
            this.txtUsuarioNome.TabIndex = 1;
            this.txtUsuarioNome.TextChanged += new System.EventHandler(this.txtUsuarioNome_TextChanged);
            // 
            // lblUsuarioNome
            // 
            this.lblUsuarioNome.AutoSize = true;
            this.lblUsuarioNome.Location = new System.Drawing.Point(6, 19);
            this.lblUsuarioNome.Name = "lblUsuarioNome";
            this.lblUsuarioNome.Size = new System.Drawing.Size(144, 13);
            this.lblUsuarioNome.TabIndex = 0;
            this.lblUsuarioNome.Text = "Nome do Usuário do Sistema";
            // 
            // tabRegPlayersVipConsulta
            // 
            this.tabRegPlayersVipConsulta.Controls.Add(this.gridBuscaRegistroFiltro);
            this.tabRegPlayersVipConsulta.Controls.Add(this.grpBuscaDadosPlayersVip);
            this.tabRegPlayersVipConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabRegPlayersVipConsulta.Name = "tabRegPlayersVipConsulta";
            this.tabRegPlayersVipConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegPlayersVipConsulta.Size = new System.Drawing.Size(391, 484);
            this.tabRegPlayersVipConsulta.TabIndex = 1;
            this.tabRegPlayersVipConsulta.Text = "Consulta de Players Vip";
            this.tabRegPlayersVipConsulta.UseVisualStyleBackColor = true;
            // 
            // gridBuscaRegistroFiltro
            // 
            this.gridBuscaRegistroFiltro.AllowUserToAddRows = false;
            this.gridBuscaRegistroFiltro.AllowUserToDeleteRows = false;
            this.gridBuscaRegistroFiltro.AllowUserToResizeRows = false;
            this.gridBuscaRegistroFiltro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridBuscaRegistroFiltro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridBuscaRegistroFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBuscarIDPlayerVip,
            this.colBuscarNomePlayerVip,
            this.colBuscarNickPlayerVip,
            this.colBuscarDataCadPlayerVip,
            this.colBuscarAtivoPlayerVip,
            this.colBuscarAdminPlayerVip,
            this.colBuscarQtdDiasPlayerVip});
            this.gridBuscaRegistroFiltro.GridColor = System.Drawing.SystemColors.Control;
            this.gridBuscaRegistroFiltro.Location = new System.Drawing.Point(6, 156);
            this.gridBuscaRegistroFiltro.Name = "gridBuscaRegistroFiltro";
            this.gridBuscaRegistroFiltro.ReadOnly = true;
            this.gridBuscaRegistroFiltro.RowHeadersVisible = false;
            this.gridBuscaRegistroFiltro.Size = new System.Drawing.Size(379, 322);
            this.gridBuscaRegistroFiltro.TabIndex = 16;
            // 
            // colBuscarIDPlayerVip
            // 
            this.colBuscarIDPlayerVip.HeaderText = "ID";
            this.colBuscarIDPlayerVip.Name = "colBuscarIDPlayerVip";
            this.colBuscarIDPlayerVip.ReadOnly = true;
            this.colBuscarIDPlayerVip.Visible = false;
            this.colBuscarIDPlayerVip.Width = 5;
            // 
            // colBuscarNomePlayerVip
            // 
            this.colBuscarNomePlayerVip.HeaderText = "Nome";
            this.colBuscarNomePlayerVip.Name = "colBuscarNomePlayerVip";
            this.colBuscarNomePlayerVip.ReadOnly = true;
            this.colBuscarNomePlayerVip.Width = 70;
            // 
            // colBuscarNickPlayerVip
            // 
            this.colBuscarNickPlayerVip.HeaderText = "Nick";
            this.colBuscarNickPlayerVip.Name = "colBuscarNickPlayerVip";
            this.colBuscarNickPlayerVip.ReadOnly = true;
            // 
            // colBuscarDataCadPlayerVip
            // 
            this.colBuscarDataCadPlayerVip.HeaderText = "Cadastro";
            this.colBuscarDataCadPlayerVip.Name = "colBuscarDataCadPlayerVip";
            this.colBuscarDataCadPlayerVip.ReadOnly = true;
            this.colBuscarDataCadPlayerVip.Width = 65;
            // 
            // colBuscarAtivoPlayerVip
            // 
            this.colBuscarAtivoPlayerVip.HeaderText = "Ativo?";
            this.colBuscarAtivoPlayerVip.Name = "colBuscarAtivoPlayerVip";
            this.colBuscarAtivoPlayerVip.ReadOnly = true;
            this.colBuscarAtivoPlayerVip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBuscarAtivoPlayerVip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colBuscarAtivoPlayerVip.Width = 40;
            // 
            // colBuscarAdminPlayerVip
            // 
            this.colBuscarAdminPlayerVip.HeaderText = "ADM?";
            this.colBuscarAdminPlayerVip.Name = "colBuscarAdminPlayerVip";
            this.colBuscarAdminPlayerVip.ReadOnly = true;
            this.colBuscarAdminPlayerVip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBuscarAdminPlayerVip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colBuscarAdminPlayerVip.Width = 40;
            // 
            // colBuscarQtdDiasPlayerVip
            // 
            this.colBuscarQtdDiasPlayerVip.HeaderText = "Dias Vip";
            this.colBuscarQtdDiasPlayerVip.Name = "colBuscarQtdDiasPlayerVip";
            this.colBuscarQtdDiasPlayerVip.ReadOnly = true;
            this.colBuscarQtdDiasPlayerVip.Width = 60;
            // 
            // grpBuscaDadosPlayersVip
            // 
            this.grpBuscaDadosPlayersVip.Controls.Add(this.btnBuscaPlayersVip);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.lblBuscaDataCadastroPlayerVipFinal);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.grpBuscaPlayerVipAdmServer);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.grpBuscaPlayerVipAtivo);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.dtpBuscaDataCadastroPlayerVipFinal);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.lblBuscaDataCadastroPlayerVipInicial);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.lblBuscaQtdDiasPlayerVip);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.txtBuscaQtdDiasPlayerVip);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.dtpBuscaDataCadastroPlayerVipInicial);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.txtBuscaNickPlayerVip);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.lblBuscaNickPlayerVip);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.txtBuscaNomePlayerVip);
            this.grpBuscaDadosPlayersVip.Controls.Add(this.lblBuscaNomePlayerVip);
            this.grpBuscaDadosPlayersVip.Location = new System.Drawing.Point(6, 6);
            this.grpBuscaDadosPlayersVip.Name = "grpBuscaDadosPlayersVip";
            this.grpBuscaDadosPlayersVip.Size = new System.Drawing.Size(379, 144);
            this.grpBuscaDadosPlayersVip.TabIndex = 1;
            this.grpBuscaDadosPlayersVip.TabStop = false;
            this.grpBuscaDadosPlayersVip.Text = "Dados dos Players Vip";
            // 
            // btnBuscaPlayersVip
            // 
            this.btnBuscaPlayersVip.Location = new System.Drawing.Point(201, 109);
            this.btnBuscaPlayersVip.Name = "btnBuscaPlayersVip";
            this.btnBuscaPlayersVip.Size = new System.Drawing.Size(172, 23);
            this.btnBuscaPlayersVip.TabIndex = 15;
            this.btnBuscaPlayersVip.Text = "Consultar Players Vip";
            this.btnBuscaPlayersVip.UseVisualStyleBackColor = true;
            this.btnBuscaPlayersVip.Click += new System.EventHandler(this.btnBuscaPlayersVip_Click);
            // 
            // lblBuscaDataCadastroPlayerVipFinal
            // 
            this.lblBuscaDataCadastroPlayerVipFinal.AutoSize = true;
            this.lblBuscaDataCadastroPlayerVipFinal.Location = new System.Drawing.Point(123, 58);
            this.lblBuscaDataCadastroPlayerVipFinal.Name = "lblBuscaDataCadastroPlayerVipFinal";
            this.lblBuscaDataCadastroPlayerVipFinal.Size = new System.Drawing.Size(106, 13);
            this.lblBuscaDataCadastroPlayerVipFinal.TabIndex = 14;
            this.lblBuscaDataCadastroPlayerVipFinal.Text = "Data Cadastro - Final";
            // 
            // grpBuscaPlayerVipAdmServer
            // 
            this.grpBuscaPlayerVipAdmServer.Controls.Add(this.rdbBuscaPlayerVipEhAdminNao);
            this.grpBuscaPlayerVipAdmServer.Controls.Add(this.rdbBuscaPlayerVipEhAdminSim);
            this.grpBuscaPlayerVipAdmServer.Location = new System.Drawing.Point(103, 100);
            this.grpBuscaPlayerVipAdmServer.Name = "grpBuscaPlayerVipAdmServer";
            this.grpBuscaPlayerVipAdmServer.Size = new System.Drawing.Size(91, 36);
            this.grpBuscaPlayerVipAdmServer.TabIndex = 7;
            this.grpBuscaPlayerVipAdmServer.TabStop = false;
            this.grpBuscaPlayerVipAdmServer.Text = "ADM Server";
            // 
            // rdbBuscaPlayerVipEhAdminNao
            // 
            this.rdbBuscaPlayerVipEhAdminNao.AutoSize = true;
            this.rdbBuscaPlayerVipEhAdminNao.Location = new System.Drawing.Point(46, 16);
            this.rdbBuscaPlayerVipEhAdminNao.Name = "rdbBuscaPlayerVipEhAdminNao";
            this.rdbBuscaPlayerVipEhAdminNao.Size = new System.Drawing.Size(45, 17);
            this.rdbBuscaPlayerVipEhAdminNao.TabIndex = 9;
            this.rdbBuscaPlayerVipEhAdminNao.TabStop = true;
            this.rdbBuscaPlayerVipEhAdminNao.Text = "Não";
            this.rdbBuscaPlayerVipEhAdminNao.UseVisualStyleBackColor = true;
            // 
            // rdbBuscaPlayerVipEhAdminSim
            // 
            this.rdbBuscaPlayerVipEhAdminSim.AutoSize = true;
            this.rdbBuscaPlayerVipEhAdminSim.Location = new System.Drawing.Point(6, 16);
            this.rdbBuscaPlayerVipEhAdminSim.Name = "rdbBuscaPlayerVipEhAdminSim";
            this.rdbBuscaPlayerVipEhAdminSim.Size = new System.Drawing.Size(42, 17);
            this.rdbBuscaPlayerVipEhAdminSim.TabIndex = 8;
            this.rdbBuscaPlayerVipEhAdminSim.TabStop = true;
            this.rdbBuscaPlayerVipEhAdminSim.Text = "Sim";
            this.rdbBuscaPlayerVipEhAdminSim.UseVisualStyleBackColor = true;
            // 
            // grpBuscaPlayerVipAtivo
            // 
            this.grpBuscaPlayerVipAtivo.Controls.Add(this.rdbBuscaPlayerVipAtivoNao);
            this.grpBuscaPlayerVipAtivo.Controls.Add(this.rdbBuscaPlayerVipAtivoSim);
            this.grpBuscaPlayerVipAtivo.Location = new System.Drawing.Point(6, 100);
            this.grpBuscaPlayerVipAtivo.Name = "grpBuscaPlayerVipAtivo";
            this.grpBuscaPlayerVipAtivo.Size = new System.Drawing.Size(91, 36);
            this.grpBuscaPlayerVipAtivo.TabIndex = 4;
            this.grpBuscaPlayerVipAtivo.TabStop = false;
            this.grpBuscaPlayerVipAtivo.Text = "Vip Ativo?";
            // 
            // rdbBuscaPlayerVipAtivoNao
            // 
            this.rdbBuscaPlayerVipAtivoNao.AutoSize = true;
            this.rdbBuscaPlayerVipAtivoNao.Location = new System.Drawing.Point(46, 16);
            this.rdbBuscaPlayerVipAtivoNao.Name = "rdbBuscaPlayerVipAtivoNao";
            this.rdbBuscaPlayerVipAtivoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbBuscaPlayerVipAtivoNao.TabIndex = 6;
            this.rdbBuscaPlayerVipAtivoNao.TabStop = true;
            this.rdbBuscaPlayerVipAtivoNao.Text = "Não";
            this.rdbBuscaPlayerVipAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rdbBuscaPlayerVipAtivoSim
            // 
            this.rdbBuscaPlayerVipAtivoSim.AutoSize = true;
            this.rdbBuscaPlayerVipAtivoSim.Location = new System.Drawing.Point(6, 16);
            this.rdbBuscaPlayerVipAtivoSim.Name = "rdbBuscaPlayerVipAtivoSim";
            this.rdbBuscaPlayerVipAtivoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbBuscaPlayerVipAtivoSim.TabIndex = 5;
            this.rdbBuscaPlayerVipAtivoSim.TabStop = true;
            this.rdbBuscaPlayerVipAtivoSim.Text = "Sim";
            this.rdbBuscaPlayerVipAtivoSim.UseVisualStyleBackColor = true;
            // 
            // dtpBuscaDataCadastroPlayerVipFinal
            // 
            this.dtpBuscaDataCadastroPlayerVipFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscaDataCadastroPlayerVipFinal.Location = new System.Drawing.Point(123, 74);
            this.dtpBuscaDataCadastroPlayerVipFinal.Name = "dtpBuscaDataCadastroPlayerVipFinal";
            this.dtpBuscaDataCadastroPlayerVipFinal.Size = new System.Drawing.Size(111, 20);
            this.dtpBuscaDataCadastroPlayerVipFinal.TabIndex = 13;
            // 
            // lblBuscaDataCadastroPlayerVipInicial
            // 
            this.lblBuscaDataCadastroPlayerVipInicial.AutoSize = true;
            this.lblBuscaDataCadastroPlayerVipInicial.Location = new System.Drawing.Point(6, 58);
            this.lblBuscaDataCadastroPlayerVipInicial.Name = "lblBuscaDataCadastroPlayerVipInicial";
            this.lblBuscaDataCadastroPlayerVipInicial.Size = new System.Drawing.Size(111, 13);
            this.lblBuscaDataCadastroPlayerVipInicial.TabIndex = 5;
            this.lblBuscaDataCadastroPlayerVipInicial.Text = "Data Cadastro - Inicial";
            // 
            // lblBuscaQtdDiasPlayerVip
            // 
            this.lblBuscaQtdDiasPlayerVip.AutoSize = true;
            this.lblBuscaQtdDiasPlayerVip.Location = new System.Drawing.Point(239, 58);
            this.lblBuscaQtdDiasPlayerVip.Name = "lblBuscaQtdDiasPlayerVip";
            this.lblBuscaQtdDiasPlayerVip.Size = new System.Drawing.Size(69, 13);
            this.lblBuscaQtdDiasPlayerVip.TabIndex = 12;
            this.lblBuscaQtdDiasPlayerVip.Text = "Qtd. Dias Vip";
            // 
            // txtBuscaQtdDiasPlayerVip
            // 
            this.txtBuscaQtdDiasPlayerVip.Location = new System.Drawing.Point(243, 74);
            this.txtBuscaQtdDiasPlayerVip.MaxLength = 5;
            this.txtBuscaQtdDiasPlayerVip.Name = "txtBuscaQtdDiasPlayerVip";
            this.txtBuscaQtdDiasPlayerVip.Size = new System.Drawing.Size(130, 20);
            this.txtBuscaQtdDiasPlayerVip.TabIndex = 8;
            this.txtBuscaQtdDiasPlayerVip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaQtdDiasPlayerVip_KeyPress);
            // 
            // dtpBuscaDataCadastroPlayerVipInicial
            // 
            this.dtpBuscaDataCadastroPlayerVipInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscaDataCadastroPlayerVipInicial.Location = new System.Drawing.Point(6, 74);
            this.dtpBuscaDataCadastroPlayerVipInicial.Name = "dtpBuscaDataCadastroPlayerVipInicial";
            this.dtpBuscaDataCadastroPlayerVipInicial.Size = new System.Drawing.Size(111, 20);
            this.dtpBuscaDataCadastroPlayerVipInicial.TabIndex = 3;
            // 
            // txtBuscaNickPlayerVip
            // 
            this.txtBuscaNickPlayerVip.Location = new System.Drawing.Point(194, 35);
            this.txtBuscaNickPlayerVip.MaxLength = 255;
            this.txtBuscaNickPlayerVip.Name = "txtBuscaNickPlayerVip";
            this.txtBuscaNickPlayerVip.Size = new System.Drawing.Size(179, 20);
            this.txtBuscaNickPlayerVip.TabIndex = 2;
            // 
            // lblBuscaNickPlayerVip
            // 
            this.lblBuscaNickPlayerVip.AutoSize = true;
            this.lblBuscaNickPlayerVip.Location = new System.Drawing.Point(193, 19);
            this.lblBuscaNickPlayerVip.Name = "lblBuscaNickPlayerVip";
            this.lblBuscaNickPlayerVip.Size = new System.Drawing.Size(76, 13);
            this.lblBuscaNickPlayerVip.TabIndex = 2;
            this.lblBuscaNickPlayerVip.Text = "Nick do Player";
            // 
            // txtBuscaNomePlayerVip
            // 
            this.txtBuscaNomePlayerVip.Location = new System.Drawing.Point(6, 35);
            this.txtBuscaNomePlayerVip.MaxLength = 255;
            this.txtBuscaNomePlayerVip.Name = "txtBuscaNomePlayerVip";
            this.txtBuscaNomePlayerVip.Size = new System.Drawing.Size(179, 20);
            this.txtBuscaNomePlayerVip.TabIndex = 1;
            // 
            // lblBuscaNomePlayerVip
            // 
            this.lblBuscaNomePlayerVip.AutoSize = true;
            this.lblBuscaNomePlayerVip.Location = new System.Drawing.Point(6, 19);
            this.lblBuscaNomePlayerVip.Name = "lblBuscaNomePlayerVip";
            this.lblBuscaNomePlayerVip.Size = new System.Drawing.Size(82, 13);
            this.lblBuscaNomePlayerVip.TabIndex = 0;
            this.lblBuscaNomePlayerVip.Text = "Nome do Player";
            // 
            // tabRegPlayersVip
            // 
            this.tabRegPlayersVip.Controls.Add(this.btnCarregarTodosPlayersVip);
            this.tabRegPlayersVip.Controls.Add(this.gridRegistroGeral);
            this.tabRegPlayersVip.Controls.Add(this.grpDadosPlayersVip);
            this.tabRegPlayersVip.Location = new System.Drawing.Point(4, 22);
            this.tabRegPlayersVip.Name = "tabRegPlayersVip";
            this.tabRegPlayersVip.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegPlayersVip.Size = new System.Drawing.Size(391, 484);
            this.tabRegPlayersVip.TabIndex = 0;
            this.tabRegPlayersVip.Text = "Registro Geral";
            this.tabRegPlayersVip.UseVisualStyleBackColor = true;
            // 
            // btnCarregarTodosPlayersVip
            // 
            this.btnCarregarTodosPlayersVip.Location = new System.Drawing.Point(6, 176);
            this.btnCarregarTodosPlayersVip.Name = "btnCarregarTodosPlayersVip";
            this.btnCarregarTodosPlayersVip.Size = new System.Drawing.Size(379, 23);
            this.btnCarregarTodosPlayersVip.TabIndex = 14;
            this.btnCarregarTodosPlayersVip.Text = "Carregar Todos os Players Vip Cadastrados";
            this.btnCarregarTodosPlayersVip.UseVisualStyleBackColor = true;
            this.btnCarregarTodosPlayersVip.Click += new System.EventHandler(this.btnCarregarTodosPlayersVip_Click);
            // 
            // gridRegistroGeral
            // 
            this.gridRegistroGeral.AllowUserToAddRows = false;
            this.gridRegistroGeral.AllowUserToDeleteRows = false;
            this.gridRegistroGeral.AllowUserToResizeRows = false;
            this.gridRegistroGeral.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridRegistroGeral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridRegistroGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPlayerVip,
            this.colNomePlayerVip,
            this.colNickPlayerVip,
            this.colDataCadPlayerVip,
            this.colAtivoPlayerVip,
            this.colAdminPlayerVip,
            this.colQtdDiasPlayerVip});
            this.gridRegistroGeral.GridColor = System.Drawing.SystemColors.Control;
            this.gridRegistroGeral.Location = new System.Drawing.Point(6, 205);
            this.gridRegistroGeral.Name = "gridRegistroGeral";
            this.gridRegistroGeral.ReadOnly = true;
            this.gridRegistroGeral.RowHeadersVisible = false;
            this.gridRegistroGeral.Size = new System.Drawing.Size(379, 273);
            this.gridRegistroGeral.TabIndex = 15;
            this.gridRegistroGeral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRegistroGeral_CellClick);
            // 
            // colIDPlayerVip
            // 
            this.colIDPlayerVip.HeaderText = "ID";
            this.colIDPlayerVip.Name = "colIDPlayerVip";
            this.colIDPlayerVip.ReadOnly = true;
            this.colIDPlayerVip.Visible = false;
            this.colIDPlayerVip.Width = 5;
            // 
            // colNomePlayerVip
            // 
            this.colNomePlayerVip.HeaderText = "Nome";
            this.colNomePlayerVip.Name = "colNomePlayerVip";
            this.colNomePlayerVip.ReadOnly = true;
            this.colNomePlayerVip.Width = 70;
            // 
            // colNickPlayerVip
            // 
            this.colNickPlayerVip.HeaderText = "Nick";
            this.colNickPlayerVip.Name = "colNickPlayerVip";
            this.colNickPlayerVip.ReadOnly = true;
            // 
            // colDataCadPlayerVip
            // 
            this.colDataCadPlayerVip.HeaderText = "Cadastro";
            this.colDataCadPlayerVip.Name = "colDataCadPlayerVip";
            this.colDataCadPlayerVip.ReadOnly = true;
            this.colDataCadPlayerVip.Width = 65;
            // 
            // colAtivoPlayerVip
            // 
            this.colAtivoPlayerVip.HeaderText = "Ativo?";
            this.colAtivoPlayerVip.Name = "colAtivoPlayerVip";
            this.colAtivoPlayerVip.ReadOnly = true;
            this.colAtivoPlayerVip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAtivoPlayerVip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAtivoPlayerVip.Width = 40;
            // 
            // colAdminPlayerVip
            // 
            this.colAdminPlayerVip.HeaderText = "ADM?";
            this.colAdminPlayerVip.Name = "colAdminPlayerVip";
            this.colAdminPlayerVip.ReadOnly = true;
            this.colAdminPlayerVip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAdminPlayerVip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAdminPlayerVip.Width = 40;
            // 
            // colQtdDiasPlayerVip
            // 
            this.colQtdDiasPlayerVip.HeaderText = "Dias Vip";
            this.colQtdDiasPlayerVip.Name = "colQtdDiasPlayerVip";
            this.colQtdDiasPlayerVip.ReadOnly = true;
            this.colQtdDiasPlayerVip.Width = 60;
            // 
            // grpDadosPlayersVip
            // 
            this.grpDadosPlayersVip.Controls.Add(this.grpPlayerVipAdmServer);
            this.grpDadosPlayersVip.Controls.Add(this.grpPlayerVipAtivo);
            this.grpDadosPlayersVip.Controls.Add(this.grpAdminAcoes);
            this.grpDadosPlayersVip.Controls.Add(this.txtQtdDiasPlayerVip);
            this.grpDadosPlayersVip.Controls.Add(this.lblQtdDiasPlayerVip);
            this.grpDadosPlayersVip.Controls.Add(this.lblDataCadastroPlayerVip);
            this.grpDadosPlayersVip.Controls.Add(this.dtpDataCadastroPlayerVip);
            this.grpDadosPlayersVip.Controls.Add(this.txtNickPlayerVip);
            this.grpDadosPlayersVip.Controls.Add(this.lblNickPlayerVip);
            this.grpDadosPlayersVip.Controls.Add(this.txtNomePlayerVip);
            this.grpDadosPlayersVip.Controls.Add(this.lblNomePlayerVip);
            this.grpDadosPlayersVip.Location = new System.Drawing.Point(6, 7);
            this.grpDadosPlayersVip.Name = "grpDadosPlayersVip";
            this.grpDadosPlayersVip.Size = new System.Drawing.Size(379, 164);
            this.grpDadosPlayersVip.TabIndex = 0;
            this.grpDadosPlayersVip.TabStop = false;
            this.grpDadosPlayersVip.Text = "Dados dos Players Vip";
            // 
            // grpPlayerVipAdmServer
            // 
            this.grpPlayerVipAdmServer.Controls.Add(this.rdbPlayerVipEhAdminNao);
            this.grpPlayerVipAdmServer.Controls.Add(this.rdbPlayerVipEhAdminSim);
            this.grpPlayerVipAdmServer.Location = new System.Drawing.Point(190, 63);
            this.grpPlayerVipAdmServer.Name = "grpPlayerVipAdmServer";
            this.grpPlayerVipAdmServer.Size = new System.Drawing.Size(91, 36);
            this.grpPlayerVipAdmServer.TabIndex = 7;
            this.grpPlayerVipAdmServer.TabStop = false;
            this.grpPlayerVipAdmServer.Text = "ADM Server";
            // 
            // rdbPlayerVipEhAdminNao
            // 
            this.rdbPlayerVipEhAdminNao.AutoSize = true;
            this.rdbPlayerVipEhAdminNao.Location = new System.Drawing.Point(46, 16);
            this.rdbPlayerVipEhAdminNao.Name = "rdbPlayerVipEhAdminNao";
            this.rdbPlayerVipEhAdminNao.Size = new System.Drawing.Size(45, 17);
            this.rdbPlayerVipEhAdminNao.TabIndex = 9;
            this.rdbPlayerVipEhAdminNao.TabStop = true;
            this.rdbPlayerVipEhAdminNao.Text = "Não";
            this.rdbPlayerVipEhAdminNao.UseVisualStyleBackColor = true;
            // 
            // rdbPlayerVipEhAdminSim
            // 
            this.rdbPlayerVipEhAdminSim.AutoSize = true;
            this.rdbPlayerVipEhAdminSim.Location = new System.Drawing.Point(6, 16);
            this.rdbPlayerVipEhAdminSim.Name = "rdbPlayerVipEhAdminSim";
            this.rdbPlayerVipEhAdminSim.Size = new System.Drawing.Size(42, 17);
            this.rdbPlayerVipEhAdminSim.TabIndex = 8;
            this.rdbPlayerVipEhAdminSim.TabStop = true;
            this.rdbPlayerVipEhAdminSim.Text = "Sim";
            this.rdbPlayerVipEhAdminSim.UseVisualStyleBackColor = true;
            // 
            // grpPlayerVipAtivo
            // 
            this.grpPlayerVipAtivo.Controls.Add(this.rdbPlayerVipAtivoNao);
            this.grpPlayerVipAtivo.Controls.Add(this.rdbPlayerVipAtivoSim);
            this.grpPlayerVipAtivo.Location = new System.Drawing.Point(93, 63);
            this.grpPlayerVipAtivo.Name = "grpPlayerVipAtivo";
            this.grpPlayerVipAtivo.Size = new System.Drawing.Size(91, 36);
            this.grpPlayerVipAtivo.TabIndex = 4;
            this.grpPlayerVipAtivo.TabStop = false;
            this.grpPlayerVipAtivo.Text = "Vip Ativo?";
            // 
            // rdbPlayerVipAtivoNao
            // 
            this.rdbPlayerVipAtivoNao.AutoSize = true;
            this.rdbPlayerVipAtivoNao.Location = new System.Drawing.Point(46, 16);
            this.rdbPlayerVipAtivoNao.Name = "rdbPlayerVipAtivoNao";
            this.rdbPlayerVipAtivoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbPlayerVipAtivoNao.TabIndex = 6;
            this.rdbPlayerVipAtivoNao.TabStop = true;
            this.rdbPlayerVipAtivoNao.Text = "Não";
            this.rdbPlayerVipAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rdbPlayerVipAtivoSim
            // 
            this.rdbPlayerVipAtivoSim.AutoSize = true;
            this.rdbPlayerVipAtivoSim.Location = new System.Drawing.Point(6, 16);
            this.rdbPlayerVipAtivoSim.Name = "rdbPlayerVipAtivoSim";
            this.rdbPlayerVipAtivoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbPlayerVipAtivoSim.TabIndex = 5;
            this.rdbPlayerVipAtivoSim.TabStop = true;
            this.rdbPlayerVipAtivoSim.Text = "Sim";
            this.rdbPlayerVipAtivoSim.UseVisualStyleBackColor = true;
            // 
            // grpAdminAcoes
            // 
            this.grpAdminAcoes.Controls.Add(this.lblAvisoNaoAdministradorAcoesPlayersVip);
            this.grpAdminAcoes.Controls.Add(this.btnSalvarNovoPlayerVip);
            this.grpAdminAcoes.Controls.Add(this.btnCancelarGravarNovoPlayerVip);
            this.grpAdminAcoes.Controls.Add(this.btnNovoPlayerVip);
            this.grpAdminAcoes.Controls.Add(this.btnExcluirPlayerVip);
            this.grpAdminAcoes.Controls.Add(this.btnEditarPlayerVip);
            this.grpAdminAcoes.Location = new System.Drawing.Point(9, 102);
            this.grpAdminAcoes.Name = "grpAdminAcoes";
            this.grpAdminAcoes.Size = new System.Drawing.Size(364, 52);
            this.grpAdminAcoes.TabIndex = 14;
            this.grpAdminAcoes.TabStop = false;
            this.grpAdminAcoes.Text = "Ações do Administrador";
            // 
            // lblAvisoNaoAdministradorAcoesPlayersVip
            // 
            this.lblAvisoNaoAdministradorAcoesPlayersVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoNaoAdministradorAcoesPlayersVip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAvisoNaoAdministradorAcoesPlayersVip.Location = new System.Drawing.Point(6, 13);
            this.lblAvisoNaoAdministradorAcoesPlayersVip.Name = "lblAvisoNaoAdministradorAcoesPlayersVip";
            this.lblAvisoNaoAdministradorAcoesPlayersVip.Size = new System.Drawing.Size(352, 36);
            this.lblAvisoNaoAdministradorAcoesPlayersVip.TabIndex = 16;
            this.lblAvisoNaoAdministradorAcoesPlayersVip.Text = "Você não possui acesso às rotinas de Usuário Administrador";
            this.lblAvisoNaoAdministradorAcoesPlayersVip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvisoNaoAdministradorAcoesPlayersVip.Visible = false;
            // 
            // btnSalvarNovoPlayerVip
            // 
            this.btnSalvarNovoPlayerVip.Location = new System.Drawing.Point(6, 19);
            this.btnSalvarNovoPlayerVip.Name = "btnSalvarNovoPlayerVip";
            this.btnSalvarNovoPlayerVip.Size = new System.Drawing.Size(51, 23);
            this.btnSalvarNovoPlayerVip.TabIndex = 9;
            this.btnSalvarNovoPlayerVip.Text = "Gravar";
            this.btnSalvarNovoPlayerVip.UseVisualStyleBackColor = true;
            this.btnSalvarNovoPlayerVip.Click += new System.EventHandler(this.btnSalvarNovoPlayerVip_Click);
            // 
            // btnCancelarGravarNovoPlayerVip
            // 
            this.btnCancelarGravarNovoPlayerVip.Location = new System.Drawing.Point(63, 19);
            this.btnCancelarGravarNovoPlayerVip.Name = "btnCancelarGravarNovoPlayerVip";
            this.btnCancelarGravarNovoPlayerVip.Size = new System.Drawing.Size(51, 23);
            this.btnCancelarGravarNovoPlayerVip.TabIndex = 10;
            this.btnCancelarGravarNovoPlayerVip.Text = "Cancel.";
            this.btnCancelarGravarNovoPlayerVip.UseVisualStyleBackColor = true;
            this.btnCancelarGravarNovoPlayerVip.Click += new System.EventHandler(this.btnCancelarGravarNovoPlayerVip_Click);
            // 
            // btnNovoPlayerVip
            // 
            this.btnNovoPlayerVip.Location = new System.Drawing.Point(6, 19);
            this.btnNovoPlayerVip.Name = "btnNovoPlayerVip";
            this.btnNovoPlayerVip.Size = new System.Drawing.Size(108, 23);
            this.btnNovoPlayerVip.TabIndex = 11;
            this.btnNovoPlayerVip.Text = "Novo Player Vip";
            this.btnNovoPlayerVip.UseVisualStyleBackColor = true;
            this.btnNovoPlayerVip.Click += new System.EventHandler(this.btnNovoPlayerVip_Click);
            // 
            // btnExcluirPlayerVip
            // 
            this.btnExcluirPlayerVip.Location = new System.Drawing.Point(250, 19);
            this.btnExcluirPlayerVip.Name = "btnExcluirPlayerVip";
            this.btnExcluirPlayerVip.Size = new System.Drawing.Size(108, 23);
            this.btnExcluirPlayerVip.TabIndex = 13;
            this.btnExcluirPlayerVip.Text = "Excluir o Player Vip";
            this.btnExcluirPlayerVip.UseVisualStyleBackColor = true;
            this.btnExcluirPlayerVip.Click += new System.EventHandler(this.btnExcluirPlayerVip_Click);
            // 
            // btnEditarPlayerVip
            // 
            this.btnEditarPlayerVip.Location = new System.Drawing.Point(125, 19);
            this.btnEditarPlayerVip.Name = "btnEditarPlayerVip";
            this.btnEditarPlayerVip.Size = new System.Drawing.Size(115, 23);
            this.btnEditarPlayerVip.TabIndex = 12;
            this.btnEditarPlayerVip.Text = "Editar o Player Vip";
            this.btnEditarPlayerVip.UseVisualStyleBackColor = true;
            this.btnEditarPlayerVip.Click += new System.EventHandler(this.btnEditarPlayerVip_Click);
            // 
            // txtQtdDiasPlayerVip
            // 
            this.txtQtdDiasPlayerVip.Location = new System.Drawing.Point(287, 78);
            this.txtQtdDiasPlayerVip.MaxLength = 5;
            this.txtQtdDiasPlayerVip.Name = "txtQtdDiasPlayerVip";
            this.txtQtdDiasPlayerVip.Size = new System.Drawing.Size(86, 20);
            this.txtQtdDiasPlayerVip.TabIndex = 8;
            this.txtQtdDiasPlayerVip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdDiasVip_KeyPress);
            // 
            // lblQtdDiasPlayerVip
            // 
            this.lblQtdDiasPlayerVip.AutoSize = true;
            this.lblQtdDiasPlayerVip.Location = new System.Drawing.Point(284, 62);
            this.lblQtdDiasPlayerVip.Name = "lblQtdDiasPlayerVip";
            this.lblQtdDiasPlayerVip.Size = new System.Drawing.Size(69, 13);
            this.lblQtdDiasPlayerVip.TabIndex = 12;
            this.lblQtdDiasPlayerVip.Text = "Qtd. Dias Vip";
            // 
            // lblDataCadastroPlayerVip
            // 
            this.lblDataCadastroPlayerVip.AutoSize = true;
            this.lblDataCadastroPlayerVip.Location = new System.Drawing.Point(6, 62);
            this.lblDataCadastroPlayerVip.Name = "lblDataCadastroPlayerVip";
            this.lblDataCadastroPlayerVip.Size = new System.Drawing.Size(75, 13);
            this.lblDataCadastroPlayerVip.TabIndex = 5;
            this.lblDataCadastroPlayerVip.Text = "Data Cadastro";
            // 
            // dtpDataCadastroPlayerVip
            // 
            this.dtpDataCadastroPlayerVip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroPlayerVip.Location = new System.Drawing.Point(9, 78);
            this.dtpDataCadastroPlayerVip.Name = "dtpDataCadastroPlayerVip";
            this.dtpDataCadastroPlayerVip.Size = new System.Drawing.Size(79, 20);
            this.dtpDataCadastroPlayerVip.TabIndex = 3;
            // 
            // txtNickPlayerVip
            // 
            this.txtNickPlayerVip.Location = new System.Drawing.Point(194, 35);
            this.txtNickPlayerVip.MaxLength = 255;
            this.txtNickPlayerVip.Name = "txtNickPlayerVip";
            this.txtNickPlayerVip.Size = new System.Drawing.Size(179, 20);
            this.txtNickPlayerVip.TabIndex = 2;
            // 
            // lblNickPlayerVip
            // 
            this.lblNickPlayerVip.AutoSize = true;
            this.lblNickPlayerVip.Location = new System.Drawing.Point(193, 19);
            this.lblNickPlayerVip.Name = "lblNickPlayerVip";
            this.lblNickPlayerVip.Size = new System.Drawing.Size(76, 13);
            this.lblNickPlayerVip.TabIndex = 2;
            this.lblNickPlayerVip.Text = "Nick do Player";
            // 
            // txtNomePlayerVip
            // 
            this.txtNomePlayerVip.Location = new System.Drawing.Point(6, 35);
            this.txtNomePlayerVip.MaxLength = 255;
            this.txtNomePlayerVip.Name = "txtNomePlayerVip";
            this.txtNomePlayerVip.Size = new System.Drawing.Size(179, 20);
            this.txtNomePlayerVip.TabIndex = 1;
            // 
            // lblNomePlayerVip
            // 
            this.lblNomePlayerVip.AutoSize = true;
            this.lblNomePlayerVip.Location = new System.Drawing.Point(6, 19);
            this.lblNomePlayerVip.Name = "lblNomePlayerVip";
            this.lblNomePlayerVip.Size = new System.Drawing.Size(82, 13);
            this.lblNomePlayerVip.TabIndex = 0;
            this.lblNomePlayerVip.Text = "Nome do Player";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabRegPlayersVip);
            this.tabMain.Controls.Add(this.tabRegPlayersVipConsulta);
            this.tabMain.Controls.Add(this.tabCadastroUsuarioSistemaSistema);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(399, 510);
            this.tabMain.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 553);
            this.Controls.Add(this.btnCancelarSair);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COE Server - Administração de Players VIP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.tabCadastroUsuarioSistemaSistema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuariosSistema)).EndInit();
            this.grpUsuariosSistema.ResumeLayout(false);
            this.grpUsuariosSistema.PerformLayout();
            this.grpNivelAcessoUsuario.ResumeLayout(false);
            this.grpNivelAcessoUsuario.PerformLayout();
            this.tabRegPlayersVipConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscaRegistroFiltro)).EndInit();
            this.grpBuscaDadosPlayersVip.ResumeLayout(false);
            this.grpBuscaDadosPlayersVip.PerformLayout();
            this.grpBuscaPlayerVipAdmServer.ResumeLayout(false);
            this.grpBuscaPlayerVipAdmServer.PerformLayout();
            this.grpBuscaPlayerVipAtivo.ResumeLayout(false);
            this.grpBuscaPlayerVipAtivo.PerformLayout();
            this.tabRegPlayersVip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistroGeral)).EndInit();
            this.grpDadosPlayersVip.ResumeLayout(false);
            this.grpDadosPlayersVip.PerformLayout();
            this.grpPlayerVipAdmServer.ResumeLayout(false);
            this.grpPlayerVipAdmServer.PerformLayout();
            this.grpPlayerVipAtivo.ResumeLayout(false);
            this.grpPlayerVipAtivo.PerformLayout();
            this.grpAdminAcoes.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnCancelarSair;
        private System.Windows.Forms.TabPage tabCadastroUsuarioSistemaSistema;
        private System.Windows.Forms.TabPage tabRegPlayersVipConsulta;
        private System.Windows.Forms.TabPage tabRegPlayersVip;
        private System.Windows.Forms.Button btnCarregarTodosPlayersVip;
        private System.Windows.Forms.DataGridView gridRegistroGeral;
        private System.Windows.Forms.GroupBox grpDadosPlayersVip;
        private System.Windows.Forms.GroupBox grpPlayerVipAdmServer;
        private System.Windows.Forms.RadioButton rdbPlayerVipEhAdminNao;
        private System.Windows.Forms.RadioButton rdbPlayerVipEhAdminSim;
        private System.Windows.Forms.GroupBox grpPlayerVipAtivo;
        private System.Windows.Forms.RadioButton rdbPlayerVipAtivoNao;
        private System.Windows.Forms.RadioButton rdbPlayerVipAtivoSim;
        private System.Windows.Forms.GroupBox grpAdminAcoes;
        private System.Windows.Forms.Button btnSalvarNovoPlayerVip;
        private System.Windows.Forms.Button btnCancelarGravarNovoPlayerVip;
        private System.Windows.Forms.Button btnNovoPlayerVip;
        private System.Windows.Forms.Button btnExcluirPlayerVip;
        private System.Windows.Forms.Button btnEditarPlayerVip;
        private System.Windows.Forms.TextBox txtQtdDiasPlayerVip;
        private System.Windows.Forms.Label lblQtdDiasPlayerVip;
        private System.Windows.Forms.Label lblDataCadastroPlayerVip;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroPlayerVip;
        private System.Windows.Forms.TextBox txtNickPlayerVip;
        private System.Windows.Forms.Label lblNickPlayerVip;
        private System.Windows.Forms.TextBox txtNomePlayerVip;
        private System.Windows.Forms.Label lblNomePlayerVip;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.GroupBox grpBuscaDadosPlayersVip;
        private System.Windows.Forms.GroupBox grpBuscaPlayerVipAdmServer;
        private System.Windows.Forms.RadioButton rdbBuscaPlayerVipEhAdminNao;
        private System.Windows.Forms.RadioButton rdbBuscaPlayerVipEhAdminSim;
        private System.Windows.Forms.GroupBox grpBuscaPlayerVipAtivo;
        private System.Windows.Forms.RadioButton rdbBuscaPlayerVipAtivoNao;
        private System.Windows.Forms.RadioButton rdbBuscaPlayerVipAtivoSim;
        private System.Windows.Forms.TextBox txtBuscaQtdDiasPlayerVip;
        private System.Windows.Forms.Label lblBuscaQtdDiasPlayerVip;
        private System.Windows.Forms.Label lblBuscaDataCadastroPlayerVipInicial;
        private System.Windows.Forms.DateTimePicker dtpBuscaDataCadastroPlayerVipInicial;
        private System.Windows.Forms.TextBox txtBuscaNickPlayerVip;
        private System.Windows.Forms.Label lblBuscaNickPlayerVip;
        private System.Windows.Forms.TextBox txtBuscaNomePlayerVip;
        private System.Windows.Forms.Label lblBuscaNomePlayerVip;
        private System.Windows.Forms.Label lblBuscaDataCadastroPlayerVipFinal;
        private System.Windows.Forms.DateTimePicker dtpBuscaDataCadastroPlayerVipFinal;
        private System.Windows.Forms.Button btnBuscaPlayersVip;
        private System.Windows.Forms.DataGridView gridBuscaRegistroFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuscarIDPlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuscarNomePlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuscarNickPlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuscarDataCadPlayerVip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colBuscarAtivoPlayerVip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colBuscarAdminPlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuscarQtdDiasPlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomePlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNickPlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCadPlayerVip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivoPlayerVip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAdminPlayerVip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdDiasPlayerVip;
        private System.Windows.Forms.GroupBox grpUsuariosSistema;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.TextBox txtUsuarioNome;
        private System.Windows.Forms.Label lblUsuarioNome;
        private System.Windows.Forms.TextBox txtUsuarioSenhaConfirmacao;
        private System.Windows.Forms.Label lblUsuarioSenhaConfirmacao;
        private System.Windows.Forms.TextBox txtUsuarioSenha;
        private System.Windows.Forms.Label lblUsuarioSenha;
        private System.Windows.Forms.GroupBox grpNivelAcessoUsuario;
        private System.Windows.Forms.RadioButton rdbNivelAcessoUsuarioAdministrador;
        private System.Windows.Forms.RadioButton rdbNivelAcessoUsuarioLeitura;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnCancelarSalvarUsuario;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.Label lblAvisoNaoAdministrador;
        private System.Windows.Forms.Label lblAvisoNaoAdministradorAcoesPlayersVip;
        private System.Windows.Forms.DataGridView gridUsuariosSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCadastroUsuarioSistema;
        private System.Windows.Forms.Button btnSalvarAlteracaoUsuario;
        private System.Windows.Forms.Button btnCancelarAlteracaoUsuario;
    }
}

