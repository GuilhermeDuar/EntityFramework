using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Venda
    {
        public int ID { get; set; }
        public double Total { get; set; }
        public DateTime DataVenda { get; set; }

        public ICollection<ItensVenda> Itens { get; set; }

    }
}
