using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.View
{
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
            
        }
        public int controle_salvar = 0, id;

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin p = new TelaLogin();
            p.Show();
        }

        private void Txtusuario_Enter(object sender, EventArgs e)
        {
            Txtusuario.BackColor = Color.Yellow;
        }

        private void Txtusuario_Leave(object sender, EventArgs e)
        {
            Txtusuario.BackColor = Color.White;
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            TxtSenha.BackColor = Color.Yellow;
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            TxtSenha.BackColor = Color.White;
        }

        private void comboBoxTipo_Enter(object sender, EventArgs e)
        {
            comboBoxTipo.BackColor = Color.Yellow;
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Controle_Login controle = new Controle_Login();
            string usuario = Txtusuario.Text;
            string senha = TxtSenha.Text;

            int tipo = comboBoxTipo.SelectedIndex;

            //verificar se vem do Botao Novo ou do Botao Atualizar
            if (controle_salvar != 0)
            {
               

               
            }
            else
            {
                //Insert
                int resp = controle.Inserir_Usuario(usuario, senha, tipo);
                if(resp>0)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o usuário!");
                }


            }
        }
    }
}
