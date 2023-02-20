using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntAfp
{
    public decimal AntAfpId { get; set; }

    public decimal PFicPerId { get; set; }

    public DateTime AfpFecVigencia { get; set; }

    public DateTime AfpFecPrimeraAfi { get; set; }

    public decimal PInsParAfpId { get; set; }

    public string AfpFun { get; set; } = null!;

    public DateTime AfpFecContratoFun { get; set; }

    public DateTime AfpFecRecepcion { get; set; }

    public decimal PMonedaVolId { get; set; }

    public decimal AfpVoluntario { get; set; }

    public decimal AfpRegTributario { get; set; }

    public decimal PMonedaAhoId { get; set; }

    public decimal AfpAhorro { get; set; }

    public decimal PMonedaDepConId { get; set; }

    public decimal AfpDepConvenido { get; set; }

    public decimal PAfcEntId { get; set; }

    public byte AfpEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;
}
