using FluentValidation;
using JetBrains.Annotations;
using MAVN.Service.CurrencyConvertor.Client.Models.Requests;

namespace MAVN.Service.CurrencyConverter.Validations
{
    [UsedImplicitly]
    // ReSharper disable once InconsistentNaming
    public class CurrencyRateRequestValidator : AbstractValidator<CurrencyRateRequest>
    {
        public CurrencyRateRequestValidator()
        {
            RuleFor(o => o.BaseAsset)
                .NotEmpty()
                .WithMessage("Base asset required");

            RuleFor(o => o.QuoteAsset)
                .NotEmpty()
                .WithMessage("Quote asset required");

            RuleFor(o => o.Rate)
                .GreaterThan(0)
                .WithMessage("The rate should be greater than zero");
        }
    }
}
