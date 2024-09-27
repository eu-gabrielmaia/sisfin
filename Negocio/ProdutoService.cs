using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ProdutoService
    {
        private readonly ProdutoRepository _repository;

        public ProdutoService()
        {
            _repository = new ProdutoRepository();
        }

        public void Insert(int id, string nome, double preco)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var produto = new Produto
            {
                Id = id,
                Nome = nome,
                Preco = preco
            };

            _repository.Insert(produto);

        }

        public void Insert(Produto produto)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(produto);

        }

        public Produto FindById(int id)
        {
            foreach (Produto c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<Produto> getAll()
        {
            return _repository.ObterTodos().ToList<Produto>();
        }

    }
}
