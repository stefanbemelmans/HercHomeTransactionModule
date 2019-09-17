namespace TransactionProject.Client.Features.Application.Components
{
  using TransactionProject.Client.Features.Base.Components;
  using static TransactionProject.Client.Features.Application.ApplicationState;

  public class NavBarBase : BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";

    protected async void ToggleNavMenu() => await Mediator.Send(new ToggleMenuAction());
  }
}