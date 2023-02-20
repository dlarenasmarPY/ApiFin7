using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpcab
{
    public decimal OpcabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PSeccionId { get; set; }

    public decimal PPryId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PBodegaId { get; set; }

    public DateTime FechaProceso { get; set; }

    public DateTime FechaEntrega { get; set; }

    public string EstadoCod { get; set; } = null!;

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioCierre { get; set; } = null!;

    public DateTime FechaCierre { get; set; }

    public byte IndImpreso { get; set; }

    public int NumeroRef { get; set; }

    public decimal PUbicacionId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short PerId { get; set; }
}
