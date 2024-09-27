using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Fornecedor
    {
        //Guid = numero de 16 bytes usado como identificador único
        public int? Id { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Razao_social { get; set; }
        public string Rua {  get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento {  get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public Fornecedor()
        {
        }

        public Fornecedor(int? id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, string razao_social, string rua, string numero, string bairro, string cidade, string complemento, string cep, string telefone, string celular)
        {
            Id = id;
            this.tipoPessoa = tipoPessoa;
            Nome = nome;
            Email = email;
            Cpf_cnpj = cpf_cnpj;
            Razao_social = razao_social;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Complemento = complemento;
            Cep = cep;
            Telefone = telefone;
            Celular = celular;
        }

        public override bool Equals(object obj)
        {
            return obj is Fornecedor fornecedor &&
                   Id == fornecedor.Id &&
                   tipoPessoa == fornecedor.tipoPessoa &&
                   Nome == fornecedor.Nome &&
                   Email == fornecedor.Email &&
                   Cpf_cnpj == fornecedor.Cpf_cnpj &&
                   Razao_social == fornecedor.Razao_social &&
                   Rua == fornecedor.Rua &&
                   Numero == fornecedor.Numero &&
                   Bairro == fornecedor.Bairro &&
                   Cidade == fornecedor.Cidade &&
                   Complemento == fornecedor.Complemento &&
                   Cep == fornecedor.Cep &&
                   Telefone == fornecedor.Telefone &&
                   Celular == fornecedor.Celular;
        }

        public override int GetHashCode()
        {
            int hashCode = -1601931259;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + tipoPessoa.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cpf_cnpj);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Razao_social);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Rua);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Numero);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Bairro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cidade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Complemento);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cep);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Celular);
            return hashCode;
        }
    }
}

