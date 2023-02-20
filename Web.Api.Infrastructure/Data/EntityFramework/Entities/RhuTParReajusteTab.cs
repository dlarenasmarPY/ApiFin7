using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParReajusteTab
{
    public decimal ParReaId { get; set; }

    public decimal PEmpId { get; set; }

    public DateTime ParReaFecha { get; set; }

    public decimal PTabParId { get; set; }

    public decimal ParReaValor01 { get; set; }

    public decimal ParReaValor02 { get; set; }

    public decimal ParReaValor03 { get; set; }

    public decimal ParReaValor04 { get; set; }

    public decimal ParReaValor05 { get; set; }

    public decimal ParReaValor06 { get; set; }

    public decimal ParReaValor07 { get; set; }

    public decimal ParReaValor08 { get; set; }

    public decimal ParReaValor09 { get; set; }

    public decimal ParReaValor10 { get; set; }

    public byte ParReaRedondeo { get; set; }

    public decimal ParReaDesde { get; set; }

    public decimal ParReaHasta { get; set; }

    public string ParReaObserv { get; set; } = null!;

    public string ItmEstado { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTParReajusteTabDet> RhuTParReajusteTabDets { get; } = new List<RhuTParReajusteTabDet>();
}
