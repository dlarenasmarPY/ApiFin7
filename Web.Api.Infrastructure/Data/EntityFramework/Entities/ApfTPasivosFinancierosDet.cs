using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTPasivosFinancierosDet
{
    public decimal PasDetDocumentoId { get; set; }

    public decimal PPasDocumentoId { get; set; }

    public int LineaDocto { get; set; }

    public int NumeroCuota { get; set; }

    public DateTime FechaVenc { get; set; }

    public double MontoIntereses { get; set; }

    public double MontoCuota { get; set; }

    public byte EstadoCuota { get; set; }

    public short PerId { get; set; }

    public decimal PCabOpeId { get; set; }

    public string PasActUsuario { get; set; } = null!;

    public DateTime PasActFecha { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PMovCceId { get; set; }

    public double SaldoCapital { get; set; }

    public int NumDias { get; set; }
}
