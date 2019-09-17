namespace TransactionProject.Client.Features.Application.Components
{
  using TransactionProject.Client.Features.Base.Components;

  public class FooterBase: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
