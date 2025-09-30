using FluentValidation;

namespace Valuto.Domain.Interfaces.Validators.Base
{
    public interface IBaseValidator<DTO> : IValidator<DTO> where DTO : class
    {
    }
}
