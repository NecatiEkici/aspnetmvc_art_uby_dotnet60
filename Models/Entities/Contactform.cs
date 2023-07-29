using System;
using System.Collections.Generic;

namespace Art.Models.Entities;

public partial class Contactform
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Lastname { get; set; }

    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public DateTime? Date { get; set; }

    public bool? Isview { get; set; }
}
