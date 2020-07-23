using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext context;
        public ProdutoDAOEntity()
        {
            this.context = new LojaContext();
        }
        public void Dispose()
        {
            context.Dispose();
        }
        public void Adicionar(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            context.Produtos.Update(produto);
            context.SaveChanges();
        }

        public IList<Produto> Produtos()
        {
            return context.Produtos.ToList();
        }

        public void Remover(Produto produto)
        {
            context.Produtos.Remove(produto);
            context.SaveChanges();
        }
    }
}
