using COEServer.PlayersVIP.Business;
using COEServer.PlayersVIP.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace COEServer.PlayersVIP.Interface
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblMsgSistema.Visible = false;
        }

        private void btnCancelarSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sair da Administração dos VIP's?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Os campos de login e senha não deverão estar vazios", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string _msgErro = "Login e/ou senha inválido(s)";

            BusinessOperations businessOperations = new BusinessOperations();

            AdministracaoPlayersVip administracaoPlayersVip = businessOperations.BusinessAdministracaoPlayersVip(new AdministracaoPlayersVip
            {
                AdminLogin = txtLogin.Text,
                AdminPassword = txtSenha.Text
            });

            if (administracaoPlayersVip == null)
            {
                MessageBox.Show(_msgErro, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMsgSistema.ForeColor = Color.Red;
                lblMsgSistema.Visible = true;
                lblMsgSistema.Text = _msgErro + ". Tente novamente!";
                return;
            }
            else
            {
                FrmMain frmMain = new FrmMain(administracaoPlayersVip);
                Hide();
                frmMain.Show();
            }
        }
    }
}
