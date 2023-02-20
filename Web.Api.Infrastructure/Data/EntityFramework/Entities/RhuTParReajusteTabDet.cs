using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParReajusteTabDet
{
    public decimal ParReaDetId { get; set; }

    public decimal PParReaId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PTabParId { get; set; }

    public decimal PItmParId { get; set; }

    public decimal VitValPar1 { get; set; }

    public decimal ParReaValor01 { get; set; }

    public decimal VitValPar2 { get; set; }

    public decimal ParReaValor02 { get; set; }

    public decimal VitValPar3 { get; set; }

    public decimal ParReaValor03 { get; set; }

    public decimal VitValPar4 { get; set; }

    public decimal ParReaValor04 { get; set; }

    public decimal VitValPar5 { get; set; }

    public decimal ParReaValor05 { get; set; }

    public decimal VitValPar6 { get; set; }

    public decimal ParReaValor06 { get; set; }

    public decimal VitValPar7 { get; set; }

    public decimal ParReaValor07 { get; set; }

    public decimal VitValPar8 { get; set; }

    public decimal ParReaValor08 { get; set; }

    public decimal VitValPar9 { get; set; }

    public decimal ParReaValor09 { get; set; }

    public decimal VitValPar10 { get; set; }

    public decimal ParReaValor10 { get; set; }

    public string ItmEstado { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParReajusteTab PParRea { get; set; } = null!;
}
