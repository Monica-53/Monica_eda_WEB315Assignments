created a new branch on the repository used in assignment 01 and called the new branch Assignment02
contents of the branch are cleared out so that there are no files from assignment 1 in the branch
committs are made often 
A new Blazor Server Application created and named MonicaEdaGroceryApp
A new file added to the app and called FoodItem.cs
To FoodItem.cs file a quantity number and three other properties are added
Another file GroceryIsle.cs is added to app
A razor component GroceryStore is added to the app
In FoodItem.cs the following code is added.
public class FoodItem
{
    public string name{ get; set; }
    
    public int quantity { get; set; }
  
    public double price { get; set; }
    public string brand { get; set; }
    public bool IsDone { get; set; }
 public void IncreaseQuantity()
  {
      if(quantity<20)
      quantity=quantity +1;
  }

    public void DecreaseQuantity()
    
    {
         if(quantity>0)
      quantity=quantity-1;
    }
    In GroceryIsle.cs
    the following code is added. I wrote code first then changed it to the following because the previous did not work 
    using System;

using System.Collections.Generic;

public class GroceryIsle
{
    
    public string name;
   
    public int Id; 

    public List<FoodItem>items; 
    
}

I committed changes in git hub
In Groceryisle.cs I tried different codes to insert grocery isles,Id and 2 fooditems under each grocery isle. 
buttons are also included
inout boxes added.








