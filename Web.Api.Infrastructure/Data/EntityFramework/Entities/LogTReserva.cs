using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTReserva
{
    public byte ProcesoReservaActivo { get; set; }

    public DateTime FechaActivacion { get; set; }
}
