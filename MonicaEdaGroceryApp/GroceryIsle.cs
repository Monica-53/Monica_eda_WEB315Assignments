using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class GroceryIsle
{
    public string Name { get; set; }
     [StringLength(31, MinimumLength = 3)]
    [Required]
    [Display(Name = "Peas")]
    public string cannedGoodsAisle { get; set; }
   
   
   
        [StringLength(63, MinimumLength = 3)]
        [Required]
        [Display(Name = "pizza")]
        public string frozenfoodsAisle { get; set; }

        [StringLength(63, MinimumLength = 3)]
        [Required]
        [Display(Name = "Lucky charms")]
      
public string CerealsAisle { get; set; }
    
}