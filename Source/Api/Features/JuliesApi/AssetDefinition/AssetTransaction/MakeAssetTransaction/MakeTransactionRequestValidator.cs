namespace TransactionProject.Api.Features.JuliesApi.AssetTransactions
{
  using FluentValidation;

  public class MakeTransactionRequestValidatorCollection : AbstractValidator<MakeTransactionRequest>
  {
    public MakeTransactionRequestValidatorCollection()
    {
      RuleFor(aMakeTransactionDefinitionRequest => aMakeTransactionDefinitionRequest.AssetDefinitionDto)
        .SetValidator(new AssetTransactionDtoValidatorColl());
      RuleFor(aCreateAssetDefRequest => aCreateAssetDefRequest.AssetDefinitionDto)
        .NotNull();
    }
  }
}
