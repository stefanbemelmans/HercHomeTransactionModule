namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;

  public class GetAssetDefinitionRequestValidatorCollection : AbstractValidator<GetAssetDefinitionRequest>
  {
    public GetAssetDefinitionRequestValidatorCollection()
    {
      RuleFor(aGetAssetDefinitionRequest => aGetAssetDefinitionRequest.AssetDefinitionId).GreaterThan(0);
    }
  }
}
