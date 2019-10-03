using System;

namespace TransactionProject.Api.Features.JuliesApi
{
  public class AssetTransactionDto
  {
    public Data Data { get; set; }

    public Header Header { get; set; }

    public string AssetKey { get; set; }

    public AssetTransactionDto() { }
  }

  public class Data
  {
    public string Document { get; set; }

    public string Images { get; set; }

    public string Metrics { get; set; }

    public Data() { }
  }

  public class Header
  {
    public string AssetId { get; set; }

    public DateTime DTime { get; set; }

    public string FactomEntry { get; set; }

    public int HercId { get; set; }

    public string Name { get; set; }

    public string Price { get; set; }

    public string TxSide { get; set; }

    public Header() { }
  }
}