using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;
using FluentValidation;

namespace AgendaApp.Domain.Validations
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator() 
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Informe o ID");

            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Informe o NOME")
                .Length(3, 150).WithMessage("Nome de 3 a 150 caracteres");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Informe o EMAIL")
                .EmailAddress().WithMessage("Email deve ser válido");

            RuleFor(p => p.Senha)
                .NotEmpty().WithMessage("Informe a SENHA")
                .Matches("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.* [@$! % *? &])[A - Za - z\\d@$! % *? &]{ 5,}$\r\n")
                .WithMessage("Aumente a complexibilidade");


        }
    }
}
