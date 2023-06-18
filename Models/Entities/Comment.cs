using System;
using System.Collections.Generic;

namespace Art.Models.Entities;

public partial class Comment
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public int? Typeid { get; set; }

    public string? Person { get; set; }

    public DateTime? Date { get; set; }

    public string? Comment1 { get; set; }
}
