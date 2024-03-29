﻿namespace TransactionProject.Api.Features.JuliesApi
{
  using FluentValidation;
  using TransactionProject.Api.Features.JuliesApi;

  public class MakeAssetTransactionApiRequestValidatorCollection : AbstractValidator<MakeAssetTransactionApiRequest>
  {
    public MakeAssetTransactionApiRequestValidatorCollection()
    {
      RuleFor(aMakeTransactionApiRequest => aMakeTransactionApiRequest.AssetTransactionDto)
        .SetValidator(new AssetTransactionDtoValidator());
    }
  }
}
