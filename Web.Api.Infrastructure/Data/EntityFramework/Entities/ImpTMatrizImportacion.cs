using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTMatrizImportacion
{
    public decimal MatrizId { get; set; }

    public decimal MatrizCod { get; set; }

    public string MatrizGlosa { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public decimal PConceptoImpId { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
