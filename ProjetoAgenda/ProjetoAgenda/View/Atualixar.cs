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
    public partial class Atualixar : Form
    {
        public Atualixar()
        {
            InitializeComponent();
        }

        private void Atualixar_Load(object sender, EventArgs e)
        {
            DataTable tabela = new DataTable();
            Controle_Login controle = new Controle_Login();
            tabela = controle.Consultar();
            TabelaContatos.DataSource = tabela;
            TabelaContatos.Refresh();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TabelaContatos.SelectedCells[0].Value.ToString());
            Controle_Login controle = new Controle_Login();
            int resp = controle.Excluir_Contato(id);
            if (resp > 0)
            {
                MessageBox.Show("Contato excluído com sucesso!");

                DataTable dt = new DataTable();
                controle = new Controle_Login();
                dt = controle.Consultar();
                TabelaContatos.DataSource = dt;
                TabelaContatos.Refresh();
            }
            else
            {
                MessageBox.Show("Impossível excluir o contato!");
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Controle_Login controle = new Controle_Login();
            dt = controle.Consultar_nome(TxtConsultar.Text);
            TabelaContatos.DataSource = dt;
            TabelaContatos.Refresh();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPrincipal principal = new TelaPrincipal();
            principal.Show();
        }
    }
}
