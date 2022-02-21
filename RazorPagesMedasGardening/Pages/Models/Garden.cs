using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesGarden.Models
{
    public class Garden
    {
        public int ID { get; set; }
        public string Title{ get; set; }

        [DataType(DataType.Date)]
        public DateTime plantingDate { get; set; }
        public string TypeOfGarden  { get; set; }
        public decimal PriceOfSeeds{ get; set; }
        
    }
}