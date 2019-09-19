namespace TransactionProject.Client.Features.Transactions.Components
{
  using System;
  using TransactionProject.Client.Features.Base.Components;

  public class TransactionComponentBase : BaseComponent
  {
    public uint Amount { get; set; }
    public bool IsClicked { get; set; }
    public string ToAddress { get; set; }
    public DateTime TxDate { get; set; }
    public int TxId { get; set; }
    private bool HasSubtracted { get; set; } = false;

    public void OnClicked()
    {
      if(HasSubtracted == true)
      {
        //Send AddTxValue
        Console.WriteLine("Has Subtracted: " + HasSubtracted);
        Console.WriteLine("Add TX Amount To Total: " + Amount);
        Console.WriteLine("IsClicked: " + IsClicked);
        HasSubtracted = !HasSubtracted;
        IsClicked = !IsClicked;
      }
      else
      {
        // Send SubtractTxValue
        Console.WriteLine("Has Subtracted: " + HasSubtracted);
        Console.WriteLine("Subtract TX Amount From Total: " + Amount);
        Console.WriteLine("IsClicked: " + IsClicked);
        HasSubtracted = !HasSubtracted;
        IsClicked = !IsClicked;
      }
      

    }

  }
}