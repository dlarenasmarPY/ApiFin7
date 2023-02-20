using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntImponible
{
    public decimal AntImpId { get; set; }

    public decimal PFicPerId { get; set; }

    public DateTime IinfFecVigencia { get; set; }

    public string IinfEntRut { get; set; } = null!;

    public string IinfEntRazonSocial { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public decimal IinfValor { get; set; }

    public decimal PItmTpInfId { get; set; }

    public string IinfObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmTpInf { get; set; } = null!;

    public virtual RhuTParMoneda PMoneda { get; set; } = null!;
}
