#pragma checksum "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b883d2c60bef6124ecfddcb3d79cefa3d8719635"
// <auto-generated/>
#pragma warning disable 1591
namespace MonicaEdaGroceryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using MonicaEdaGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\_Imports.razor"
using MonicaEdaGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "GroceryStore(");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
                  GroceryStoreList.Count(singleTodoItem => !singleTodoItem.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "placeholder", "Search");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
                                   newGroceryStore

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newGroceryStore = __value, newGroceryStore));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
                  AddGroceryStore

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Add GroceryStore");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "ul");
#nullable restore
#line 7 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
     foreach (var GroceryStore in GroceryStoreList)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
         if (!GroceryStore.IsDone) // only show the item if we haven't finished it
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "li");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "checkbox");
            __builder.AddAttribute(18, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
                                                GroceryStore.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GroceryStore.IsDone = __value, GroceryStore.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
                               GroceryStore.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GroceryStore.Title = __value, GroceryStore.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
         
     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryAPP\Pages\GroceryStore.razor"
       
    private List<FoodItem> GroceryStoreList = new();
    private String newGroceryStore; 
    private void AddGroceryStore()
     {
         
        if (!string.IsNullOrWhiteSpace(newGroceryStore))
        {
            GroceryStoreList.Add(new FoodItem { Title = newGroceryStore });
            newGroceryStore = ""; //string.Empty;
        }
        //GroceryStore:Add the GroceryStore
    } 

    //this is a long version of the lamda method inside of the todoList.Count
    private bool GroceryStoreIsDone(FoodItem singleFoodItem )
    {
        return !singleFoodItem.IsDone;
    }
    
    
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
