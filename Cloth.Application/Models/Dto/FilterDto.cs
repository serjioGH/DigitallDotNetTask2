﻿namespace Cloth.Application.Models.Dto;

public class FilterDto
{
    public decimal? MinPrice { get; set; }

    public decimal? MaxPrice { get; set; }

    public List<string> Sizes { get; set; } = new List<string>();

    public List<string> CommonWords { get; set; } = new List<string>();
}