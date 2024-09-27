using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ProdutoRepository
    {
        private IList<Produto> _produtos = new List<Produto>();

        public Produto Insert(Produto produto)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._produtos.Add(produto);
            return produto;
        }

        public Produto Update(Produto produto)
        {
            this._produtos[this._produtos.IndexOf(produto)] = produto;
            return produto;
        }

        public void Remove(Produto produto)
        {
            this._produtos.Remove(produto);
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _produtos;
        }

        public IList<Produto> getAll()
        {
            return _produtos;
        }
    }
}
