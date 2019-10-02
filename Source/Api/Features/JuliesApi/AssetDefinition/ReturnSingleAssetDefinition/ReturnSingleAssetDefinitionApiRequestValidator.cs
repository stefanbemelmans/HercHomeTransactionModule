namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetDefintionApiRequestValidatorCollection : AbstractValidator<ReturnSingleAssetDefintionApiRequest>
  {
    public ReturnSingleAssetDefintionApiRequestValidatorCollection()
    {
      RuleFor(aMakeTransactionApiRequest => aMakeTransactionApiRequest.AssetKey).NotNull();
        
    }
  }
}
