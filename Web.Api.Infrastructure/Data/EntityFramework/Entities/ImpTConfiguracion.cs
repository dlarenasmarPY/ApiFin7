using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public short TdoId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaIdDolar { get; set; }

    public decimal PMonedaIdDolarAduanero { get; set; }

    public DateTime FechaVigencia { get; set; }

    public decimal Apoderado1 { get; set; }

    public decimal Apoderado2 { get; set; }

    public decimal Apoderado3 { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PPaisId { get; set; }
}
