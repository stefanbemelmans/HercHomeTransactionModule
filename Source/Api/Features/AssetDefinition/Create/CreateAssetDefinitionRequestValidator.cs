namespace TransactionProject.Api.Features.AssetDefinition
{
  using FluentValidation;

  public class CreateAssetDefinitionRequestValidatorCollection : AbstractValidator<CreateAssetDefinitionRequest>
  {
    public CreateAssetDefinitionRequestValidatorCollection()
    {
      RuleFor(aCreateAssetDefinitionRequest => aCreateAssetDefinitionRequest.AssetDefinitionDto)
        .SetValidator(new AssetDefinitionDtoValidator());
      RuleFor(aCreateAssetDefinitionRequest => aCreateAssetDefinitionRequest.AssetDefinitionDto)
        .NotNull();
    }
  }
}
