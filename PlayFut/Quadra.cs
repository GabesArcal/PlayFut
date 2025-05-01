using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.ApplicationModel.Communication;

namespace PlayFut
{
    internal class Quadra
    {
        public int id { get; set; }
        public string nome_local { get; set; }
        public string tipo_quadra { get; set; }
        public string localizacao { get; set; }
        public string imagem_principal { get; set; }
        public string imagem_pri { get; set; }
        public string imagem_seg { get; set; }
        public string imagem_ter { get; set; }
        public string telefone { get; set; }
        public string disponibilidade { get; set; }
        public decimal preco { get; set; }
        public string dimensoes { get; set; }
        public bool iluminacao { get; set; }
        public bool vestiario { get; set; }
        public bool bebedouro { get; set; }
        public bool estacionamento { get; set; }
        public bool arquibancada { get; set; }
        public bool coberta { get; set; }
        public bool acessibilidade { get; set; }
        public bool wifi { get; set; }

        Conexao conexao { get; set; }

        public Quadra()
        {
            conexao = new Conexao();
        }

        public void Insere()
        {
            string query = $"INSERT INTO quadras (nome_local, tipo_quadra, localizacao, imagem_principal, imagem_pri, imagem_seg, imagem_ter, telefone, disponibilidade, preco, dimensoes, iluminacao, vestiario, bebedouro, estacionamento, arquibancada, coberta,  acessibilidade, wifi) VALUES ('{nome_local}', '{tipo_quadra}', '{imagem_principal}', '{imagem_pri}', '{imagem_seg}', '{imagem_ter}', '{telefone}', '{disponibilidade}' {preco}, '{dimensoes}', '{iluminacao}', {vestiario}, {bebedouro}, {estacionamento}, {arquibancada}, {coberta}, {acessibilidade}, {wifi});";
            conexao.ExecutaComando(query);
            Console.WriteLine("Quadra inserida com sucesso!");
        }

        public List<Quadra> BuscaTodos()
        {
            DataTable dt = conexao.ExecutaSelect("SELECT * FROM quadras;");

            List<Quadra> lista = new List<Quadra>();

            foreach (DataRow linha in dt.Rows)
            {
                Quadra q = new Quadra();

                q.id = Convert.ToInt32(linha["id"]);
                q.nome_local = linha["nome_local"].ToString();
                q.tipo_quadra = linha["tipo_quadra"].ToString();
                q.localizacao = linha["localizacao"].ToString();
                q.imagem_principal = linha["imagem_principal"].ToString();
                q.imagem_pri = linha["imagem_pri"].ToString();
                q.imagem_seg = linha["imagem_seg"].ToString();
                q.imagem_ter = linha["imagem_ter"].ToString();
                q.telefone = linha["telefone"].ToString();
                q.disponibilidade = linha["disponibilidade"].ToString();
                q.preco = Convert.ToDecimal(linha["preco"]);
                q.dimensoes = linha["dimensoes"].ToString();
                q.iluminacao = Convert.ToBoolean(linha["iluminacao"]);
                q.vestiario = Convert.ToBoolean(linha["vestiario"]);
                q.bebedouro = Convert.ToBoolean(linha["bebedouro"]);
                q.estacionamento = Convert.ToBoolean(linha["estacionamento"]);
                q.arquibancada = Convert.ToBoolean(linha["arquibancada"]);
                q.coberta = Convert.ToBoolean(linha["coberta"]);
                q.acessibilidade = Convert.ToBoolean(linha["acessibilidade"]);
                q.wifi = Convert.ToBoolean(linha["wifi"]);

                lista.Add(q);
            }


            return lista;

        }

    }
}
