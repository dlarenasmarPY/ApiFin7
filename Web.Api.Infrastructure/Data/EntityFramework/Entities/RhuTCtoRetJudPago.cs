using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoRetJudPago
{
    public decimal RppId { get; set; }

    public decimal PRetJudId { get; set; }

    public decimal PProcRemId { get; set; }

    public byte RppIndRetencion { get; set; }

    public decimal PMdaId { get; set; }

    public decimal RppMontoRetencion { get; set; }

    public string CpeFormula { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParMoneda PMda { get; set; } = null!;

    public virtual RhuTRemProceso PProcRem { get; set; } = null!;

    public virtual RhuTCtoRetJudiciale PRetJud { get; set; } = null!;
}
