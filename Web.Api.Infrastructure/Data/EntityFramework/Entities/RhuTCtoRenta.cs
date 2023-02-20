using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoRenta
{
    public decimal RtaId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PConcRemId { get; set; }

    public DateTime RtaFecVigDesde { get; set; }

    public DateTime RtaFecVigHasta { get; set; }

    public decimal RtaValNumerico { get; set; }

    public string RtaValAlfNum { get; set; } = null!;

    public DateTime RtaValFecha { get; set; }

    public short RtaValHora { get; set; }

    public decimal RtaValBaseNum { get; set; }

    public string RtaValBaseAlf { get; set; } = null!;

    public byte RtaTipo { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;
}
