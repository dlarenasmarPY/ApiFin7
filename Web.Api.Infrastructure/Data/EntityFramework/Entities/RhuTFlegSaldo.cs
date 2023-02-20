using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegSaldo
{
    public int CorrelativoExp { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public double FlegIniSaldo { get; set; }

    public DateTime FlegIniFecha { get; set; }

    public string FlegIniRuta { get; set; } = null!;

    public string FlegIniArchivo { get; set; } = null!;

    public decimal FlegIniEstId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double FlegProgresivos { get; set; }
}
