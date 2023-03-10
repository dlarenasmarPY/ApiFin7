using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTTipoOperacionDgl
{
    public decimal TipoOpeDglId { get; set; }

    public decimal PTipoOpeDetId { get; set; }

    public int OpeDglLinea { get; set; }

    public decimal PCtaId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCreId { get; set; }

    public int OpeDglPorcDist { get; set; }

    public byte OpeDgIva { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int ImpSiiId { get; set; }

    public byte ConSinCredito { get; set; }
}
