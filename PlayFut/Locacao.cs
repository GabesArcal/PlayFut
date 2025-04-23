using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayFut
{
    internal class Locacao
    {
        public int id { get; set; }
        public int id_quadra { get; set; }
        public int id_usuario { get; set; }
        public string data { get; set; }
        public required string hora { get; set; }
    }
}
