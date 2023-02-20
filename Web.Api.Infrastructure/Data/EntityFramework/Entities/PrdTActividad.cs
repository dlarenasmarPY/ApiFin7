using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTActividad
{
    public decimal ActividadId { get; set; }

    public string ActividadCod { get; set; } = null!;

    public string ActividadDes { get; set; } = null!;

    public byte IndProductiva { get; set; }

    public byte IndInfGranel { get; set; }

    public byte IndInfProduccion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
