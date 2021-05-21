using Microsoft.AspNetCore.Components;

namespace TeamBattle
{
    public class RedirectToLogin : ComponentBase
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            NavigationManager.NavigateTo("identity/account/login");
        }
    }
}