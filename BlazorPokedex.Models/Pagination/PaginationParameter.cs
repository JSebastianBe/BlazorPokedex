using System;

namespace BlazorPokedex.Models;

public class PaginationParameter
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public int Offset => (PageNumber - 1) * PageSize;

}
