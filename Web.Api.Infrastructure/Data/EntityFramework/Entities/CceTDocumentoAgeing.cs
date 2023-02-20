using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CceTDocumentoAgeing
{
    public decimal DocAgeId { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PDocCceId { get; set; }

    public short MovCceNumCuota { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PDocAgeDocPagId { get; set; }

    public DateTime DocAgeFecVenOri { get; set; }

    public DateTime DocAgeFecVenPago { get; set; }

    public DateTime DocAgeFecPago { get; set; }

    public double DocAgeMonPagOriImpuDebe { get; set; }

    public double DocAgeMonpagOriImpuHaber { get; set; }

    public double DocAgeMonPagRealImpuDebe { get; set; }

    public double DocAgeMonPagRealImpuHaber { get; set; }

    public double DocAgeMontoLocalDebe { get; set; }

    public double DocAgeMontoLocalHaber { get; set; }

    public double DocAgeMontoRealLocalDebe { get; set; }

    public double DocAgeMontoRealLocalHaber { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double? DocAgeMontoConvDebe { get; set; }

    public double? DocAgeMontoConvHaber { get; set; }
}
