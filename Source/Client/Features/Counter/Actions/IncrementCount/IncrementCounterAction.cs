namespace TransactionProject.Client.Features.Counter
{
  using TransactionProject.Client.Features.Base;

  internal partial class CounterState
  {
    public class IncrementCounterAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}