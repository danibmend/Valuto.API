using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Extensions
{
    public static class ValidationExtensions
    {
        public static IRuleBuilderOptions<T, string> RequiredString<T>(this IRuleBuilder<T, string> ruleBuilder, string fieldName)
        {
            return ruleBuilder.NotNull().NotEmpty().WithMessage($"{fieldName} não informado.");
        }

        public static IRuleBuilderOptions<T, TValue> RequiredValueObject<T, TValue>(this IRuleBuilder<T, TValue> ruleBuilder, string fieldName) where TValue : class
        {
            return ruleBuilder.Must(x => x != null && !string.IsNullOrWhiteSpace((x as dynamic).Valor)).WithMessage($"{fieldName} não informado.");
        }

        public static IRuleBuilderOptions<T, DateTime?> RequiredDate<T>(this IRuleBuilder<T, DateTime?> ruleBuilder, string fieldName)
        {
            return ruleBuilder.Must(x => x != default && x.HasValue).WithMessage($"{fieldName} não informada.");
        }

        public static IRuleBuilderOptions<T, long> RequiredLong<T>(this IRuleBuilder<T, long> ruleBuilder, string fieldName)
        {
            return ruleBuilder.Must(x => x != default || x != 0).WithMessage($"{fieldName} não informada.");
        }
    }
}
