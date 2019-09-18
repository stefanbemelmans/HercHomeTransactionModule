namespace TransactionProject.Client.Features.Transactions.Components
{
  using System;
  using TransactionProject.Client.Features.Base.Components;

  public class TransactionContainerBase : BaseComponent
  {
    public uint Amount { get; set; }
    public bool IsClicked { get; set; }
    public string ToAddress { get; set; }
    public DateTime TxDate { get; set; }
    public int TxId { get; set; }
    private bool HasSubtracted { get; set; } = false;

    public void OnClicked()
    {
      // Write "Adding Transaction to tally in State" function
      // Also Write UI adjustments for clicked/notclicked
    }
  }
}