using System.Collections.Generic;
using TransactionProject.Api.Features.JuliesApi;

namespace TransactionProject.Server.Services.JuliesApi
{
  public class ReturnListOfAssetsResponse
  {
    public List<AssetDefinitionDto> ListOfAssets { get; set; }
  }
}