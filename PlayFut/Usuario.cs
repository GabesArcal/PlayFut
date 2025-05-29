using System.Data;

namespace PlayFut
{
    internal class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public DateTime nascimento { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public DateTime criado_em { get; set; }

        public string cpf_formatado
        {
            get
            {
                if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
                    return cpf;

                return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            }
        }

        Conexao conexao { get; set; }

        public Usuario()
        {
            conexao = new Conexao();
        }

        public void Insere()
        {
            string query = $"INSERT INTO usuarios (nome, telefone, nascimento, email, cpf, senha ) VALUES ( '{nome}', '{telefone}', '{FormataData(nascimento)}', '{email}', '{cpf}', '{senha}');";
            conexao.ExecutaComando(query);
            Console.WriteLine("Usuario inserido com sucesso!");
        }

        public List<Usuario> BuscaTodos()
        {
            DataTable dt = conexao.ExecutaSelect("SELECT * FROM usuarios;");

            List<Usuario> lista = new List<Usuario>();

            foreach (DataRow linha in dt.Rows)
            {
                Usuario p = new Usuario
                {
                    id = int.Parse(linha["id"].ToString()),
                    nome = linha["nome"].ToString(),
                    telefone = linha["telefone"].ToString(),
                    nascimento = DateTime.Parse(linha["nascimento"].ToString()),
                    email = linha["email"].ToString(),
                    cpf = linha["cpf"].ToString(),
                    senha = linha["senha"].ToString(),
                    criado_em = DateTime.Parse(linha["criado_em"].ToString())
                };

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
