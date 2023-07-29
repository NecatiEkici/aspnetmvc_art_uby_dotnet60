using System;
using System.Collections.Generic;

namespace Art.Models.Entities;

public partial class About
{
    public int Id { get; set; }

    public string? Image { get; set; }

    public string? Detail { get; set; }
}
