using System;
using System.Collections.Generic;

namespace Art.Models.Entities;

public partial class Subscribe
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }
}
