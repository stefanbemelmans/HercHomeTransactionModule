namespace TransactionProject.Api.Services.HerculesApi
{
  using System.Net.Http;

  class HerculesApiHttpClient : HttpClient
  {
    public string BaseUrl = "http://api.herc.one/assets/";
   
    public HerculesApiHttpClient()
    {
      BaseAddress = new System.Uri(BaseUrl);
    }
  }
}
