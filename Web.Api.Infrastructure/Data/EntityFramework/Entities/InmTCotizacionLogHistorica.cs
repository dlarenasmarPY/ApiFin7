using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCotizacionLogHistorica
{
    public decimal PEmpId { get; set; }

    public decimal PCotizacionId { get; set; }

    public int CotDocNumInterno { get; set; }

    public int VenIdOld { get; set; }

    public int VenIdNew { get; set; }

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public DateTime FechaUpdate { get; set; }

    public int PTprId { get; set; }

    public string ProcNombre { get; set; } = null!;
}
