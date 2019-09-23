using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionProject.Server.Services.HerculesApi
{
  public class ApiTransaction
  {
    /// <summary>
    /// the unique identifier key to your asset. You can retrieve it by calling /assets/list.
    /// </summary>
    public string AssetKey { get; set; }
    /// <summary>
    ///  the edit subsect your transaction falls under
    /// </summary>
    public string EDit { get; set; }
    /// <summary>
    /// an image file sent in multipart/form-data, I'm using the base64 string for now
    /// </summary>
    public string Base64ImageString { get; set; } // One for now
   
    public Metrics Metrics { get; set; }
    /// <summary>
    /// any document file sent in multipart/form-data. Example filetypes: csv, pdf
    /// </summary>
    /// 
    public string Base64DocumentString { get; set; }
  }
}
