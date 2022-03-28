public class FoodItem
{
    public string FoodName { get; set; }
    
    public int quantity { get; set; }
  
    public string price { get; set; }
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


  }




