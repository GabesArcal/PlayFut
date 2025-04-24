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
        public string nome { get; set; }
        public string imagem { get; set; }
        public string imagem_secundaria { get; set; }
        public string imagem_terceira { get; set; }
        public string imagem_quarta { get; set; }
        public decimal preco { get; set; }
        public string dimensoes { get; set; }
        public bool iluminacao { get; set; }
        public bool sintetico { get; set; }
        public int capacidade { get; set; }
        public bool vestiario { get; set; }
        public bool bebedouro { get; set; }
        public bool estacionamento { get; set; }
        public string localizacao { get; set; }
        public decimal desconto { get; set; }
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
            string query = $"INSERT INTO quadras (nome, imagem, imagem_secundaria, imagem_terceira, imagem_quarta, preco, dimensoes, iluminacao, sintetico, capacidade, vestiario, bebedouro, estacionamento, localizacao, desconto, arquibancada, coberta, tipo_quadra, acessibilidade, wifi) VALUES ('{nome}', '{imagem}', '{imagem_secundaria}', '{imagem_terceira}', '{imagem_quarta}', {preco}, '{dimensoes}', '{iluminacao}', {sintetico}, {capacidade}, {vestiario}, {bebedouro}, {estacionamento}, '{localizacao}', {desconto}, {arquibancada}, {coberta}, '{tipo_quadra}', {acessibilidade}, {wifi});";
            conexao.ExecutaComando(query);
            Console.WriteLine("Quadra inserida com sucesso!");
        }

        public List<Quadra> BuscaTodos()
        {
            DataTable dt = conexao.ExecutaSelect("SELECT * FROM usuarios;");

            List<Quadra> lista = new List<Quadra>();

            foreach (DataRow linha in dt.Rows)
            {
                Quadra p = new Quadra();

                p.id = int.Parse(linha["id"].ToString());
                p.nome = linha["nome"].ToString();
                p.imagem = linha["imagem"].ToString();
                p.imagem_secundaria = linha["imagem_secundaria"].ToString();
                p.imagem_terceira = linha["imagem_terceira"].ToString();
                p.imagem_quarta = linha["imagem_quarta"].ToString();
                p.preco = decimal.Parse(linha["preco"].ToString());
                p.dimensoes = linha["dimensoes"].ToString();
                p.iluminacao = Convert.ToBoolean(linha["iluminacao"]);
                p.sintetico = bool.Parse(linha["sintetico"].ToString());
                p.capacidade = int.Parse(linha["capacidade"].ToString());
                p.vestiario = bool.Parse(linha["vestiario"].ToString());
                p.bebedouro = bool.Parse(linha["bebedouro"].ToString());
                p.estacionamento = bool.Parse(linha["estacionamento"].ToString());
                p.localizacao = linha["localizacao"].ToString();
                p.desconto = decimal.Parse(linha["desconto"].ToString());
                p.arquibancada = bool.Parse(linha["arquibancada"].ToString());
                p.coberta = bool.Parse(linha["coberta"].ToString());
                p.tipo_quadra = linha["tipo_quadra"].ToString();
                p.acessibilidade = bool.Parse(linha["acessibilidade"].ToString());
                p.wifi = bool.Parse(linha["wifi"].ToString());

                lista.Add(p);
            }


            return lista;

        }

    }
}
