using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemLiqAccesorio
{
    public decimal LiqAccId { get; set; }

    public decimal PLiqId { get; set; }

    public decimal LqTperId { get; set; }

    public decimal LqTperIdDev { get; set; }

    public double LqTthaberes { get; set; }

    public double LqTthabInemb { get; set; }

    public double LqTtimponible { get; set; }

    public double LqTtimponInf { get; set; }

    public double LqTtnoImponible { get; set; }

    public double LqTtimponTope { get; set; }

    public double LqTtimponTopeSal { get; set; }

    public double LqTtimponTopeSegC { get; set; }

    public double LqTtimponTopeMut { get; set; }

    public double LqTttributable { get; set; }

    public double LqTtnoTributable { get; set; }

    public double LqTtprevPension { get; set; }

    public double LqTtdepConvInf { get; set; }

    public double LqTtprevSalud { get; set; }

    public double LqTtprevSegCes { get; set; }

    public double LqTtafectoImpto { get; set; }

    public double LqTtimpuestos { get; set; }

    public double LqTtdescLegales { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemLiqAntecedente PLiq { get; set; } = null!;
}
