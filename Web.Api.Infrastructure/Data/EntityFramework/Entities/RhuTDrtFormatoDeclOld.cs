using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTDrtFormatoDeclOld
{
    public decimal DrtFrmId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PDrtDicId { get; set; }

    public short DrtFrmOrden { get; set; }

    public decimal DrtFrmTipDato { get; set; }

    public short DrtFrmLenDato { get; set; }

    public short DrtFrmDecDato { get; set; }

    public string DrtFrmValDefAlf { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
