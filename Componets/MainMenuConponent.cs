using Microsoft.AspNetCore.Mvc;

namespace WorkingProject.Componets
{
    public class MainMenuConponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());

        } 
    }
}
