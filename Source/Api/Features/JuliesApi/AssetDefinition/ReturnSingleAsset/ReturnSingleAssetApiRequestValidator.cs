namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;
  using TransactionProject.Api.Features.JuliesApi;

  public class ReturnSingleAssetApiRequestValidatorCollection : AbstractValidator<ReturnSingleAssetApiRequest>
  {
    public ReturnSingleAssetApiRequestValidatorCollection()
    {
      RuleFor(aSingleAssetApiRequest => aSingleAssetApiRequest.AssetKey).NotNull();
        
    }
  }
}
