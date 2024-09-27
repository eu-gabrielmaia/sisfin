using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using MySql.Data.MySqlClient;

namespace Negocio
{
    public class ClienteService
    {
        private ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public string Update(int? id, TipoPessoa tipoPessoa, string nome, string email)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var cliente = new Cliente
            {
                Id = id,
                tipoPessoa = tipoPessoa,
                Nome = nome,
                Email = email
            };

            if (id == null)
                return _repository.Insert(cliente);
            else
                return _repository.Update(cliente);

        }

        public string Insert(Cliente cliente)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Insert(cliente);

        }
        public string Remove(int idCliente)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Remove(idCliente);

        }

        public DataTable getAll()
        {
            return _repository.getAll();
        }
        public DataTable filterByName(string nome)
        {
            return _repository.filterByName(nome);
        }

    }
}
