using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(cliente => cliente.Nome).NotEmpty().WithMessage("Campo NOME é obrigatório!");
            RuleFor(cliente => cliente.Nome).Length(10, 50).WithMessage("Tamanho do campo nome deve estar entre 10 e 50!");
            RuleFor(cliente => cliente.Email).NotEmpty().WithMessage("Campo EMAIL é obrigatório!")
                     .EmailAddress().WithMessage("Um email válido é requerido!");
            RuleFor(cliente => cliente.tipoPessoa).IsInEnum().WithMessage("Campo TipoPessoa deve ser especificado!");
        }

    }
}


