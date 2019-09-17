namespace TransactionProject.Client.Features.Base.Components
{
  using static TransactionProject.Client.Features.Application.ApplicationState;

  public class ResetButtonBase : BaseComponent
  {
    internal void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}