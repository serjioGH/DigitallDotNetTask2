﻿namespace Cloth.API.Models.Requests.Cloth;

public class ClothFilterRequest
{
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public string? Size { get; set; }
    public string? Highlight { get; set; }
}
