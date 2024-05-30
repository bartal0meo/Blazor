using Microsoft.AspNetCore.Components;

namespace Zadanie.Pages
{
    public partial class Homework
    {
        [Parameter]
        public string Tekst {  get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        private void GoToIndex()
        {
            navigationManager.NavigateTo("/");
        }
    }
}
