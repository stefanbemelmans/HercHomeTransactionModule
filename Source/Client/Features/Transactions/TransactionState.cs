namespace TransactionProject.Client.Features.PendingTransactions
{
  using BlazorState;
  using System.Collections.Generic;
  using System.Linq;
  using TransactionProject.Api.Features.PendingTransactions;

  internal partial class TransactionState : State<TransactionState>
  {
    private List<PendingTransactionDto> _ListOfTransactions;
    private List<PendingTransactionDto> _TransactionsToPay;

    public IReadOnlyList<PendingTransactionDto> ListOfTransactions => _ListOfTransactions.AsReadOnly();
    public IReadOnlyList<PendingTransactionDto> TransactionsToPay => _TransactionsToPay.AsReadOnly();

    public int TotalBalance => TransactionsToPay.Sum(aPendingTransactionDto => aPendingTransactionDto.TransactionAmount);

    public TransactionState()
    {
      _ListOfTransactions = new List<PendingTransactionDto>();
      _TransactionsToPay = new List<PendingTransactionDto>();
    }

    protected override void Initialize() { }
  }
}