using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionProject.Client.Features.Base.Components;

namespace TransactionProject.Client.Features.Transactions.Components
{
    public class TransactionContainerBase : BaseComponent
    {
    public int TxId { get; set; }
    public bool IsClicked { get; set; }
    public uint Amount { get; set; }
    public string ToAddress { get; set; }

    public DateTime TxDate { get; set; }


    public void OnClicked()
    {

    }

    }
}
