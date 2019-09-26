namespace TransactionProject.Api.Features.JuliesApi.AssetTransactions
{
  using FluentValidation;
  using TransactionProject.Api.Features.JuliesApi.AssetTransaction;

  public class MakeAssetTransactionApiRequestValidatorCollection : AbstractValidator<MakeAssetTransactionApiRequest>
  {
    public MakeAssetTransactionApiRequestValidatorCollection()
    {
      RuleFor(aMakeTransactionApiRequest => aMakeTransactionApiRequest.AssetDefinitionDto)
        .SetValidator(new AssetTransactionDtoValidator());
      RuleFor(aCreateAssetDefRequest => aCreateAssetDefRequest.AssetDefinitionDto)
        .NotNull();
    }
  }
}
