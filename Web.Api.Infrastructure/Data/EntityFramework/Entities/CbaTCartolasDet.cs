using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CbaTCartolasDet
{
    public decimal DetCbaId { get; set; }

    public decimal PCabCbaId { get; set; }

    public int CarDetLinea { get; set; }

    public int CarDetNumeroDoc { get; set; }

    public decimal PCtbId { get; set; }

    public DateTime CarDetFecha { get; set; }

    public byte CarDetEstado { get; set; }

    public double CarDetCargo { get; set; }

    public double CarDetAbono { get; set; }

    public int MovTesConNumero { get; set; }

    public DateTime MovTesConFecha { get; set; }

    public string MovTesOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual CbaTCartola PCabCba { get; set; } = null!;
}
