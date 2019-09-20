namespace TransactionProject.Client.Features.Transactions
{
  using System.Collections.Generic;
  using TransactionProject.Api.Features.Transactions;
  using BlazorState;

  internal partial class TransactionState : State<TransactionState>
  {
    private List<TransactionDto> _ListOfTransactions;

    public List<TransactionDto> ListOfTransactions => _ListOfTransactions;

    public TransactionState()
    {
      _ListOfTransactions = new List<TransactionDto>();
    }
    
    public uint TotalBalance { get; set; }
    protected override void Initialize() => TotalBalance = 0;
  }
}