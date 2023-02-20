using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTUnidadEmisoraDet
{
    public decimal UnidadEmisoraDetId { get; set; }

    public decimal PUnidadEmisoraCabId { get; set; }

    public string UedUsuario { get; set; } = null!;

    public short TdoId { get; set; }

    public byte UedIndDefecto { get; set; }

    public decimal PImpresoraMatrizId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
