// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroceryIsle")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/FoodItem")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/groceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
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
