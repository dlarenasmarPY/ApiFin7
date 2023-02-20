using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTArchivoInventario
{
    public decimal ArchInventarioId { get; set; }

    public decimal PProInvCabId { get; set; }

    public int Linea { get; set; }

    public string AfiUbiCodBarra { get; set; } = null!;

    public string AfiCodBarraBien { get; set; } = null!;

    public DateTime AfiFechaProceso { get; set; }

    public string UserRespDetPrInv { get; set; } = null!;

    public string NombreArchivoCarga { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
