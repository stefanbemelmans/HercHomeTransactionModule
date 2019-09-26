namespace TransactionProject.Server.Services.JuliesApi
{
  using Microsoft.AspNetCore.Blazor.HttpClient;
 
  public class JuliesApiHttpClient : HttpClient
  {
    public string BaseUrl = "http://api.herc.one/assets/";
   
    public JuliesApiHttpClient()
    {
      BaseAddress = new System.Uri(BaseUrl);
    }
  }
}
