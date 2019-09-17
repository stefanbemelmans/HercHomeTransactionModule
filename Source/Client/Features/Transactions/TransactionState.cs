namespace TransactionProject.Client.Features.Transactions
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;
  using BlazorState;

  internal partial class TransactionState : State<TransactionState>
  {
    private List<TransactionsDto> _ListOfTransactions;

    public IReadOnlyList<TransactionsDto> ListOfTransactions => _ListOfTransactions.AsReadOnly();

    public TransactionState()
    {
      _ListOfTransactions = new List<TransactionsDto>();
    }
    
    protected override void Initialize() { }
  }
}