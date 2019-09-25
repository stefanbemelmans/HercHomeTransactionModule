namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;

  public class CreateAssetDefRequestValidatorCollection : AbstractValidator<CreateAssetDefinitionApiRequest>
  {
    public CreateAssetDefRequestValidatorCollection()
    {
      RuleFor(aCreateAssetDefRequest => aCreateAssetDefRequest.AssetDefinitionDto)
        .SetValidator(new AssetDefinitionDtoValidator());
      RuleFor(aCreateAssetDefRequest => aCreateAssetDefRequest.AssetDefinitionDto)
        .NotNull();
    }
  }
}
