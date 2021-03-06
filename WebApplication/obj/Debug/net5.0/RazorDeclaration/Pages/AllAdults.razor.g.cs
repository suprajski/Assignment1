// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\Pages\AllAdults.razor"
using WebApplication.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\Pages\AllAdults.razor"
using WebApplication.Shared.Persistence;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllAdults")]
    public partial class AllAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Acer Predator Helios\RiderProjects\WebApplication\WebApplication\Pages\AllAdults.razor"
       

    private List<Adult> allAdults;
    private List<Adult> adultsToShow;
    private string? filterByName;
    private string? filterByJob;

    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultPersistence.GetAllAdults();
        adultsToShow = allAdults;
    }

    private void FilterByName(ChangeEventArgs changeEventArgs)
    {
        filterByName = changeEventArgs.Value.ToString();
        Filter();
    }

    private void FilterByJob(ChangeEventArgs changeEventArgs)
    {
        filterByJob = changeEventArgs.Value.ToString();
        Filter();
    }

    private void Filter()
    {
        adultsToShow = allAdults.Where(a => (filterByName == null
                                             || a.FirstName.ToLower().Contains(filterByName.ToLower()))
                                            && (filterByJob == null
                                                || a.JobTitle.JobTitle.ToLower().Contains(filterByJob.ToLower()))).ToList();
    }

    private void EditAdult(Adult adult)
    {
        NavigationManager.NavigateTo($"/Edit/{adult.Id}");
    }

    private void RemoveAdult(Adult adult)
    {
        AdultPersistence.RemoveAdult(adult.Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultPer AdultPersistence { get; set; }
    }
}
#pragma warning restore 1591
