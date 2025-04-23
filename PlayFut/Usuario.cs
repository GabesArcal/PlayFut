using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayFut
{
    internal class Usuario
    {

        public int id { get; set; }
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public DateTime criado_em { get; set; }

        Conexao conexao { get; set; }

        public Usuario()
        {
            conexao = new Conexao();
        }

        public void Insere()
        {
            string query = $"INSERT INTO usuarios (nome, nascimento, email, cpf, senha ) VALUES ( '{nome}', '{FormataData(nascimento)}', '{email}', '{cpf}', '{senha}');";
            conexao.ExecutaComando(query);
            Console.WriteLine("Usuario inserido com sucesso!");
        }

        public List<Usuario> BuscaTodos()
        {
            DataTable dt = conexao.ExecutaSelect("SELECT * FROM usuarios;");

            List<Usuario> lista = new List<Usuario>();

            foreach (DataRow linha in dt.Rows)
            {

                Usuario p = new Usuario();

                p.id = int.Parse(linha["id"].ToString());
                p.nome = linha["nome"].ToString();
                p.nascimento = DateTime.Parse(linha["nascimento"].ToString());
                p.email = linha["email"].ToString();
                p.cpf = linha["cpf"].ToString();
                p.senha = linha["senha"].ToString();
                p.criado_em = DateTime.Parse(linha["criado_em"].ToString());

                lista.Add(p);

            }

            return lista;

        }

        public string FormataData(DateTime data)
        {
            string nascimento = data.Date.ToString();
            nascimento = nascimento.Split(" ")[0];
            nascimento = string.Join("-", nascimento.Split("/").Reverse());
            return nascimento;
        }

    }
}
