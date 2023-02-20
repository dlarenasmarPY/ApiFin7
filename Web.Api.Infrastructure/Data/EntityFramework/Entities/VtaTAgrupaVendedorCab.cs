using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTAgrupaVendedorCab
{
    public decimal AgrupaVendedorCabId { get; set; }

    public decimal PEmpId { get; set; }

    public string AvcGlosa { get; set; } = null!;

    public byte AvcTipoAgrupacion { get; set; }

    public decimal AvcResponsableId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
