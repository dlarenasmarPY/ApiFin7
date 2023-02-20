using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntApv
{
    public decimal AntApvId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PInstApvId { get; set; }

    public DateTime ApvFecVigencia { get; set; }

    public DateTime ApvFecTermino { get; set; }

    public string ApvNumPoliza { get; set; } = null!;

    public DateTime ApvFecSuscripcion { get; set; }

    public DateTime ApvFecDescuento { get; set; }

    public decimal PItmOrigenAhId { get; set; }

    public decimal PItmFpagoId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal ApvValor { get; set; }

    public decimal ApvRegTributario { get; set; }

    public decimal PItmEstApvId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmEstApv { get; set; } = null!;

    public virtual RhuTParItem PItmFpago { get; set; } = null!;

    public virtual RhuTParItem PItmOrigenAh { get; set; } = null!;
}
