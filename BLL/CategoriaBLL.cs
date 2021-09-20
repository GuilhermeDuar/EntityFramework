using DAL;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CategoriaBLL
    {
        public void Insert(Categoria c)
        {
            using (ERPDbContext db = new ERPDbContext())
            {
                db.Categorias.Add(c);
                db.SaveChanges();
            }
        }

        public void Update(Categoria categoria)
        {
            using (ERPDbContext db = new ERPDbContext())
            {
                // altera todas as colunas, caso tenha GVM pode estourar
                db.Entry(categoria).State = EntityState.Modified;
                db.SaveChanges();
            }

            // update via Tracking
            using (ERPDbContext db = new ERPDbContext())
            {
                Categoria c = db.Categorias.Find(categoria.ID);
                c.Descricao = categoria.Descricao;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (ERPDbContext db = new ERPDbContext())
            {
                Categoria c = new Categoria()
                {
                    ID = id
                };
                db.Categorias.Remove(c);
                db.SaveChanges();
            }
        }

        public void Select()
        {
            using (ERPDbContext db = new ERPDbContext())
            {
                // List<Categoria> categorias = db.Categorias.ToList(); select * from categorias

                // int pageSize = 5;  n por paginas
                // int pageNumber = 1;  n da pagina
                // List<Categoria> categorias = db.Categorias.Skip(pageSize * pageNumber).Take(pageSize).ToList();

            }
        }

    }
}
