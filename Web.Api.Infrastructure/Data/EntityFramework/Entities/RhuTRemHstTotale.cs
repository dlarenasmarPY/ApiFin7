using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemHstTotale
{
    public decimal PLiqTotId { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal LqTperId { get; set; }

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

    public int LqTdiasPago { get; set; }

    public int LqTdiasLicencia { get; set; }

    public double LqTalcanceLiquido { get; set; }

    public double LqTotrosDesctos { get; set; }

    public double LqTtdescuentos { get; set; }

    public double LqTmontoLiquido { get; set; }

    public double LqTmontoSobregiro { get; set; }

    public double LqTthaberesAcc { get; set; }

    public double LqTtimponibleAcc { get; set; }

    public double LqTtimponTopeAcc { get; set; }

    public double LqTtimponTopeSalAcc { get; set; }

    public double LqTtnoImponibleAcc { get; set; }

    public double LqTttributableAcc { get; set; }

    public double LqTtprevPensionAcc { get; set; }

    public double LqTtprevSaludAcc { get; set; }

    public double LqTtprevSegCesAcc { get; set; }

    public double LqTtafectoImptoAcc { get; set; }

    public double LqTtimpuestosAcc { get; set; }

    public decimal LqTrefPagoLiq { get; set; }

    public decimal LqTrefCentraliz { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
