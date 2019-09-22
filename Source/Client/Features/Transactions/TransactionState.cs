namespace TransactionProject.Client.Features.Transactions
{
  using BlazorState;
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;

  internal partial class TransactionState : State<TransactionState>
  {
    //private List<TransactionDto> _ListOfTransactions;

    //public List<TransactionDto> ListOfTransactions => _ListOfTransactions;
    public List<TransactionDto> ListOfTransactions { get; set; }

    public int TotalBalance { get; set; }
    public List<TransactionDto> TransactionsToPay { get; set; }

    public TransactionState()
    {
      ListOfTransactions = new List<TransactionDto>();
      TransactionsToPay = new List<TransactionDto>();
    }

    protected override void Initialize() => TotalBalance = 0;
  }
}