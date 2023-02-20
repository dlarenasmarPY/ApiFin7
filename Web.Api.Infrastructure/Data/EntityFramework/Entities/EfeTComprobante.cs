using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class EfeTComprobante
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short PerId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public int CabOpeNumero { get; set; }

    public int CabOpeLinea { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public decimal PCtaId { get; set; }

    public short TcoId { get; set; }

    public int ComNumero { get; set; }

    public string CabOpeGlosa { get; set; } = null!;

    public double MovConMontoLocalDebe { get; set; }

    public double MovConMontoLocalHaber { get; set; }

    public double MovConMontoConvDebe { get; set; }

    public double MovConMontoConvHaber { get; set; }

    public decimal EfeFlujoFlag { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PCabOpeId { get; set; }

    public byte SisCodOri { get; set; }
}
