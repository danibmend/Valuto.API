using FluentValidation;
using Valuto.Domain.Interfaces;
using Valuto.Domain.Interfaces.Validators.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Valuto.Application.Validators.Base
{
    public class BaseValidator<TDto> : AbstractValidator<TDto>, IBaseValidator<TDto> where TDto : class
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected BaseValidator(IServiceProvider serviceProvider)
        {
            _unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
        }


    }
}
