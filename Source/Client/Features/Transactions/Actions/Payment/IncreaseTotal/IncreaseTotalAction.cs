using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionProject.Client.Features.Base;

namespace TransactionProject.Client.Features.Transactions.Actions.Payment.IncreaseTotal
{
  internal partial class TransactionState
  {
    public class IncreaseTotalAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}
