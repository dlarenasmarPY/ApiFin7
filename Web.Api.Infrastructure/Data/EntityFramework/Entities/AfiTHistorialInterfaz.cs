using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTHistorialInterfaz
{
    public decimal HistInterfazId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public byte AfiTipoCarga { get; set; }

    public byte AfiEstado { get; set; }

    public string CodOwner { get; set; } = null!;

    public string AfiUserIngreso { get; set; } = null!;

    public DateTime AfiFechaProceso { get; set; }

    public DateTime AfiFechaIngreso { get; set; }

    public int Linea { get; set; }

    public string NombreArchivoCarga { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
