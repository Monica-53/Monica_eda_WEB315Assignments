created a new branch on the repository used in assignment 01 and called the new branch Assignment02
contents of the branch are cleared out so that there are no files from assignment 1 in the branch
committs are made often 
A new Blazor Server Application created and named MonicaEdaGroceryApp
A new file added to the app and called FoodItem.cs
To FoodItem.cs file a quantity number and three other properties are added
Another file GroceryIsle.cs is added to app
A razor component GroceryStore is added to the app
In FoodItem.cs the following code is added.
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



