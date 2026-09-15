using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace ProjetoAgenda.Model
{
    internal class Modelo_Contatos
    {
        private string caminho = @"URI=file:" + Application.StartupPath + "\\DBAgenda.db";
        //Implementar os campos da tabela contatos
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }

        public int Inserir()
        {
            var conexao = new SQLiteConnection(caminho);
            conexao.Open();
            var query = new SQLiteCommand(conexao);
            query.CommandText = "INSERT INTO TBContatos(NOME,TELEFONE) VALUES(@name,@tel)";
            query.Parameters.AddWithValue("@name", nome);
            query.Parameters.AddWithValue("@tel", telefone);
            query.Prepare();
            int linhasAfetadas = query.ExecuteNonQuery();
            conexao.Close();

            return linhasAfetadas;
        }

        public int Atualizar()
        {
            var conexao = new SQLiteConnection(caminho);
            conexao.Open();
            var query = new SQLiteCommand(conexao);
            query.CommandText = "UPDATE TBContatos SET NOME = @name, TELEFONE = @tel WHERE ID = @id ";
            query.Parameters.AddWithValue("@name", nome);
            query.Parameters.AddWithValue("@tel", telefone);
            query.Parameters.AddWithValue("@id", id);
            query.Prepare();
            int linhasAfetadas = query.ExecuteNonQuery();
            conexao.Close();

            return linhasAfetadas;
        }

        public int Excluir(int ID)
        {
            var conexao = new SQLiteConnection(caminho);
            conexao.Open();
            var query = new SQLiteCommand(conexao);
            query.CommandText = "DELETE FROM TBContatos WHERE TBContatos.ID = @id";
            query.Parameters.AddWithValue("@id", ID);

            query.Prepare();
            int linhasAfetadas = query.ExecuteNonQuery();
            conexao.Close();

            return linhasAfetadas;
        }

        public DataTable Consultar()
        {
            var Conexao = new SQLiteConnection(caminho);
            Conexao.Open();
            DataTable dados = new DataTable();

            var query = new SQLiteCommand(Conexao);
            query.CommandText = "SELECT *FROM TBContatos";

            SQLiteDataReader leitorDados = query.ExecuteReader();
            dados.Load(leitorDados);
            Conexao.Close();

            return dados;
        }

        

        public DataTable Consultar_Nome(string nome)
        {
            var Conexao = new SQLiteConnection(caminho);
            Conexao.Open();
            DataTable dados = new DataTable();

            var query = new SQLiteCommand(Conexao);
            query.CommandText = "SELECT *FROM TBContatos WHERE TBContatos.NOME LIKE @nome";
            query.Parameters.AddWithValue("@nome","%" + nome + "%");

            SQLiteDataReader leitorDados = query.ExecuteReader();
            dados.Load(leitorDados);
            Conexao.Close();

            return dados;
        }


    }
}
