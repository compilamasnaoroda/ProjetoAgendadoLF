using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Model
{
    internal class Modelo_Login
    {
        private string caminho = @"URI=file:" + Application.StartupPath + "\\DBAgenda.db";
        //Implementar os campos da tabela Login
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public int tipo { get; set; }

        public int Inserir()
        {
            var conexao = new SQLiteConnection(caminho);
            conexao.Open();
            var query = new SQLiteCommand(conexao);
            query.CommandText = "INSERT INTO TBLogin(USUARIO,SENHA,TIPO) VALUES (@user,@pass,@type)";
            query.Parameters.AddWithValue("@user", usuario);
            query.Parameters.AddWithValue("@pass", senha);
            query.Parameters.AddWithValue("@type", tipo);
            query.Prepare();
            int linha = query.ExecuteNonQuery();
            conexao.Close();
            return linha;
        }

        public List<string> Logar()
        {
            List<string> Dados = new List<string>();
            var conexao = new SQLiteConnection(caminho);
            conexao.Open();
            var query = new SQLiteCommand(conexao);
            query.CommandText = "SELECT SENHA,TIPO FROM TBLogin WHERE USUARIO = @user";
            query.Parameters.AddWithValue("@user", usuario);

            string HashBanco = string.Empty;
            string Tipousuario = string.Empty;

            using(SQLiteDataReader leitor =  query.ExecuteReader())
            {
                if(leitor.Read())
                {
                    HashBanco = leitor["SENHA"].ToString();
                    Tipousuario = leitor["TIPO"].ToString();
                }
            }
            query.Prepare();
            query.ExecuteNonQuery();
            conexao.Close();
            Dados.Add(HashBanco);
            Dados.Add(Tipousuario);
            return Dados;
        }

        public int Atualizar()
        {
            return 1;
        }

        public int Excluir()
        {
            return 1;
        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();

            return tabela;
        }
        public DataTable Consultar_usuarios()
        {
            var Conexao = new SQLiteConnection(caminho);
            Conexao.Open();
            DataTable dados = new DataTable();

            var query = new SQLiteCommand(Conexao);
            query.CommandText = "SELECT USUARIO, TIPO , ID  FROM TBLogin";

            SQLiteDataReader leitorDados = query.ExecuteReader();
            dados.Load(leitorDados);
            Conexao.Close();

            return dados;
        }
        public int Excluir(int id)
        {
            var conexao = new SQLiteConnection(caminho);
            conexao.Open();
            var query = new SQLiteCommand(conexao);
            query.CommandText = "DELETE FROM TBLogin WHERE ID = @id";
            query.Parameters.AddWithValue("@id", id);

            query.Prepare();
            int linhasAfetadas = query.ExecuteNonQuery();
            conexao.Close();

            return linhasAfetadas;
        }
        public DataTable Consultar_Nome(string usuario)
        {
            var Conexao = new SQLiteConnection(caminho);
            Conexao.Open();
            DataTable dados = new DataTable();

            var query = new SQLiteCommand(Conexao);
            query.CommandText = "SELECT USUARIO, TIPO , ID  FROM TBLogin WHERE TBLogin.USUARIO LIKE @usuario";
            query.Parameters.AddWithValue("@usuario", "%" + usuario + "%");

            SQLiteDataReader leitorDados = query.ExecuteReader();
            dados.Load(leitorDados);
            Conexao.Close();

            return dados;
        }
    }
}
