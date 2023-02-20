using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoReajustesDet
{
    public decimal PRteId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal RteDetValorAnt { get; set; }

    public decimal RteDetValorNue { get; set; }

    public byte RteIndOrigen { get; set; }

    public decimal PPerRtaId { get; set; }

    public decimal PPerRtaNueId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTCtoReajuste PRte { get; set; } = null!;
}
