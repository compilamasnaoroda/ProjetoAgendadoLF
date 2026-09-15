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
    public partial class TelaPrincipal : Form
    {
        public int controle_salvar = 0,id;
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Controle_Contatos controle = new Controle_Contatos();
            //verificar se vem do Botao Novo ou do Botao Atualizar
            if (controle_salvar!=0)
            {
                //Update
                
                int resp = controle.Atualizar(id,TxtNome.Text,TxtTelefone.Text);

                if (resp > 0)
                {
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Impossível atualizar o cadastro!");
                }
            }
            else
            {
                //Insert
            string nome = TxtNome.Text;
            string telefone = TxtTelefone.Text;

            int LinhaAfetada = controle.InserirContato(nome, telefone);

            if (LinhaAfetada > 0)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }

            
            }

            DataTable tabela = new DataTable();
            controle = new Controle_Contatos();
            tabela = controle.Consultar();
            TabelaContatos.DataSource = tabela;
            TabelaContatos.Refresh();

            TxtNome.Text = "";
            TxtTelefone.Text = "";

            groupBoxCadastro.Visible = false;


        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            DataTable tabela = new DataTable();
            Controle_Contatos controle = new Controle_Contatos();
            tabela = controle.Consultar();
            TabelaContatos.DataSource = tabela;
            TabelaContatos.Refresh();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Controle_Contatos controle = new Controle_Contatos();
            dt = controle.Consultar_nome(TxtConsultar.Text);
            TabelaContatos.DataSource= dt;
            TabelaContatos.Refresh();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TabelaContatos.SelectedCells[0].Value.ToString());
            Controle_Contatos controle = new Controle_Contatos();
            int resp = controle.Excluir_Contato(id);
            if (resp > 0)
            {
                MessageBox.Show("Contato excluído com sucesso!");

                DataTable dt = new DataTable();
                controle = new Controle_Contatos();
                dt = controle.Consultar();
                TabelaContatos.DataSource = dt;
                TabelaContatos.Refresh();
            }
            else
            {
                MessageBox.Show("Impossível excluir o contato!");
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            controle_salvar = 0;

            groupBoxCadastro.Visible = true;

            TxtNome.Text = "";
            TxtTelefone.Text = "";

            TxtNome.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin tela = new TelaLogin();
            tela.Show();
        }

        private void TxtConsultar_Enter(object sender, EventArgs e)
        {
            TxtConsultar.BackColor = Color.Yellow;
        }

        private void TxtConsultar_Leave(object sender, EventArgs e)
        {
            TxtConsultar.BackColor = Color.White;
        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            TxtNome.BackColor = Color.Yellow;
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            TxtNome.BackColor = Color.White;
        }

        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            TxtTelefone.BackColor = Color.Yellow;
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            TxtTelefone.BackColor = Color.White;
        }

        private void btntrocar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atualixar p = new Atualixar();




            p.Show();
        }

        private void TabelaContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtConsultar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            groupBoxCadastro.Visible = true;
            TxtNome.Text = TabelaContatos.CurrentRow.Cells["NOME"].Value.ToString();
            TxtTelefone.Text = TabelaContatos.CurrentRow.Cells["TELEFONE"].Value.ToString();

            id = int.Parse(TabelaContatos.CurrentRow.Cells["ID"].Value.ToString());
            controle_salvar = 1;

            TxtNome.Focus();

        }
    }
}
