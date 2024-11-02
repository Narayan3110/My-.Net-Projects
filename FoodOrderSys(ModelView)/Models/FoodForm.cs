using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace FoodOrderSys_ModelView_.Models
{
    public class FoodForm
    {
        [Required(ErrorMessage ="Enter the Name")]
        public string Name { get; set; }
        [Required (ErrorMessage ="please let us know what u want to eat ??")]
        public string FoodName { get; set; }
        [Required(ErrorMessage = "Hotel Name??")]
        public string OrderFrom { get; set; }

        public int Quantity { get; set; }
        public bool? Want { get; set; }

    }
}