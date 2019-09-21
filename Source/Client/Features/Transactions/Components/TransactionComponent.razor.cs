namespace TransactionProject.Client.Features.Transactions.Components
{
  using Microsoft.AspNetCore.Components;
  using System;
  using TransactionProject.Client.Features.Base.Components;
  using static TransactionProject.Client.Features.Transactions.Actions.Payment.TransactionState;

  public class TransactionComponentBase : BaseComponent
  {
    [Parameter]
    public int Gas { get; set; }
    
    [Parameter]
    public string ToAddress { get; set; }

    [Parameter]
    public int TransactionAmount { get; set; }

    [Parameter]
    public DateTime TxDate { get; set; }

    [Parameter]
    public int TxId { get; set; }
    public bool IsClicked { get; set; }

    private bool HasSubtracted { get; set; } = false;

    public void OnClicked()
    {
      if (HasSubtracted == true)
      {
        //Send AddTxValue
        Console.WriteLine("Has Subtracted: " + HasSubtracted);
        Console.WriteLine("Add TX Amount To Total: " + TransactionAmount);
        Console.WriteLine("IsClicked: " + IsClicked);
        Mediator.Send(new IncreaseTotalAction { Amount = TransactionAmount });
        HasSubtracted = !HasSubtracted;
        IsClicked = !IsClicked;
      }
      else
      {
        // Send SubtractTxValue
        Console.WriteLine("Has Subtracted: " + HasSubtracted);
        Console.WriteLine("Subtract TX Amount From Total: " + TransactionAmount);
        Console.WriteLine("IsClicked: " + IsClicked);
        Mediator.Send(new DecreaseTotalAction { Amount = TransactionAmount });
        HasSubtracted = !HasSubtracted;
        IsClicked = !IsClicked;
      }
    }
  }
}