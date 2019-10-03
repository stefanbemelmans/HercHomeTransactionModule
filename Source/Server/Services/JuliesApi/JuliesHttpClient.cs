namespace TransactionProject.Server.Services.JuliesApi
{
  using Microsoft.AspNetCore.Components;
  using System;
  using System.Net.Http;

  public class JuliesApiHttpClient : HttpClient
  {
    public string BaseUrl = "http://api.herc.one:8000/";
    
    public JuliesApiHttpClient()
    {
      BaseAddress = new System.Uri(BaseUrl);
    }
       
  }
}
