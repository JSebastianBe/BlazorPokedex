using System;

namespace BlazorPokedex.Models;

public class PaginationButton
{
    public string Text { get; set; }
    public int PageNumber { get; set; }
    public bool IsActive { get; set; }
    public bool Enabled { get; set; }

    public PaginationButton(int page, bool enabled, string text = "")
    {
        Text = text;
        PageNumber = page;
        Enabled = enabled;
    }
}
