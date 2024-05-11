
namespace ProjetoLojaABC
{
    partial class frmCadFunc
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
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.txtSenha2);
            this.gpbDadosPessoais.Controls.Add(this.lblSenha2);
            this.gpbDadosPessoais.Controls.Add(this.txtSenha);
            this.gpbDadosPessoais.Controls.Add(this.lblSenha);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txtCodigo);
            this.gpbDadosPessoais.Controls.Add(this.label1);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(27, 15);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(747, 289);
            this.gpbDadosPessoais.TabIndex = 13;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados pessoais";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(87, 132);
            this.txtSenha.MaxLength = 100;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(324, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(34, 135);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 81);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 24);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(87, 36);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 24);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Location = new System.Drawing.Point(11, 475);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(779, 71);
            this.pnlCRUD.TabIndex = 14;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(221, 15);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 32);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(554, 15);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 32);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(445, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 32);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(333, 15);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 32);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(109, 15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 32);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 32);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(665, 15);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 32);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha2.Location = new System.Drawing.Point(141, 178);
            this.txtSenha2.MaxLength = 100;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = 'l';
            this.txtSenha2.Size = new System.Drawing.Size(270, 25);
            this.txtSenha2.TabIndex = 5;
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Location = new System.Drawing.Point(34, 181);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(101, 18);
            this.lblSenha2.TabIndex = 6;
            this.lblSenha2.Text = "Repetir Senha";
            // 
            // frmCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.pnlCRUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadFunc";
            this.Load += new System.EventHandler(this.frmCadFunc_Load);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label lblSenha2;
    }
}