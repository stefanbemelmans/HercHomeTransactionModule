namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;
  using System.Linq;

  public class AssetTransactionDtoValidator : AbstractValidator<AssetTransactionDto>
  {
    public AssetTransactionDtoValidator()
    {
      RuleFor(aAssetTransactionDto => aAssetTransactionDto.AssetKey)
        .NotEmpty();
     
      // TODO: EDitValidator
      // TODO: Image byte[] or base64 string validator
      // TODO: Document byte[] or base64 string validator
      // TODO: Metric Value validator
    }
  }
}
