using FluentValidation;
using JesusEmNos.Domain.Interfaces;
using JesusEmNos.Domain.Interfaces.Validators.Base;
using Microsoft.Extensions.DependencyInjection;

namespace JesusEmNos.Application.Validators.Base
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
