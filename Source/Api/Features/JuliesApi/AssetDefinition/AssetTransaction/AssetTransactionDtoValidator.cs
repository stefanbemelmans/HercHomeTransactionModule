namespace TransactionProject.Api.Features.JuliesApi.AssetTransaction
{
  using FluentValidation;
  using System.Linq;

  public class AssetTransactionDtoValidator : AbstractValidator<AssetTransactionDto>
  {
    public AssetTransactionDtoValidator()
    {
      RuleFor(aAssetDefinitionDto => aAssetDefinitionDto.AssetKey)
        .NotEmpty();

      // TODO: MetricsDtoValidator
      // TODO: EDitValidator
      // TODO: Image byte[] or base64 string validator
      // TODO: Document byte[] or base64 string validator
     
    }
  }
}
