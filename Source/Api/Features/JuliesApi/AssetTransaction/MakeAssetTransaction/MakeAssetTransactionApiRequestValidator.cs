namespace TransactionProject.Api.Features.JuliesApi.AssetTransactions
{
  using FluentValidation;
  using TransactionProject.Api.Features.JuliesApi.AssetTransaction;

  public class MakeAssetTransactionApiRequestValidatorCollection : AbstractValidator<MakeAssetTransactionApiRequest>
  {
    public MakeAssetTransactionApiRequestValidatorCollection()
    {
      RuleFor(aMakeTransactionApiRequest => aMakeTransactionApiRequest.AssetTransactionDto)
        .SetValidator(new AssetTransactionDtoValidator());
    }
  }
}
