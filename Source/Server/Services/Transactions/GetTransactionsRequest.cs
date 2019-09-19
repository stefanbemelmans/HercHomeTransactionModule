using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionProject.Server.Services.Transactions
{
    public class GetTransactionsRequest : IRequest<GetTransactionsResponse>
    {
    public int NumberOfTransactions { get; set; } = 10;
  }
}
