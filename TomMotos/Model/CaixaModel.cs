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
        public DateTime validade_orcamento_servico { get; set; }
        public double desconto { get; set; }
        public static double valor_pago { get; set; }
        public static string id_orcamento { get; set; }
        public double total { get; set; }
        public static string fk_veiculo_id { get; set; }
        public static string emailCliente { get; set; }
        public static string fk_cliente_id { get; set; }
        public static string valorPesquisa { get; set; }
        public static bool eOrcamento { get; set; }
        public static bool vendaFinalizada { get; set; }
        public static string totalVenda_orcamento { get; set; }

    }
}
