using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class VendaRepository
    {
        private IList<Venda> _vendas = new List<Venda>();

        public Venda Insert(Venda venda)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._vendas.Add(venda);
            return venda;
        }

        public Venda Update(Venda venda)
        {
            this._vendas[this._vendas.IndexOf(venda)] = venda;
            return venda;
        }

        public void Remove(Venda venda)
        {
            this._vendas.Remove(venda);
        }

        public IEnumerable<Venda> ObterTodos()
        {
            return _vendas;
        }

        public IList<Venda> getAll()
        {
            return _vendas;
        }

        public IList<Venda> getVendasPorClienteId(int id)
        {
            return _vendas.Where(v => v.Cliente.Id == id).ToList();
        }
    }
}
