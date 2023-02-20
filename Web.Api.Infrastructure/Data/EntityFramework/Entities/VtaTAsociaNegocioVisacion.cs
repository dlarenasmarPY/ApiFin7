using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTAsociaNegocioVisacion
{
    public decimal AsociaNegVisacionId { get; set; }

    public decimal PEmpId { get; set; }

    public byte TfuCodigo { get; set; }

    public decimal PNegocioVtaId { get; set; }

    public decimal PGrupoVisacionCabId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
