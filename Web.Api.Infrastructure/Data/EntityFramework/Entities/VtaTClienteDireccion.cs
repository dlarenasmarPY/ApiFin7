using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTClienteDireccion
{
    public decimal PEntDirId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PRutaDespId { get; set; }

    public byte Orden { get; set; }

    public string MedioTransporte { get; set; } = null!;

    public string AgenteTransporte { get; set; } = null!;

    public string DireccionExportacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
