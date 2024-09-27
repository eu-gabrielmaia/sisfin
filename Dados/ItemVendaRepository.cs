using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemVendaRepository
    {
        private IList<ItemVenda> _itens = new List<ItemVenda>();

        public ItemVenda Insert(ItemVenda itemVenda)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._itens.Add(itemVenda);
            return itemVenda;
        }

        public ItemVenda Update(ItemVenda itemVenda)
        {
            this._itens[this._itens.IndexOf(itemVenda)] = itemVenda;
            return itemVenda;
        }

        public void Remove(ItemVenda itemVenda)
        {
            this._itens.Remove(itemVenda);
        }

        public IEnumerable<ItemVenda> ObterTodos()
        {
            return _itens;
        }

        public IList<ItemVenda> getAll()
        {
            return _itens;
        }

        public IList<ItemVenda> getItemsVendaPorVendaId(int id)
        {
            return _itens.Where(item => item.Venda.Id == id).ToList();
        }
        public IList<ItemVenda> getItemsVendaPorProdutoId(int id)
        {
            return _itens.Where(item => item.Produto.Id == id).ToList();
        }
    }
}
