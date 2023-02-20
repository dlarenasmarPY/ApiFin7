using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntSalud
{
    public decimal AntSaludId { get; set; }

    public decimal PFicPerId { get; set; }

    public DateTime SalFecVigencia { get; set; }

    public DateTime SalFecPrimeraAfi { get; set; }

    public decimal PInsParSaludId { get; set; }

    public string SalFun { get; set; } = null!;

    public DateTime SalFecContratoFun { get; set; }

    public DateTime SalFecBeneficio { get; set; }

    public DateTime SalFecRecepcion { get; set; }

    public decimal PMonedaPlanId { get; set; }

    public decimal SalPlan { get; set; }

    public decimal PMonedaL18566id { get; set; }

    public decimal SalValorL18566 { get; set; }

    public decimal PMonedaAugeId { get; set; }

    public double SalAuge { get; set; }

    public byte SalEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;
}
