﻿namespace BethanyPieShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty; // not nullable
        public string? Description { get; set; }
        public List<Pie>? Pies { get; set; }
    }
}
