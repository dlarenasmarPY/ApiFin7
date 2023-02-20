using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ObrTProyectoUsuario
{
    public short IdAdm { get; set; }

    public string IdUsuario { get; set; } = null!;

    public int PproyectoId { get; set; }
}
