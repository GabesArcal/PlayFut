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
        public decimal preco { get; set; }
        public string imagem_principal { get; set; }
        public string imagem_1 { get; set; }
        public string imagem_2 { get; set; }
        public string imagem_3 { get; set; }
        public string dimensoes { get; set; }
        public bool iluminacao { get; set; }
        public bool vestiario { get; set; }
        public bool bebedouro { get; set; }
        public bool estacionamento { get; set; }
        public string localizacao { get; set; }
        public bool arquibancada { get; set; }
        public bool coberta { get; set; }
        public string tipo_quadra { get; set; }
        public bool acessibilidade { get; set; }
        public bool wifi { get; set; }

        Conexao conexao { get; set; }

        public Quadra()
        {
            conexao = new Conexao();
        }

        public void Insere()
        {
            string query = $"INSERT INTO quadras (nome_local, imagem_principal, imagem_1, imagem_2, imagem_3, preco, dimensoes, iluminacao, vestiario, bebedouro, estacionamento, localizacao, arquibancada, coberta, tipo_quadra, acessibilidade, wifi) VALUES ('{nome_local}', '{imagem_principal}', '{imagem_1}', '{imagem_2}', '{imagem_3}', {preco}, '{dimensoes}', '{iluminacao}', {vestiario}, {bebedouro}, {estacionamento}, '{localizacao}', {arquibancada}, {coberta}, '{tipo_quadra}', {acessibilidade}, {wifi});";
            conexao.ExecutaComando(query);
            Console.WriteLine("Quadra inserida com sucesso!");
        }

        public List<Quadra> BuscaTodos()
        {
            DataTable dt = conexao.ExecutaSelect("SELECT * FROM quadras;");

            List<Quadra> lista = new List<Quadra>();

            foreach (DataRow linha in dt.Rows)
            {
                Quadra p = new Quadra();

                p.id = Convert.ToInt32(linha["id"]);
                p.nome_local = linha["nome_local"].ToString();
                p.tipo_quadra = linha["tipo_quadra"].ToString();
                p.localizacao = linha["localizacao"].ToString();

                p.imagem_principal = linha["imagem_principal"].ToString();
                p.imagem_1 = linha["imagem_1"].ToString();
                p.imagem_2 = linha["imagem_2"].ToString();
                p.imagem_3 = linha["imagem_3"].ToString();

                p.preco = Convert.ToDecimal(linha["preco"]);
                p.dimensoes = linha["dimensoes"].ToString();

                p.iluminacao = Convert.ToBoolean(linha["iluminacao"]);
                p.vestiario = Convert.ToBoolean(linha["vestiario"]);
                p.bebedouro = Convert.ToBoolean(linha["bebedouro"]);
                p.estacionamento = Convert.ToBoolean(linha["estacionamento"]);
                p.arquibancada = Convert.ToBoolean(linha["arquibancada"]);
                p.coberta = Convert.ToBoolean(linha["coberta"]);
                p.acessibilidade = Convert.ToBoolean(linha["acessibilidade"]);
                p.wifi = Convert.ToBoolean(linha["wifi"]);

                lista.Add(p);
            }


            return lista;

        }

    }
}
