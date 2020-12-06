﻿using FluentValidation;
using RadishV2.Shared;

namespace RadishV2.Client.Validator
{
    public class SortedSetValidator : AbstractValidator<KeyValue>
    {
        public SortedSetValidator()
        {
            RuleFor(p => p.Score).NotNull().WithMessage("Must provide a score");
            RuleFor(p => p.Value).NotNull().WithMessage("Must provide a value");
            RuleFor(p => p.Value).NotEmpty().WithMessage("Must provide a value");
        }
    }
}