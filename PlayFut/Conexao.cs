using PlayFut;
using MySql.Data.MySqlClient;
using System.Data;

namespace PlayFut
{
    class Conexao
    {
        string dadosConexao = "server=localhost;user=meuusuario;password=asd123;database=playfut;port=3306;";


        public int ExecutaComando(string query)
        {
            using (var conexao = new MySqlConnection(dadosConexao))
            {
                conexao.Open();
                using var comando = new MySqlCommand(query, conexao);
                return comando.ExecuteNonQuery();
            } // A conexão fecha automaticamente pelo using
        }

        public DataTable ExecutaSelect(string query)
        {
            var dt = new DataTable();
            using (var conexao = new MySqlConnection(dadosConexao))
            {
                conexao.Open();
                using var comando = new MySqlCommand(query, conexao);
                using var adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            return dt;
        }

    }
}