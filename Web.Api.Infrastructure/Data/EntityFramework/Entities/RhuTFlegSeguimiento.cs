using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegSeguimiento
{
    public decimal FlegSegId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime FlegSegFecha { get; set; }

    public string FlegSegAccion { get; set; } = null!;

    public string FlegSegDescripcion { get; set; } = null!;

    public decimal PFlegMabId { get; set; }

    public double FlegMabDiasDer { get; set; }

    public double FlegMabDiasPro { get; set; }

    public double FlegMabDiasAdi { get; set; }

    public double FlegMabDiasSal { get; set; }

    public double FlegMprDias { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
