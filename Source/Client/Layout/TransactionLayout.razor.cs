namespace TransactionProject.Client.Layout
{
  using BlazorState.Services;
  using Microsoft.AspNetCore.Components;
  using TransactionProject.Client.Features.Transactions;
  
  public class TransactionLayoutBase : LayoutComponentBase
  {
    [Inject] public BlazorHostingLocation BlazorHostingLocation { get; set; }
    
    protected const string HeadingHeight = "52px";
  }
}
