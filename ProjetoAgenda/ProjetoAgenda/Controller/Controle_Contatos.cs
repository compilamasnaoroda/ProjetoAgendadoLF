using ProjetoAgenda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class Controle_Contatos
    {
        private Modelo_Contatos modelo;

        public Controle_Contatos()
        {
            modelo = new Modelo_Contatos();
        }

        public int InserirContato(string NOME,string TELEFONE)
        {
            modelo.nome = NOME;
            modelo.telefone = TELEFONE;
            return modelo.Inserir();
        }

        public DataTable Consultar()
        {
            return modelo.Consultar();
        }

        public DataTable Consultar_nome(string nome)
        {
            return modelo.Consultar_Nome(nome);
        }

        public int Excluir_Contato(int COD)
        {
            return modelo.Excluir(COD);
        }

        public int Atualizar(int COD, string nome, string telefone)
        {
            modelo.id = COD;
            modelo.nome = nome;
            modelo.telefone = telefone;
            return modelo.Atualizar();
        }

    }
}
