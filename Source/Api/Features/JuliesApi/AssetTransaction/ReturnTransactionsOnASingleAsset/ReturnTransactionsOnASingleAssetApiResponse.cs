namespace TransactionProject.Api.Features.JuliesApi
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Base;

    public class ReturnTransactionsOnASingleAssetApiResponse : BaseResponse
    {
        public AssetTransactionDto AssetTransactionList { get; set; }
    }
}