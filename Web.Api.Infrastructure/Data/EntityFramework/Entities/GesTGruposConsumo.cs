using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GesTGruposConsumo
{
    public decimal PEmpId { get; set; }

    public string GrpConsCod { get; set; } = null!;

    public string GrpConsGlosa { get; set; } = null!;

    public byte Mensual { get; set; }

    public decimal PPerConId { get; set; }

    public byte PerCalPromConsumo { get; set; }

    public double NivelMaximo { get; set; }

    public double NivelMinimo { get; set; }

    public double NivelCritico { get; set; }

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
