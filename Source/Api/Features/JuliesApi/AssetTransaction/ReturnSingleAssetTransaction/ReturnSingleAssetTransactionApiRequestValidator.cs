namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;

  public class ReturnSingleAssetTransactionApiRequestValidatorCollection : AbstractValidator<ReturnSingleAssetTransactionApiRequest>
  {
    public ReturnSingleAssetTransactionApiRequestValidatorCollection()
    {
      RuleFor(aGetAssetDefinitionApiRequest => aGetAssetDefinitionApiRequest.TransactionKey).GreaterThan(0);
    }
  }
}
