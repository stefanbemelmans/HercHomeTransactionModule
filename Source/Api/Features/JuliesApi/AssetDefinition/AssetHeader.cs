using System.Collections.Generic;

namespace TransactionProject.Api.Features.JuliesApi
{
  public class AssetHeaderDto
  {
    public AssetHeaderDto()
    {
      Hashes = new Hashes();
      Transactions = new List<AssetTransactionDto>();
    }
    public string CreatedBy { get; set; }
    public Hashes Hashes { get; set; } 
    public int HercId { get; set; }
    public string Key { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public object Public { get; set; }
    public List<AssetTransactionDto> Transactions { get; set; }
  }

  public class Hashes
  {
    public Hashes() { }
    public string ChainId { get; set; }
    public string IpfsHash { get; set; }
    public string OrganizationName { get; set; }
  }
}