using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionProject.Server.Services.Transactions
{
    public class GetTransactionsRequest
    {
    public int NumberOfTransactions { get; set; } = 10;
  }
}
