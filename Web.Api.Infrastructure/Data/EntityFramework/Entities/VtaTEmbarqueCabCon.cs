using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTEmbarqueCabCon
{
    public decimal PEmbarqueCabId { get; set; }

    public byte EmcIndPago { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
