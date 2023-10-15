using System;
using System.Collections.Generic;
using DPA202302ParcialCaso0221200160.Interfaz;

namespace DPA202302ParcialCaso0221200160.Data;

public partial class Territory : TerritoryRepository
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? Area { get; set; }

    public string? Population { get; set; }
}
