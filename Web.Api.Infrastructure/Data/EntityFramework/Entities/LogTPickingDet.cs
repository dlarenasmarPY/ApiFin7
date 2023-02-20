using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTPickingDet
{
    public decimal PickingDetId { get; set; }

    public decimal PPickingId { get; set; }

    public decimal PReservasDetId { get; set; }

    public decimal PProductoCodId { get; set; }

    public double CantPedStock { get; set; }

    public double CantAprepStock { get; set; }

    public double CantPrepStock { get; set; }

    public double CantPrepStock2 { get; set; }

    public decimal PUnidadMed2Id { get; set; }

    public double CantLeida { get; set; }

    public string GlosaExis { get; set; } = null!;

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioConfirma { get; set; } = null!;

    public DateTime FechaConfirma { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double CantidadPreparada { get; set; }

    public decimal PDoctoVentaDetId { get; set; }

    public virtual ICollection<LogTPickingDetUbicacion> LogTPickingDetUbicacions { get; } = new List<LogTPickingDetUbicacion>();

    public virtual LogTPickingCab PPicking { get; set; } = null!;

    public virtual LogTReservasDet PReservasDet { get; set; } = null!;
}
