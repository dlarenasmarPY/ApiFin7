using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTUnidadEmisoraDetFol
{
    public decimal UnidadEmisoraDetFolId { get; set; }

    public decimal PUnidadEmisoraDetId { get; set; }

    public short PerId { get; set; }

    public int UefFolioInicial { get; set; }

    public int UefFolioFinal { get; set; }

    public int UefFolioActual { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PUnidadEmisoraCabId { get; set; }

    public short TdoId { get; set; }
}
