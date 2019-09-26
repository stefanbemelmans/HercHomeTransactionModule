namespace TransactionProject.Server.Services.JuliesApi
{
  using System.Net.Http;

  class JuliesApiHttpClient : HttpClient
  {
    public string BaseUrl = "http://api.herc.one/assets/";
   
    public JuliesApiHttpClient()
    {
      BaseAddress = new System.Uri(BaseUrl);
    }
  }
}
