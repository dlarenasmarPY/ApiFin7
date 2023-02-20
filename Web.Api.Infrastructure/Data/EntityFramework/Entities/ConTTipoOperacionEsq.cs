using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTTipoOperacionEsq
{
    public decimal TipoOpeEsqId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public short OpeEsqLinea { get; set; }

    public decimal PCtaId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PLineaProdId { get; set; }

    public decimal PGtoId { get; set; }

    public int OpeEsqPorcDebe { get; set; }

    public int OpeEsqPorcHaber { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
