using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTRutaDespacho
{
    public decimal RutaDespId { get; set; }

    public string RutaDespDes { get; set; } = null!;

    public decimal PTipoVehId { get; set; }
}
