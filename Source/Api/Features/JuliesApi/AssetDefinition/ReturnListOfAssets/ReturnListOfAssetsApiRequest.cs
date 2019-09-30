namespace TransactionProject.Api.Features.JuliesApi
{
  using MediatR;
  using TransactionProject.Api.Features.Base;

  /// <summary>
  /// Get List of all AssetDefinitions associated with the API key
  /// </summary>
  public class ReturnListOfAssetsApiRequest : BaseRequest, IRequest<ReturnListOfAssetsApiResponse>
  {
    public const string ReturnListOfAssetsEndPoint = "list?api_key=[*insert key here*]";
    public const string Route = "api/returnListOfAssets";
  }
}