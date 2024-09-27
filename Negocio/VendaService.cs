using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class VendaService
    {
        private readonly VendaRepository _repository;

        public VendaService()
        {
            _repository = new VendaRepository();
        }

        public void Insert(int id, Cliente cliente, DateTime instante, string descricao, double desconto, double valorTotal)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var venda = new Venda
            {
                Id = id,
                Cliente = cliente,
                Instante = instante,
                Descricao = descricao,
                Desconto = desconto,
                ValorTotal = valorTotal
            };

            _repository.Insert(venda);

        }

        public void Insert(Venda venda)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(venda);

        }

        public Venda FindById(int id)
        {
            foreach (Venda c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }


        public IEnumerable<Venda> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<Venda> getAll()
        {
            return _repository.getAll();
        }

    }
}
