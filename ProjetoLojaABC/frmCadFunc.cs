using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//importando o driver do banco de dados
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmCadFunc : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadFunc()
        {
            InitializeComponent();
        }


        private void frmCadFunc_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Equals("") || txtNome.Text.Equals("") ||
               txtSenha.Text.Equals("") || txtSenha2.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores válidos!!!",
                "Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                cadastrarUsuarios();
                desabilitarCampos();
                btnNovo.Enabled = true;
            }
        }

        public void cadastrarUsuarios()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tbUsuarios(nome,senha)values(@nome, @senha);";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar, 100).Value = txtSenha.Text;            

            cmd.Connection = Conexao.obterConexao();
            int res = cmd.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso");
            limparCampos();
            Conexao.fecharConexao();
        }
            //desabilitarCampos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;           
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtSenha2.Enabled = false;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;

        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;           
            txtNome.Enabled = true;
            txtSenha.Enabled = false;
            txtSenha2.Enabled = false;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha2.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {           
          habilitarCampos();
          txtCodigo.Enabled = false;
     
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarUsuarios(Convert.ToInt32(txtCodigo.Text));
        }

        public void alterarUsuarios(int codUsu)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tbUsuarios set nome=@nome, senha=@senha where codUsu=@codUsu)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar, 100).Value = txtSenha.Text;
            
            cmd.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codUsu;

            cmd.Connection = Conexao.obterConexao();
            int res = cmd.ExecuteNonQuery();

            MessageBox.Show("Alterado com sucesso");
            limparCampos();
            Conexao.fecharConexao();

            cmd.Parameters.Clear();
            //cmd.Parameters.Add().value;
        }

        public void excluirUsuarios(int codUsu)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tbUsuarios where codUsu=@codUsu";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codUsu;

            cmd.Connection = Conexao.obterConexao();
            int res = cmd.ExecuteNonQuery();

            MessageBox.Show("Excluido com sucesso");
            limparCampos();
            Conexao.fecharConexao();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirUsuarios(Convert.ToInt32(txtCodigo.Text));
        }
    }
}
