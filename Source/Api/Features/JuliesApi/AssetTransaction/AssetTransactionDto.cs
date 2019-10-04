using System;
using System.Text.Json.Serialization;

namespace TransactionProject.Api.Features.JuliesApi
{
  public class AssetTransactionDto
  {
    public string TransactionKey { get; set; }

    [JsonPropertyName("data")]
    public Data Data { get; set; }

    [JsonPropertyName("header")]
    public Header Header { get; set; }

    public AssetTransactionDto() { }
  }

  public class Data
  {
    [JsonPropertyName("documents")]
    public string Documents { get; set; }

    [JsonPropertyName("ediT")]
    public string EDiT { get; set; }

    [JsonPropertyName("images")]
    public string Images { get; set; }

    [JsonPropertyName("metrics")]
    public string Metrics { get; set; }

    public Data() { }
  }


  public class Header
  {
    [JsonPropertyName("assetID")]
    public string AssetId { get; set; }

    [JsonPropertyName("dTime")]
    public DateTime DTime { get; set; }

    [JsonPropertyName("factomEntry")]
    public string FactomEntry { get; set; }

    [JsonPropertyName("hercId")]
    public int HercId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("price")]
    public string Price { get; set; }

    [JsonPropertyName("txSide")]
    public string TxSide { get; set; }

    public Header() { }
  }
}