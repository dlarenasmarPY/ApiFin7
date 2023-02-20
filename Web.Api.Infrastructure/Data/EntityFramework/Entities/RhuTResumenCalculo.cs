using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTResumenCalculo
{
    public decimal ResCalId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PResIdentity { get; set; }

    public DateTime ResCalFecPago { get; set; }

    public decimal PConcRemId { get; set; }

    public double ResCalValor { get; set; }

    public byte ResCalDias { get; set; }

    public decimal PItmParId { get; set; }

    public decimal PLiqId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTParItem PItmPar { get; set; } = null!;
}
