using System;
using System.Collections.Generic;

namespace Art.Models.Entities;

public partial class Blog
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Detail { get; set; }

    public bool? Isview { get; set; }

    public DateTime? Date { get; set; }

    public int? Like { get; set; }

    public int? Read { get; set; }

    public string? Image { get; set; }
}
