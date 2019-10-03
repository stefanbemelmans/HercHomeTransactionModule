namespace TransactionProject.Api.Features.JuliesApi
{
  using System.Collections.Generic;

  public class MakeAssetTransactionDto
  {
    public MakeAssetTransactionDto() { }
    /// <summary>
    /// the unique identifier key to your asset. You can retrieve it by calling /assets/list.
    /// </summary>
    public string AssetKey { get; set; }

    /// <summary>
    /// any document file sent in multipart/form-data. Example filetypes: csv, pdf
    /// </summary>
    ///
    public byte[] Base64Document { get; set; }

    /// <summary>
    ///  the edit subsect your transaction falls under
    /// </summary>
    public string EDit { get; set; }

    /// <summary>
    /// an image file sent in multipart/form-data, I'm using the base64 string for now
    /// </summary>
    public byte[] ImageByteArray { get; set; } // One for now

    public List<MetricDefinitionDto> Metrics { get; set; }
  }

  
}