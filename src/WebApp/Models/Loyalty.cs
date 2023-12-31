﻿namespace Pitstop.WebApp.Models;

public class Loyalty
{
    [Required]
    [Display(Name = "CustomerId")]
    public string CustomerId { get; set; }

    [Display(Name = "Points")]
    public int Points { get; set; }
    [Display(Name = "Category")]
    public string Category { get; set; }
}