using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class FornecedorService
    {
        private FornecedorRepository _repository;

        public FornecedorService()
        {
            _repository = new FornecedorRepository();
        }

        public string Update(int? id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, string razao_social, string rua, string numero, string bairro, string cidade, string complemento, string cep, string telefone, string celular)
        {
            Fornecedor fornecedor = new Fornecedor(id, tipoPessoa, nome, email, cpf_cnpj, razao_social, rua, numero, bairro, cidade, complemento, cep, telefone, celular);

            if (fornecedor.Id == null)
                return _repository.Insert(fornecedor);
            else
                return _repository.Update(fornecedor);
        }

        public string Insert(Fornecedor fornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Insert(fornecedor);

        }
        public string Remove(int idFornecedor)
        {
            return _repository.Remove(idFornecedor);
        }

        public DataTable getAll()
        {
            return _repository.getAll();
        }

        public DataTable filterByName(string nome)
        {
            return _repository.filterByName(nome);
        }

        private bool EmailRegistrado(string email, int? id)
        {
            DataTable dt = _repository.filterByEmail(email);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (id == null || (id != null && (int)dt.Rows[0]["id"] != id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
