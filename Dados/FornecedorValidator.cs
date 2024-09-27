using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public FornecedorValidator()
        {
            // Nome
            RuleFor(fornecedor => fornecedor.Nome)
                .NotEmpty().WithMessage("Campo NOME é obrigatório!")
                .Length(10, 40).WithMessage("Tamanho do campo nome deve estar entre 10 e 40!");

            // Email
            RuleFor(fornecedor => fornecedor.Email)
                .NotEmpty().WithMessage("Campo EMAIL é obrigatório!")
                .EmailAddress().WithMessage("Um email válido é requerido!");

            // Tipo de Pessoa
            RuleFor(fornecedor => fornecedor.tipoPessoa)
                .IsInEnum().WithMessage("Campo TipoPessoa deve ser especificado!");

            // CPF para Pessoa Física
            RuleFor(fornecedor => fornecedor.Cpf_cnpj)
                .NotEmpty().WithMessage("Campo CPF/CNPJ é obrigatório!")
                .Length(11).WithMessage("CPF deve conter 11 dígitos!")
                .Matches(@"^\d{11}$").WithMessage("CPF deve conter apenas números!")
                .When(fornecedor => fornecedor.tipoPessoa == TipoPessoa.PESSOA_FISICA)
                .WithMessage("CPF é obrigatório para Pessoa Física.");

            // CNPJ para Pessoa Jurídica
            RuleFor(fornecedor => fornecedor.Cpf_cnpj)
                .NotEmpty().WithMessage("Campo CPF/CNPJ é obrigatório!")
                .Length(14).WithMessage("CNPJ deve conter 14 dígitos!")
                .Matches(@"^\d{14}$").WithMessage("CNPJ deve conter apenas números!")
                .When(fornecedor => fornecedor.tipoPessoa == TipoPessoa.PESSOA_JURIDICA)
                .WithMessage("CNPJ é obrigatório para Pessoa Jurídica.");

            // Razão Social
            RuleFor(fornecedor => fornecedor.Razao_social)
                .NotEmpty().WithMessage("Campo Razão Social é obrigatório!")
                .Length(5, 100).WithMessage("Tamanho do campo Razão Social deve estar entre 5 e 100 caracteres!");

            // Rua
            RuleFor(fornecedor => fornecedor.Rua)
                .NotEmpty().WithMessage("Campo Rua é obrigatório!")
                .Length(5, 100).WithMessage("Tamanho do campo Rua deve estar entre 5 e 100 caracteres!");

            // Número
            RuleFor(fornecedor => fornecedor.Numero)
                .NotEmpty().WithMessage("Campo Número é obrigatório!")
                .Matches(@"^\d+$").WithMessage("Campo Número deve conter apenas dígitos!");

            // Bairro
            RuleFor(fornecedor => fornecedor.Bairro)
                .NotEmpty().WithMessage("Campo Bairro é obrigatório!")
                .Length(3, 50).WithMessage("Tamanho do campo Bairro deve estar entre 3 e 50 caracteres!");

            // Cidade
            RuleFor(fornecedor => fornecedor.Cidade)
                .NotEmpty().WithMessage("Campo Cidade é obrigatório!")
                .Length(3, 50).WithMessage("Tamanho do campo Cidade deve estar entre 3 e 50 caracteres!");

            // Complemento
            RuleFor(fornecedor => fornecedor.Complemento)
                .MaximumLength(50).WithMessage("Tamanho máximo do campo Complemento é de 50 caracteres!");

            // CEP
            RuleFor(fornecedor => fornecedor.Cep)
                .NotEmpty().WithMessage("Campo CEP é obrigatório!")
                .Matches(@"^\d{5}-\d{3}$").WithMessage("CEP deve estar no formato 00000-000!");

            // Telefone
            RuleFor(fornecedor => fornecedor.Telefone)
                .NotEmpty().WithMessage("Campo Telefone é obrigatório!")
                .Matches(@"^\(?\d{2}\)?[\s-]?\d{4}-\d{4}$").WithMessage("Telefone deve estar no formato (XX) XXXX-XXXX!");

            // Celular
            RuleFor(fornecedor => fornecedor.Celular)
                .NotEmpty().WithMessage("Campo Celular é obrigatório!")
                .Matches(@"^\(?\d{2}\)?[\s-]?\d{5}-\d{4}$").WithMessage("Celular deve estar no formato (XX) XXXXX-XXXX!");
        }
       

    }
}


