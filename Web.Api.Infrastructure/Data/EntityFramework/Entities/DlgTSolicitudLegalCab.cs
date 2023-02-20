using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTSolicitudLegalCab
{
    public decimal SolicitudLegalCabId { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PCdoReferenciaId { get; set; }

    public DateTime SlcFecDocto { get; set; }

    public decimal PUnidadEmisoraDetId { get; set; }

    public byte ConEstCod { get; set; }

    public string CodOwner { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
