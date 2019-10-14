using Carona.Business.Models;
using FluentValidation;
using System.Linq;

namespace Carona.Business.Validations
{
    class GrupoValidation : AbstractValidator<Grupo>
    {
        public GrupoValidation()
        {
            RuleFor(g => g.Administrador)
                .NotNull().WithMessage("O Campo {PropertyName} precisa ser fornecido");

            RuleFor(g => g.Nome)
                .NotEmpty().WithMessage("O Campo {PropertyName} precisa ser fornecido");

            RuleFor(g => g.Membros)
                .Must(m => m == null || !m.Any())
                .WithMessage("O grupo deve ter pelo menos um membro.");

            RuleFor(g => g.Rotas)
                .Must(r => r == null || !r.Any())
                .WithMessage("O grupo deve ter pelo menos uma rota.");




        }
    }
}
