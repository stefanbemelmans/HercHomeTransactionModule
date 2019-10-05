namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;

  public class ReturnSingleAssetTransactionApiRequestValidatorCollection : AbstractValidator<ReturnSingleAssetTransactionApiRequest>
  {
    public ReturnSingleAssetTransactionApiRequestValidatorCollection()
    {
      RuleFor(aGetAssetDefinitionApiRequest => aGetAssetDefinitionApiRequest.timestamp).GreaterThan(0);
      RuleFor(aGetAssetDefinitionApiRequest => aGetAssetDefinitionApiRequest.assetKey).NotNull();
    }
  }
}
