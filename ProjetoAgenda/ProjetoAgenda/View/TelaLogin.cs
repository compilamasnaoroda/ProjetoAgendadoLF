using ProjetoAgenda.Controller;
using ProjetoAgenda.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int verifica;
        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string senha = TxtSenha.Text;

            List<string> dados = new List<string>();
            Controle_Login controle = new Controle_Login();
            dados = controle.Logar(usuario, senha);

            string Hashbanco = dados[0];
            string Tipousuario = dados[1];

            bool resp = false;
            if (Hashbanco == "")
                resp = false;
            else if (Hashbanco != "")
                resp = BCrypt.Net.BCrypt.Verify(senha, Hashbanco);

            if (resp)
            {
                //Pode logar
                this.Hide();
                TelaPrincipal tela = new TelaPrincipal();
                tela.LblUsuario.Text = usuario;

                if (dados[1] != "0") // Usuario Normal, desabilitar botoes
                {
                    tela.BtnAtualizar.Enabled = false;
                    tela.BtnExcluir.Enabled = false;
                    tela.BtnNovo.Enabled = false;
                    tela.btntrocar.Enabled = false;
                }
                tela.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos!");
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            TxtUsuario.BackColor = Color.Yellow;
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            TxtUsuario.BackColor = Color.White;
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            TxtSenha.BackColor = Color.Yellow;
            string caminho = Application.StartupPath + "\\Imagens\\";
            pictureBoxLogin.ImageLocation = caminho + "Senha.jpg";
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            TxtSenha.BackColor = Color.White;
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caminho = Application.StartupPath + "\\Imagens\\";
            pictureBoxLogin.ImageLocation = caminho + TxtUsuario.Text.Length + ".jpg";
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastroUsuario tela = new TelaCadastroUsuario();
            tela.Show();


        }

    }
}
