namespace TransactionProject.Client.Features.Transactions
{
  using BlazorState;
  using System.Collections.Generic;
  using System.Linq;
  using TransactionProject.Api.Features.Transactions;

  internal partial class TransactionState : State<TransactionState>
  {
    private List<TransactionDto> _ListOfTransactions;
    private List<TransactionDto> _TransactionsToPay;

    public IReadOnlyList<TransactionDto> ListOfTransactions => _ListOfTransactions.AsReadOnly();
    public IReadOnlyList<TransactionDto> TransactionsToPay => _TransactionsToPay.AsReadOnly();

    public int TotalBalance => TransactionsToPay.Sum(aTransactionDto => aTransactionDto.TransactionAmount);

    public TransactionState()
    {
      _ListOfTransactions = new List<TransactionDto>();
      _TransactionsToPay = new List<TransactionDto>();
    }

    protected override void Initialize() { }
  }
}