﻿using System;
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
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;
            carregaFuncionario(txtNome.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        //desabilitarCampos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtNumero.Enabled = false;
            mskCelular.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            cbbEstado.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;

        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtNumero.Enabled = true;
            mskCelular.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            cbbEstado.Enabled = true;

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
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            mskCelular.Text = "";
            mskCEP.Text = "";
            mskCPF.Text = "";
            cbbEstado.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            txtCodigo.Enabled = false;
            buscarCodigoFunc();
        }

        //método cadastrar funcionarios
        public void cadastrarFuncionarios()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into tbFuncionarios" +
                "(nome,email,cpf,telCel,endereco,numero,cep,bairro,cidade,estado)values(@nome, @email, @cpf, @telCel, @endereco, @numero, @cep, @bairro, @cidade, @estado);";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = txtNome.Text;
            cmd.Parameters.Add("@email",MySqlDbType.VarChar,100).Value = txtEmail.Text;
            cmd.Parameters.Add("@cpf",MySqlDbType.VarChar,14).Value = mskCPF.Text;
            cmd.Parameters.Add("@telCel",MySqlDbType.VarChar,10).Value = mskCelular.Text;
            cmd.Parameters.Add("@endereco",MySqlDbType.VarChar,100).Value = txtEndereco.Text;
            cmd.Parameters.Add("@numero",MySqlDbType.VarChar,5).Value = txtNumero.Text;
            cmd.Parameters.Add("@cep",MySqlDbType.VarChar,9).Value = mskCEP.Text;
            cmd.Parameters.Add("@bairro",MySqlDbType.VarChar,100).Value = txtBairro.Text;
            cmd.Parameters.Add("@cidade",MySqlDbType.VarChar,100).Value = txtCidade.Text;
            cmd.Parameters.Add("@estado",MySqlDbType.VarChar,10).Value = cbbEstado.Text;

            cmd.Connection = Conexao.obterConexao();
            int res = cmd.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso");
            limparCampos();
            Conexao.fecharConexao();
        }

        public void buscarCodigoFunc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc+1 from tbfuncionarios order by codFunc desc;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();

            Conexao.fecharConexao();

        }

        public void carregaFuncionario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome = @nome";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mskCPF.Text = DR.GetString(3);
            mskCelular.Text = DR.GetString(4);
            txtEndereco.Text = DR.GetString(5);
            txtNumero.Text = DR.GetString(6);
            mskCEP.Text = DR.GetString(7);
            txtBairro.Text = DR.GetString(8);
            txtCidade.Text = DR.GetString(9);
            cbbEstado.Text = DR.GetString(10);

            Conexao.fecharConexao();
            habilitarCampos();
            funcaoCarregaFuncionario();
        }

        public void funcaoCarregaFuncionario()
        {
            txtCodigo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Equals("") || txtNome.Text.Equals("") ||
                txtEndereco.Text.Equals("") || txtCidade.Text.Equals("") ||
                txtBairro.Text.Equals("") || txtNumero.Text.Equals("") ||
                txtEmail.Text.Equals("") || mskCelular.Text.Equals("     -")
                || mskCPF.Text.Equals("   .   .   -") ||
                mskCEP.Text.Equals("     -") || cbbEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores válidos!!!",
                "Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);

            }
            else
            {

                cadastrarFuncionarios();
                desabilitarCampos();
                btnNovo.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            abrir.Show();
            this.Hide();
        }

        public void buscaCEP(string cep)
        {
            
        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
                WSCorreios.enderecoERP endereco = ws.consultaCEP(mskCEP.Text,"","");
                txtEndereco.Text = endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;
                cbbEstado.Text = endereco.uf;
            }
        }
       
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
        }

        public void alterarFuncionarios(int codFunc)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "update tbFuncionarios set nome=@nome,email=@email,cpf=@cpf,telCel=@telCel,endereco=@endereco,numero=@numero,cep=@cep,bairro=@bairro,cidade=@cidadew,estado=@estado where codFunc=@codFunc)";            
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            cmd.Parameters.Add("@telCel", MySqlDbType.VarChar, 10).Value = mskCelular.Text;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = txtNumero.Text;
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCEP.Text;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            cmd.Parameters.Add("@estado", MySqlDbType.VarChar, 10).Value = cbbEstado.Text;
            cmd.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codFunc;

            cmd.Connection = Conexao.obterConexao();
            int res = cmd.ExecuteNonQuery();

            MessageBox.Show("Alterado com sucesso");
            limparCampos();
            Conexao.fecharConexao();

            cmd.Parameters.Clear();
            //cmd.Parameters.Add().value;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarFuncionarios(Convert.ToInt32(txtCodigo.Text));
        }

        public void excluirFuncionarios(int codFunc)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from tbfuncionarios where codFunc=@codFunc";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codFunc;

            cmd.Connection = Conexao.obterConexao();
            int res = cmd.ExecuteNonQuery();

            MessageBox.Show("Excluido com sucesso");
            limparCampos();
            Conexao.fecharConexao();

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirFuncionarios(Convert.ToInt32(txtCodigo.Text));
        }
    }
}