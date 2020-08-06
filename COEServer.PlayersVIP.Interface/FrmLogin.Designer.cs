namespace COEServer.PlayersVIP.Interface
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.grpFormLogin = new System.Windows.Forms.GroupBox();
            this.lblMsgSistema = new System.Windows.Forms.Label();
            this.btnCancelarSair = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLinkSuporte = new System.Windows.Forms.LinkLabel();
            this.grpFormLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(6, 43);
            this.txtLogin.MaxLength = 16;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(219, 21);
            this.txtLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(3, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 15);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(6, 74);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 15);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 94);
            this.txtSenha.MaxLength = 16;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(219, 21);
            this.txtSenha.TabIndex = 2;
            // 
            // grpFormLogin
            // 
            this.grpFormLogin.Controls.Add(this.lblMsgSistema);
            this.grpFormLogin.Controls.Add(this.btnCancelarSair);
            this.grpFormLogin.Controls.Add(this.btnLogin);
            this.grpFormLogin.Controls.Add(this.txtLogin);
            this.grpFormLogin.Controls.Add(this.lblSenha);
            this.grpFormLogin.Controls.Add(this.lblLogin);
            this.grpFormLogin.Controls.Add(this.txtSenha);
            this.grpFormLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormLogin.Location = new System.Drawing.Point(12, 12);
            this.grpFormLogin.Name = "grpFormLogin";
            this.grpFormLogin.Size = new System.Drawing.Size(231, 171);
            this.grpFormLogin.TabIndex = 4;
            this.grpFormLogin.TabStop = false;
            this.grpFormLogin.Text = "Área de Administração";
            // 
            // lblMsgSistema
            // 
            this.lblMsgSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgSistema.Location = new System.Drawing.Point(6, 148);
            this.lblMsgSistema.Name = "lblMsgSistema";
            this.lblMsgSistema.Size = new System.Drawing.Size(219, 14);
            this.lblMsgSistema.TabIndex = 7;
            this.lblMsgSistema.Text = "_msg_";
            this.lblMsgSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelarSair
            // 
            this.btnCancelarSair.Location = new System.Drawing.Point(121, 120);
            this.btnCancelarSair.Name = "btnCancelarSair";
            this.btnCancelarSair.Size = new System.Drawing.Size(104, 23);
            this.btnCancelarSair.TabIndex = 6;
            this.btnCancelarSair.Text = "Cancelar e Sair";
            this.btnCancelarSair.UseVisualStyleBackColor = true;
            this.btnCancelarSair.Click += new System.EventHandler(this.btnCancelarSair_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 120);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Logar-se!";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLinkSuporte
            // 
            this.lblLinkSuporte.AutoSize = true;
            this.lblLinkSuporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkSuporte.Location = new System.Drawing.Point(9, 182);
            this.lblLinkSuporte.Name = "lblLinkSuporte";
            this.lblLinkSuporte.Size = new System.Drawing.Size(37, 12);
            this.lblLinkSuporte.TabIndex = 5;
            this.lblLinkSuporte.TabStop = true;
            this.lblLinkSuporte.Text = "Suporte";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(255, 199);
            this.Controls.Add(this.lblLinkSuporte);
            this.Controls.Add(this.grpFormLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COE Server - Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.grpFormLogin.ResumeLayout(false);
            this.grpFormLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox grpFormLogin;
        private System.Windows.Forms.Button btnCancelarSair;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblLinkSuporte;
        private System.Windows.Forms.Label lblMsgSistema;
    }
}