namespace TransactionProject.Api.Features.JuliesApi
{
  public class AssetHeader
  {
    public AssetHeader()
    {
      Hashes = new Hashes();
    }
    public string CreatedBy { get; set; }
    public Hashes Hashes { get; set; } 
    public int HercId { get; set; }
    public string Key { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public bool Public { get; set; }
  }

  public class Hashes
  {
    public Hashes() { }
    public string ChainId { get; set; }
    public string IpfsHash { get; set; }
    public string OrganizationName { get; set; }
  }
}