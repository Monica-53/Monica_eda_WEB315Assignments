#pragma checksum "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9af7e6e5111ced04e5dfb5339c03a1544e88e2"
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
#line 1 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using MonicaEdaGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\_Imports.razor"
using MonicaEdaGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/groceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "GroceryStore(");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                  newGroceryIsle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.AddMarkupContent(5, "<h3>add Food Item to an isle</h3>\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "placeholder", "Search");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                                   newGroceryIsle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newGroceryIsle = __value, newGroceryIsle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                                          AddGroceryIsle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Add GroceryStore");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "ul");
            __builder.AddMarkupContent(17, "Store\r\n");
#nullable restore
#line 8 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
     foreach (var grocerystore in newGroceryIsle )
    {
        
    
       

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "li");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "checkbox");
            __builder.AddAttribute(21, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                                                newGroceryIsle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newGroceryIsle = __value, newGroceryIsle));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                               newGroceryIsle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newGroceryIsle = __value, newGroceryIsle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddContent(29, 
#nullable restore
#line 16 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                      newGroceryIsle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, ".");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"



        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "     }\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.OpenElement(33, "ul");
#nullable restore
#line 27 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
     foreach(var GroceryStore in newGroceryIsle )
    {
   //only show the item if we haven't finished it
        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "li");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "checkbox");
            __builder.AddAttribute(37, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                                                GroceryStore

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GroceryStore = __value, GroceryStore));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                              GroceryStore

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GroceryStore = __value, GroceryStore));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddContent(45, 
#nullable restore
#line 34 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
                      GroceryStore

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(46, ".");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "    }\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n\r\n;\r\n\r\n           \r\n    \r\n\r\n\r\n \r\n\r\n\r\n\r\n\r\n\r\n        \r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\edamo\Documents\GitHub\Monica_eda_WEB315Assignments\MonicaEdaGroceryApp\Pages\GroceryStore.razor"
       
    private List<GroceryIsle>isles=new();


    private String newGroceryIsle; 
    private List <FoodItem> anotherList = new();
    private void AddGroceryIsle()
     {
         FoodItem newItem; //if we end up making a new item, we want to store it here


         
        if (!string.IsNullOrWhiteSpace(newGroceryIsle)) //does the new GroceryStore contain a value?
        {
            //if it does, we add it to the list
            newGroceryIsle = "CannedFood"; //string Empty;
            newItem = new FoodItem
            {
                name ="Tuna",
                quantity = 3,
                 brand ="Genova",
                 price= 6.00
              
            };
        
        
                newItem = new FoodItem
            {
                name ="Peas",
                quantity = 3,
                 brand ="Noname",
                 price= 6.00
              
            };

        
            newGroceryIsle = "cereals"; //string Empty;
                newItem = new FoodItem
            {
                name ="corn flakes",
                quantity = 2,
                brand ="Kellogg",
                price= 10.00


              
            };

              newItem = new FoodItem
           
             {
                
                name ="Cheerios",
                quantity = 3,
                brand ="Generalmills",
                price= 15.00

                
              
            };

            newGroceryIsle = "FrozenFood"; //string Empty;
            newItem = new FoodItem
            {
                name ="Pizza",
                quantity = 2,
                 brand ="Rissoto",
                 price= 10.00
              
            };
        
        
                newItem = new FoodItem
            {
                name ="",
                quantity = 3,
                 brand ="Noname",
                 price= 6.00
              
            };
            
        }

        //GroceryStore: Add the fooditem
     }

                  

            

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
