using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTPasivosFinancierosGasto
{
    public decimal PasGasDocumentoId { get; set; }

    public decimal PPasDocumentoId { get; set; }

    public int LineaGasto { get; set; }

    public short TgasCodigo { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public double Monto { get; set; }

    public short TesDocTipoDocCalce { get; set; }

    public string TesDocNumDocCalce { get; set; } = null!;

    public string PasActUsuario { get; set; } = null!;

    public DateTime PasActFecha { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
