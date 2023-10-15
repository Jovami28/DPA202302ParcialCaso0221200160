using System;
using System.Collections.Generic;

namespace DPA202302ParcialCaso0221200160.Data;

public partial class Country
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Currency { get; set; }
}
