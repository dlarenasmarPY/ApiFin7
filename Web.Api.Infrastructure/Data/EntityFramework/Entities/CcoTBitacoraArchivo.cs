using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTBitacoraArchivo
{
    public decimal BitArchCcoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PFrmCcoId { get; set; }

    public decimal PCabNomExtId { get; set; }

    public decimal PCabNomId { get; set; }

    public string BitArchCcoArchivo { get; set; } = null!;

    public DateTime BitArchCcoFecRegistro { get; set; }

    public string BitArchCcoOwner { get; set; } = null!;

    public byte BitArchCcoEstado { get; set; }

    public DateTime BitArchCcoFecEstado { get; set; }

    public string BitArchCcoObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
