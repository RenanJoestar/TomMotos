using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomMotos.Model
{
    class ServicoModel
    {
        public int id_servico_prestado { get; set; }
        public string descricao_servico_prestado { get; set; }
        public double valor_servico_prestado { get; set; }
        public int fk_venda_id { get; set; }
    }
}
