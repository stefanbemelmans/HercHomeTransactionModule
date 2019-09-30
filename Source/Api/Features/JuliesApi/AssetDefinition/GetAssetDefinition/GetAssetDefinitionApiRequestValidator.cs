namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;

  public class GetAssetDefinitionApiRequestValidatorCollection : AbstractValidator<GetAssetDefinitionApiRequest>
  {
    public GetAssetDefinitionApiRequestValidatorCollection()
    {
      RuleFor(aGetAssetDefinitionApiRequest => aGetAssetDefinitionApiRequest.AssetDefinitionId).GreaterThan(0);
    }
  }
}
