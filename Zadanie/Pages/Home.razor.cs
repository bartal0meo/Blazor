using Microsoft.AspNetCore.Components;

namespace Zadanie.Pages
{
    public partial class Home
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        private void GoToIndex()
        {
            navigationManager.NavigateTo("/Homework/Parametr");
        }
    }
}