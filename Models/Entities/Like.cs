using System;
using System.Collections.Generic;

namespace Art.Models.Entities;

public partial class Like
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public int? Typeid { get; set; }

    public string? Ip { get; set; }
}
