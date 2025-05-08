using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PlayFut
{
    class Conexao
    {
        // Corrigido: charset adicionado para suporte a acentuação e símbolos especiais
        private readonly string dadosConexao = "server=localhost;user=root;password=;database=playfut;port=3306;charset=utf8mb4;";

        public int ExecutaComando(string query)
        {
            try
            {
                using (var conexao = new MySqlConnection(dadosConexao))
                {
                    conexao.Open();
                    using (var comando = new MySqlCommand(query, conexao))
                    {
                        return comando.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao executar comando no banco de dados: " + ex.Message, ex);
            }
        }

        public DataTable ExecutaSelect(string query)
        {
            var dt = new DataTable();
            try
            {
                using (var conexao = new MySqlConnection(dadosConexao))
                {
                    conexao.Open();
                    using (var comando = new MySqlCommand(query, conexao))
                    {
                        using (var adapter = new MySqlDataAdapter(comando))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao executar SELECT no banco de dados: " + ex.Message, ex);
            }

            return dt;
        }
    }
}
