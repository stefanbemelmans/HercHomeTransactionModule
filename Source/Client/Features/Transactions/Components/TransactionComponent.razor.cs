namespace TransactionProject.Client.Features.Transactions.Components
{
  using Microsoft.AspNetCore.Components;
  using System;
  using TransactionProject.Client.Features.Base.Components;
  using static TransactionProject.Client.Features.Transactions.TransactionState;

  public class TransactionComponentBase : BaseComponent
  {
    public string BackgroundColor => IsClicked ? "#AEEEEE" : "#E0EEEE";

    [Parameter]
    public int Gas { get; set; }

    public bool IsClicked { get; set; }

    [Parameter]
    public string ToAddress { get; set; }

    [Parameter]
    public int TransactionAmount { get; set; }

    [Parameter]
    public DateTime TxDate { get; set; }

    [Parameter]
    public int TxId { get; set; }

    //private bool HasSubtracted { get; set; } = false;

    public void OnClicked()
    {
      if (IsClicked == true)
      {
        Console.WriteLine("IsClicked: " + IsClicked);
        Console.WriteLine("Remove TX Amount From TotalBalance: " + TransactionAmount);
        //Mediator.Send(new DecreaseTotalAction { Amount = TransactionAmount });
        Mediator.Send(new DeSelectTransactionAction { TxId = TxId });

        IsClicked = !IsClicked;
        Console.WriteLine("IsClicked after methods: " + IsClicked);
        Console.WriteLine("Total: " + TransactionState.TotalBalance);
      }
      else
      {
        // Send SubtractTxValue
        Console.WriteLine("Add TX Amount To TotalBalance: " + TransactionAmount);
        Console.WriteLine("IsClicked: " + IsClicked);
        //Mediator.Send(new IncreaseTotalAction { Amount = TransactionAmount });
        Mediator.Send(new SelectTransactionAction { TxId = TxId });
        IsClicked = !IsClicked;
        Console.WriteLine("IsClicked after methods: " + IsClicked);
        Console.WriteLine("Total: " + TransactionState.TotalBalance);
      }
    }
  }
}