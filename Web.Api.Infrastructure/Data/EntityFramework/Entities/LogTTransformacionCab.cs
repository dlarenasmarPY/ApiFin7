using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTTransformacionCab
{
    public decimal TranCabId { get; set; }

    public decimal PPedidoMaterialId { get; set; }

    public decimal PReservasCabId { get; set; }

    public byte ConEstCod { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioConfirma { get; set; } = null!;

    public DateTime FechaConfirma { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string LogOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
