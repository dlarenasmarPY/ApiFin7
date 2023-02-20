using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTAsociaDivUniVentaCompra
{
    public decimal PEmpId { get; set; }

    public decimal PEmpIdCompra { get; set; }

    public byte AduTipoAsocia { get; set; }

    public short AduCodigoOrigen { get; set; }

    public short AduCodigoDestino { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
