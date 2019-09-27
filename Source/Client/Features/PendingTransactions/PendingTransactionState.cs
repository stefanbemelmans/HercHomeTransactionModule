namespace TransactionProject.Client.Features.PendingTransactions
{
  using BlazorState;
  using System.Collections.Generic;
  using System.Linq;
  using TransactionProject.Api.Features.PendingTransactions;

  internal partial class PendingTransactionState : State<PendingTransactionState>
  {
    private List<PendingTransactionDto> _ListOfPendingTransactions;
    private List<PendingTransactionDto> _PendingTransactionsToPay;

    public IReadOnlyList<PendingTransactionDto> ListOfTransactions => _ListOfPendingTransactions.AsReadOnly();
    public IReadOnlyList<PendingTransactionDto> TransactionsToPay => _PendingTransactionsToPay.AsReadOnly();

    public int TotalBalance => TransactionsToPay.Sum(aPendingTransactionDto => aPendingTransactionDto.TransactionAmount);

    public PendingTransactionState()
    {
      _ListOfPendingTransactions = new List<PendingTransactionDto>();
      _PendingTransactionsToPay = new List<PendingTransactionDto>();
    }

    protected override void Initialize() { }
  }
}