using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
        public double Preco { get; set; }
    }
}
