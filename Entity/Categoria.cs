using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }

    }
}
