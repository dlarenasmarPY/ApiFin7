using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTPlantilla
{
    public byte PlantillaId { get; set; }

    public string PlantillaDesc { get; set; } = null!;
}
