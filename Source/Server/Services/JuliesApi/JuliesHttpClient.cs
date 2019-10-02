namespace TransactionProject.Server.Services.JuliesApi
{
  using Microsoft.AspNetCore.Blazor.Http;
  using System.Net.Http;

  public class JuliesApiHttpClient : HttpClient
  {
    public string BaseUrl = "http://api.herc.one/assets/";
    public string ApiKey = "UFaZhBbQZZsXLMNklP29qua71f80f9-ba21-4c2d-b6fd-00d043153e2c";
    public JuliesApiHttpClient()
    {
      BaseAddress = new System.Uri(BaseUrl);
    }
  }
}
