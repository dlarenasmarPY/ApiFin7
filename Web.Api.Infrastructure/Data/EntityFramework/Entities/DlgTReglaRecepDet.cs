using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTReglaRecepDet
{
    public decimal PReglaRecepCabId { get; set; }

    public decimal PEntId { get; set; }

    public string RrdCodigoInterno { get; set; } = null!;

    public DateTime RrdFecVigencia { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
