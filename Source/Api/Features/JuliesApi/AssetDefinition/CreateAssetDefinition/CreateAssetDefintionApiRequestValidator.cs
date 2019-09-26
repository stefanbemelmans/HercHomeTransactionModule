namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;

  public class CreateAssetDefinitionApiRequestValidatorCollection : AbstractValidator<CreateAssetDefinitionApiRequest>
  {
    public CreateAssetDefinitionApiRequestValidatorCollection()
    {
      RuleFor(aCreateAssetDefRequest => aCreateAssetDefRequest.AssetDefinitionDto)
        .SetValidator(new AssetDefinitionDtoValidator());
      RuleFor(aCreateAssetDefRequest => aCreateAssetDefRequest.AssetDefinitionDto)
        .NotNull();
    }
  }
}
