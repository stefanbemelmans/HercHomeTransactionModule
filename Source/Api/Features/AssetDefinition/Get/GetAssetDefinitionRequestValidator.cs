namespace TransactionProject.Api.Features.AssetDefinition
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
