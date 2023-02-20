using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTBitacoraCheque
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int InstCod { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public decimal PCtaId { get; set; }

    public short TdoId { get; set; }

    public string MovTesNumero { get; set; } = null!;

    public DateTime MovTesFecVenc { get; set; }

    public double MovTesMontoImpuHaber { get; set; }

    public byte MovTesEstado { get; set; }

    public DateTime MovTesFecEstado { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PMovTesId { get; set; }

    public string MovTesGlosa { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
