using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Cliente
    {
        //Guid = numero de 16 bytes usado como identificador único
        public int? Id { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente()
        {
        }

        public Cliente(int? id, TipoPessoa tipoPessoa, string nome, string email)
        {
            Id = id;
            this.tipoPessoa = tipoPessoa;
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   Id == cliente.Id &&
                   tipoPessoa == cliente.tipoPessoa &&
                   Nome == cliente.Nome &&
                   Email == cliente.Email;
        }

        public override int GetHashCode()
        {
            int hashCode = -1601931259;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + tipoPessoa.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }
    }
}
