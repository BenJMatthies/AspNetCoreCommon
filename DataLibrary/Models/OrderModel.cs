using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Keep to 20 characters.")]
        [MinLength(3, ErrorMessage = "Must be at least 3 characters.")]
        [DisplayName("Name for the Order")]
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        [DisplayName("Meal")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a meal from the list")]
        public int FoodId { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Must be between one and ten.")]
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
