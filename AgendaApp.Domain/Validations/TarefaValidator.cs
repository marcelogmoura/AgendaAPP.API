using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Domain.Entities;
using FluentValidation;

namespace AgendaApp.Domain.Validations
{
    public class TarefaValidator : AbstractValidator<Tarefa>
    {
        public TarefaValidator() 
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Informe o ID");

            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Informe o NOME")
                .Length(3, 150).WithMessage("De 3 a 150 caracteres");

            RuleFor(p => p.Descricao)
                .NotEmpty().WithMessage("Informe a DESCRIÇÃO")
                .Length(3, 250).WithMessage("De 3 a 250 caracteres");

            RuleFor(p => p.DataHora)
                .NotNull().WithMessage("Informe a DATA E HORA");

            RuleFor(p => p.Prioridade)
                .NotNull().WithMessage("Informe a PRIORIDADE");

            RuleFor(p => p.PessoaId)
                .NotEmpty().WithMessage("Informe o ID da PESSOA");
        }
    }
}
