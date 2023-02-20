using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegDatosAdic
{
    public decimal FlegDatId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime FlegDatFecInicio { get; set; }

    public DateTime FlegDatFecTermino { get; set; }

    public DateTime FlegDatFecProgresivo { get; set; }

    public short FlegDatMesProgresivo { get; set; }

    public DateTime FlegDatFecBase { get; set; }

    public short FlegDatDiasPactados { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;
}
