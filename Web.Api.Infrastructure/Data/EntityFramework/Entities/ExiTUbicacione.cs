using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTUbicacione
{
    public decimal UbicacionId { get; set; }

    public string UbicacionDes { get; set; } = null!;

    public decimal PBodegaId { get; set; }

    public int UbicacionSecuencia { get; set; }

    public string Zona { get; set; } = null!;

    public string Pasillo { get; set; } = null!;

    public string Columna { get; set; } = null!;

    public string Fila { get; set; } = null!;

    public string Subdivision { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<LogTOperacionesLogtDetUbicacion> LogTOperacionesLogtDetUbicacions { get; } = new List<LogTOperacionesLogtDetUbicacion>();

    public virtual ICollection<LogTPickingDetUbicacion> LogTPickingDetUbicacions { get; } = new List<LogTPickingDetUbicacion>();

    public virtual ExiTBodega PBodega { get; set; } = null!;
}
