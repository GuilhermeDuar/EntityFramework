using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ClienteBLL
    {
        public void Select()
        {
            using (ERPDbContext db = new ERPDbContext())
            {
                List<ClienteQueryViewModel> clienteCompacto = db.Clientes.Select(c => new ClienteQueryViewModel()
                {
                    ID = c.ID,
                    Nome = c.Nome,
                }).ToList();
                                                    // pega a categoria, caso nn fizer tras null em produto[0].Categoria
                List<Produto> produto = db.Produtos.Include(p => p.Categoria).Where(p => p.Preco > 100 && p.estoque < 50).ToList();
                string desc = produto[0].Categoria.Descricao;

                List<Venda> venda = db.Vendas.Include(v => v.Itens).ToList();
            }
        }
    }
    public class ClienteQueryViewModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }

    }


}
