namespace TransactionProject.Api.Features.JuliesApi
{
    using System;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Base;

    public class ReturnTransactionsOnASingleAssetApiResponse : BaseResponse
    {
        public List<AssetTransactionDto> AssetTransactionList { get; set; }
    }
}