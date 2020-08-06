using COEServer.PlayersVIP.Business;
using COEServer.PlayersVIP.Common;
using COEServer.PlayersVIP.Common.Filters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COEServer.PlayersVIP.Interface
{
    public partial class FrmMain : Form
    {
        AdministracaoPlayersVip _administracaoPlayersVip;
        BusinessOperations _businessOperations;

        #region Eventos

        // FORMULÁRIO

        public FrmMain(AdministracaoPlayersVip administracaoPlayersVip)
        {
            InitializeComponent();
            // Seta neste tipo os dados do usuário logado
            _administracaoPlayersVip = administracaoPlayersVip;

            lblUsuarioLogado.Text = string.Format("({0}) {1}", administracaoPlayersVip.LevelAdministracaoPlayersVip.LevelAdministracaoPlayersVipDescricao,
                administracaoPlayersVip.AdminNome);

            // esconde os botões de cancelar e gravar novo Player vip
            btnCancelarGravarNovoPlayerVip.Visible = false;
            btnSalvarNovoPlayerVip.Visible = false;

            ResetarControlesDoFormulario();

            // Desabilita as ações de usuários diferente de Administrador (ID 1)
            if (_administracaoPlayersVip.LevelAdministracaoPlayersVip.LevelAdministracaoPlayersVipID != 1)
            {
                foreach (TabPage item in tabMain.TabPages)
                {
                    if (item.Name == "tabCadastroUsuarioSistema")
                    {
                        item.Controls.Clear();
                        item.Controls.Add(lblAvisoNaoAdministrador);
                        lblAvisoNaoAdministrador.Visible = true;                        
                    }
                }

                grpAdminAcoes.Controls.Clear();
                grpAdminAcoes.Controls.Add(lblAvisoNaoAdministradorAcoesPlayersVip);
                lblAvisoNaoAdministradorAcoesPlayersVip.Visible = true;
            }

            // Habilita os radiobuttons da tab "Consulta de Players Vip"
            rdbBuscaPlayerVipAtivoSim.Checked = true;
            rdbBuscaPlayerVipEhAdminNao.Checked = true;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        // AÇOES DE UM NOVO PLAY VIP
        private void btnCancelarSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sair da Administração dos VIP's?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCarregarTodosPlayersVip_Click(object sender, EventArgs e)
        {
            CarregarTodosPlayersVip();
        }

        private void btnExcluirPlayerVip_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridRegistroGeral.SelectedCells.Count == 1)
                {
                    int indexCell = gridRegistroGeral.CurrentCell.RowIndex;

                    if (indexCell >= 0)
                    {
                        string _nickVip = gridRegistroGeral.Rows[indexCell].Cells[2].Value.ToString();

                        if (MessageBox.Show(string.Format("Deseja realmente excluir o Player Vip \"{0}\"", _nickVip), "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (_businessOperations.BusinessDeletarPlayerVip(Convert.ToInt32(gridRegistroGeral.Rows[indexCell].Cells[0].Value.ToString())))
                            {
                                MessageBox.Show(string.Format("Sucesso ao excluir o Player Vip \"{0}\"", _nickVip), "Registro eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarTodosPlayersVip();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o Player Vip: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarPlayerVip_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridRegistroGeral.SelectedCells.Count == 1)
                {
                    int indexCell = gridRegistroGeral.CurrentCell.RowIndex;

                    if (indexCell >= 0)
                    {
                        // Convert para int32 (caso o usuário extrapole o limite) e verifica se é maior que 32.000 (smallint)
                        if (!string.IsNullOrEmpty(txtQtdDiasPlayerVip.Text))
                        {
                            if (Convert.ToInt32(txtQtdDiasPlayerVip.Text) > 32000)
                            {
                                MessageBox.Show("A quantidade de dias do Player Vip excede 32.000 dias. Favor diminuir!", "Extrapolação de limites numéricos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }

                        string _nickVip = gridRegistroGeral.Rows[indexCell].Cells[2].Value.ToString();

                        if (MessageBox.Show(string.Format("Deseja fazer as alterações no Player Vip \"{0}\"", _nickVip), "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool retornoEdicao = _businessOperations.BusinessEditarPlayerVip(new PlayersVip
                            {
                                PlayerID = Convert.ToInt32(gridRegistroGeral.Rows[indexCell].Cells[0].Value.ToString()),
                                PlayerNome = txtNomePlayerVip.Text.Trim(),
                                PlayerNick = txtNickPlayerVip.Text.Trim(),
                                PlayerAtivo = rdbPlayerVipAtivoSim.Checked,
                                PlayerEhAdmin = rdbPlayerVipEhAdminSim.Checked,
                                PlayerDataInclusaoSLOTVip = dtpDataCadastroPlayerVip.Value,
                                PlayerDiasVIP = string.IsNullOrEmpty(txtQtdDiasPlayerVip.Text.Trim()) == true ? (short)0 : Convert.ToInt16(txtQtdDiasPlayerVip.Text.Trim()),
                            });

                            if (retornoEdicao)
                            {
                                MessageBox.Show(string.Format("Sucesso ao fazer as alterações no Player Vip \"{0}\"", _nickVip), "Registro eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarTodosPlayersVip();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o Player Vip: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridRegistroGeral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PropagarInformacoesDoGridPlayersVip();
        }

        private void txtQtdDiasVip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnNovoPlayerVip_Click(object sender, EventArgs e)
        {
            btnNovoPlayerVip.Visible = false;
            btnSalvarNovoPlayerVip.Visible = true;
            btnCancelarGravarNovoPlayerVip.Visible = true;
            ResetarControlesDoFormulario();
        }

        private void btnCancelarGravarNovoPlayerVip_Click(object sender, EventArgs e)
        {
            btnSalvarNovoPlayerVip.Visible = false;
            btnCancelarGravarNovoPlayerVip.Visible = false;
            btnNovoPlayerVip.Visible = true;
            CarregarTodosPlayersVip();
        }

        private void btnSalvarNovoPlayerVip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNickPlayerVip.Text))
            {
                MessageBox.Show("O Nick do Player está vazio e ele é requirido. Favor informar um Nick válido", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!string.IsNullOrEmpty(txtQtdDiasPlayerVip.Text))
            {
                if (Convert.ToInt32(txtQtdDiasPlayerVip.Text) > 32000)
                {
                    MessageBox.Show("A quantidade de dias de Vip é superior ao limite de 32.000. Favor informar uma quantidade inferior", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            _businessOperations = new BusinessOperations();

            // gera uma entidade com os dados do formulário
            PlayersVip playersVip = new PlayersVip
            {
                PlayerNome = txtNomePlayerVip.Text.Trim(),
                PlayerNick = txtNickPlayerVip.Text.Trim(),
                PlayerDiasVIP = string.IsNullOrEmpty(txtQtdDiasPlayerVip.Text.Trim()) == true ? (short)0 : Convert.ToInt16(txtQtdDiasPlayerVip.Text.Trim()),
                PlayerAtivo = rdbPlayerVipAtivoSim.Checked,
                PlayerEhAdmin = rdbPlayerVipEhAdminSim.Checked,
                PlayerDataInclusaoSLOTVip = dtpDataCadastroPlayerVip.Value
            };

            if (_businessOperations.BusinessInserirPlayerVip(playersVip))
            {
                MessageBox.Show(string.Format("Sucesso ao cadastrar o novo Player Vip \"{0}\"", txtNickPlayerVip.Text), "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancelarGravarNovoPlayerVip.Visible = false;
                btnSalvarNovoPlayerVip.Visible = false;
                btnNovoPlayerVip.Visible = true;
                CarregarTodosPlayersVip();
            }                
            else
                MessageBox.Show(string.Format("Não foi possível cadastrar o novo Player Vip \"{0}\". Favor verificar a entrada dos dados.", txtNickPlayerVip.Text), "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // BUSCA DE PLAYERS VIP

        private void txtBuscaQtdDiasPlayerVip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnBuscaPlayersVip_Click(object sender, EventArgs e)
        {
            _businessOperations = new BusinessOperations();
            try
            {
                List<PlayersVip> playersVips = _businessOperations.BusinessGetPlayersVipByFilter(new PlayersVipFilter
                {
                    PlayerNome = txtBuscaNomePlayerVip.Text.Trim(),
                    PlayerNick = txtBuscaNickPlayerVip.Text.Trim(),
                    PlayerDataInclusaoSLOTVipInicial = dtpBuscaDataCadastroPlayerVipInicial.Value,
                    PlayerDataInclusaoSLOTVipFinal = dtpBuscaDataCadastroPlayerVipFinal.Value,
                    PlayerAtivo = rdbBuscaPlayerVipAtivoSim.Checked,
                    PlayerEhAdmin = rdbBuscaPlayerVipEhAdminSim.Checked,
                    PlayerDiasVIP = string.IsNullOrEmpty(txtBuscaQtdDiasPlayerVip.Text.Trim()) == true ? short.MinValue : Convert.ToInt16(txtBuscaQtdDiasPlayerVip.Text.Trim())
                });

                if (playersVips != null)
                    CarregarDadosNoGridFiltro(playersVips);
                else
                {
                    MessageBox.Show("Nenhum Player Víp encontrado na base de dados baseado nas informações deste formulário", "Sem registros!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridBuscaRegistroFiltro.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar os Player's Vip na base de dados: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // USUÁRIOS DO SISTEMA
        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarSalvarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsuarioNome_TextChanged(object sender, EventArgs e)
        {
            txtUsuarioLogin.Text = txtUsuarioNome.Text.Replace(" ", "");
        }

        private void tabCadastroUsuarioSistemaSistema_Enter(object sender, EventArgs e)
        {
            CarregarTodosUsuariosSistema();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {

        }

        private void gridUsuariosSistema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PropagarInformacoesDoGridUsuariosSistema();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAlteracaoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarAlteracaoUsuario_Click(object sender, EventArgs e)
        {
           
        }
        #endregion Eventos

        #region Funções diversas

        // Busca os dados na base de dados
        private void CarregarTodosPlayersVip()
        {
            _businessOperations = new BusinessOperations();

            List<PlayersVip> listPlayersVips = _businessOperations.BusinessGetPlayersVipAll();

            if (listPlayersVips is null)
            {
                MessageBox.Show("Nenhum Registro encontrado na base de dados. Por favor, cadastre novos Players Vip para serem mostrados aqui", "Sem registros!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ResetarControlesDoFormulario();
            }
            else
            {
                grpDadosPlayersVip.Enabled = true;
                CarregarDadosNoGrid(listPlayersVips);
            }
        }

        private void CarregarTodosUsuariosSistema()
        {
            _businessOperations = new BusinessOperations();

            List<AdministracaoPlayersVip> administracaoPlayersVipList = _businessOperations.BusinessGetUsuariosSistemaAll();

            if (administracaoPlayersVipList is null)
                MessageBox.Show("Nenhum Usuário do Sistema encontrado na base de dados. Por favor, cadastre novos Usuários do Sistema para serem mostrados aqui", "Sem registros!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                CarregarDadosNoGridUsuariosSistema(administracaoPlayersVipList);
        }

        // Recebe os dados e insere nos Grids
        private void CarregarDadosNoGrid(List<PlayersVip> playersVips)
        {
            gridRegistroGeral.Rows.Clear();

            if (playersVips.Count > 0)
            {
                foreach (PlayersVip item in playersVips)
                {
                    gridRegistroGeral.Rows.Add(
                        item.PlayerID,
                        item.PlayerNome,
                        item.PlayerNick,
                        item.PlayerDataInclusaoSLOTVip,
                        item.PlayerAtivo,
                        item.PlayerEhAdmin,
                        item.PlayerDiasVIP
                    );
                };

                PropagarInformacoesDoGridPlayersVip();
            }
        }

        private void CarregarDadosNoGridUsuariosSistema(List<AdministracaoPlayersVip> administracaoPlayersVip)
        {
            gridUsuariosSistema.Rows.Clear();

            if (administracaoPlayersVip.Count > 0)
            {
                foreach (AdministracaoPlayersVip item in administracaoPlayersVip)
                {
                    gridUsuariosSistema.Rows.Add(
                        item.AdminID,
                        item.LevelAdministracaoPlayersVip.LevelAdministracaoPlayersVipDescricao,
                        item.AdminNome,
                        item.AdminLogin,
                        item.AdminDataCadastro
                    );
                };
            }

            PropagarInformacoesDoGridUsuariosSistema();
        }

        private void CarregarDadosNoGridFiltro(List<PlayersVip> playersVips)
        {
            gridBuscaRegistroFiltro.Rows.Clear();

            if (playersVips.Count > 0)
            {
                foreach (PlayersVip item in playersVips)
                {
                    gridBuscaRegistroFiltro.Rows.Add(
                        item.PlayerID,
                        item.PlayerNome,
                        item.PlayerNick,
                        item.PlayerDataInclusaoSLOTVip,
                        item.PlayerAtivo,
                        item.PlayerEhAdmin,
                        item.PlayerDiasVIP
                    );
                };

                PropagarInformacoesDoGridPlayersVip();
            }
        }

        // Propaga as informações do Grid para o campos de texto e demais controles
        private void PropagarInformacoesDoGridPlayersVip()
        {
            try
            {
                if (gridRegistroGeral.SelectedCells.Count == 1)
                {
                    int indexCell = gridRegistroGeral.CurrentCell.RowIndex;

                    txtNomePlayerVip.Text = gridRegistroGeral.Rows[indexCell].Cells[1].Value.ToString();
                    txtNickPlayerVip.Text = gridRegistroGeral.Rows[indexCell].Cells[2].Value.ToString();
                    dtpDataCadastroPlayerVip.Value = Convert.ToDateTime(gridRegistroGeral.Rows[indexCell].Cells[3].Value);
                    bool ativo = (bool)gridRegistroGeral.Rows[indexCell].Cells[4].Value;
                    bool ehAdm = (bool)gridRegistroGeral.Rows[indexCell].Cells[5].Value;
                    txtQtdDiasPlayerVip.Text = gridRegistroGeral.Rows[indexCell].Cells[6].Value.ToString();

                    // Radio buttons
                    if (ativo)
                    {
                        rdbPlayerVipAtivoSim.Checked = true;
                        rdbPlayerVipAtivoNao.Checked = false;
                    }
                    else
                    {
                        rdbPlayerVipAtivoNao.Checked = true;
                        rdbPlayerVipAtivoSim.Checked = false;
                    }

                    if (ehAdm)
                    {
                        rdbPlayerVipEhAdminSim.Checked = true;
                        rdbPlayerVipEhAdminNao.Checked = false;
                    }
                    else
                    {
                        rdbPlayerVipEhAdminNao.Checked = true;
                        rdbPlayerVipEhAdminSim.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao propagar as informações do grid para os campos: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PropagarInformacoesDoGridUsuariosSistema()
        {
            try
            {
                if (gridUsuariosSistema.SelectedCells.Count == 1)
                {
                    int indexCell = gridUsuariosSistema.CurrentCell.RowIndex;

                    txtUsuarioNome.Text = gridUsuariosSistema.Rows[indexCell].Cells[2].Value.ToString();
                    txtUsuarioLogin.Text = gridUsuariosSistema.Rows[indexCell].Cells[3].Value.ToString();

                    txtUsuarioSenha.ResetText();
                    txtUsuarioSenhaConfirmacao.ResetText();
                    txtUsuarioSenha.Enabled = false;
                    txtUsuarioSenhaConfirmacao.Enabled = false;

                    // Radio buttons
                    if (gridUsuariosSistema.Rows[indexCell].Cells[1].Value.ToString().Equals("Administrador"))
                    {
                        rdbNivelAcessoUsuarioAdministrador.Checked = true;
                        rdbNivelAcessoUsuarioLeitura.Checked = false;                        
                    }
                    else
                    {
                        rdbNivelAcessoUsuarioAdministrador.Checked = false;
                        rdbNivelAcessoUsuarioLeitura.Checked = true;
                    }  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao propagar as informações do grid para os campos: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        // Demais controles
        private void HabilitarControlesPlayersVip(bool status)
        {
            // grid
            gridRegistroGeral.Enabled = status;

            // textbox            
            txtNomePlayerVip.Enabled = status;
            txtNickPlayerVip.Enabled = status;
            txtQtdDiasPlayerVip.Enabled = status;

            // checkbox
            grpPlayerVipAdmServer.Enabled = status;
            grpPlayerVipAtivo.Enabled = status;
            rdbPlayerVipAtivoSim.Checked = status;
            rdbPlayerVipAtivoNao.Checked = status;
            rdbPlayerVipEhAdminSim.Checked = status;
            rdbPlayerVipEhAdminNao.Checked = status;

            // grup de botões de ações
            grpAdminAcoes.Enabled = status;

            // datetimepicker
            dtpDataCadastroPlayerVip.Enabled = status;
        }

        private void ResetarControlesDoFormulario()
        {
            // textbox 
            txtNomePlayerVip.ResetText();
            txtNickPlayerVip.ResetText();
            txtQtdDiasPlayerVip.ResetText();

            // grid
            gridRegistroGeral.Rows.Clear();

            // datetimepicker
            dtpDataCadastroPlayerVip.Value = DateTime.Now;

            // radiobutton
            rdbPlayerVipAtivoSim.Checked = true;
            rdbPlayerVipAtivoNao.Checked = false;
            rdbPlayerVipEhAdminSim.Checked = false;
            rdbPlayerVipEhAdminNao.Checked = true;
        }
        #endregion Funções diversas
    }
}