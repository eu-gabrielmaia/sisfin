using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ItemVendaService
    {
        private readonly ItemVendaRepository _repository;

        public ItemVendaService()
        {
            _repository = new ItemVendaRepository();
        }

        public void Insert(int id, Venda venda, Produto produto, double quantidade, double desconto, double preco)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var item = new ItemVenda
            {
                Id = id,
                Venda = venda,
                Produto = produto,
                Quantidade = quantidade,
                Desconto = desconto,
                Preco = preco
            };

            _repository.Insert(item);

        }

        public void Insert(ItemVenda itemVenda)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(itemVenda);

        }


        public ItemVenda FindById(int id)
        {
            foreach (ItemVenda c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public ItemVenda FindByVendaId(int id)
        {
            foreach (ItemVenda c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<ItemVenda> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<ItemVenda> getAll()
        {
            return _repository.getAll();
        }

        public IList<ItemVenda> getItensPorVendaId(int id)
        {
            return _repository.getItemsVendaPorVendaId(id);
        }
    }
}
