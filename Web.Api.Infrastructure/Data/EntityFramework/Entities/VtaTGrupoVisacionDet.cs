using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTGrupoVisacionDet
{
    public decimal PGrupoVisacionCabId { get; set; }

    public string UserVisador { get; set; } = null!;

    public double GvdMontoMaximo { get; set; }

    public byte GvdPrioridad { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
