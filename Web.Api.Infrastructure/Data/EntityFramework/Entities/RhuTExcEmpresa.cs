using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTExcEmpresa
{
    public decimal ExcEsaId { get; set; }

    public decimal PTexId { get; set; }

    public decimal PEmpId { get; set; }

    public short ExcEsaValor { get; set; }

    public decimal PItmTraExcId { get; set; }

    public bool ExcEsaTipDia { get; set; }

    public bool ExcEsaRebDia { get; set; }

    public bool ExcEsaInfDia { get; set; }

    public bool ExcEsaInfPag { get; set; }

    public bool ExcEsaTipVig { get; set; }

    public short ExcEsaDiaVig { get; set; }

    public decimal PConcRemId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public bool ExcEsaDia31 { get; set; }

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual RhuTParItem PItmTraExc { get; set; } = null!;

    public virtual RhuTExcTipExc PTex { get; set; } = null!;

    public virtual ICollection<RhuTExcTipPago> RhuTExcTipPagos { get; } = new List<RhuTExcTipPago>();
}
