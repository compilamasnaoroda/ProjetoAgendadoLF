using ProjetoAgenda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class Controle_Login
    {
        private Modelo_Login modelo;

        public Controle_Login()
        {
            modelo = new Modelo_Login();
        }

        public int Inserir_Usuario(string user,string password,int type)
        {
            //Seto o usuario na modelo
            modelo.usuario = user;

            //Encriptar a Senha com o Hash
            modelo.senha = BCrypt.Net.BCrypt.HashPassword(password);
            modelo.tipo = type;
            return modelo.Inserir();
        }

        public List<string> Logar(string usuario,string senha)
        {
            List<string> Dados = new List<string>();
            modelo.usuario = usuario;
            Dados = modelo.Logar();
            return Dados;
        }

        public int Atualizar_Usuario(int cod, string user, string password, int type)
        {
            modelo.id = cod;
            modelo.usuario = user;
            modelo.senha = password;
            modelo.tipo = type;
            return modelo.Atualizar();
        }

        public int Excluir_Usuario(int cod)
        {
            modelo.id = cod;
            return modelo.Excluir();
        }

        public DataTable Listar_Usuarios()
        {
            return modelo.Listar();
        }
        public DataTable Consultar()
        {
            return modelo.Consultar_usuarios();
        }
        public int Excluir_Contato(int COD)
        {
            return modelo.Excluir(COD);
        }
        public DataTable Consultar_nome(string nome)
        {
            return modelo.Consultar_Nome(nome);
        }

    }
}
