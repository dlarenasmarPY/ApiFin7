using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTGrupoVisacionCabVi
{
    public decimal PGrupoVisacionCabId { get; set; }

    public short TpeCodigo { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
