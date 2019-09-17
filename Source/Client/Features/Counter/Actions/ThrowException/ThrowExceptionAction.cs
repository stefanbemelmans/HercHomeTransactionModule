namespace TransactionProject.Client.Features.Counter
{
  using TransactionProject.Client.Features.Base;

  internal partial class CounterState
  {
    public class ThrowExceptionAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}