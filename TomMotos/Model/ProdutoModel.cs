using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomMotos.Model
{
    class ProdutoModel
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public int quantidade_virtual { get; set; }
        public double valor { get; set; }
        public string marca { get; set; }
        public byte[] imagem { get; set; }
       
    }
}
