using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
