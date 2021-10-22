using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomMotos.Model
{
    class CaixaModel
    {
        public string id_venda { get; set; }
        public string descricao { get; set; }
        public DateTime validade_orcamento_servico { get; set; }
        public double preco_mao_de_obra { get; set; }
        public int fk_veiculo_id { get; set; }
        public int fk_cliente_id { get; set; }
    }
}
