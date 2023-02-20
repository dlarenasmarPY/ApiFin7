using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoRetJudiciale
{
    public decimal RetJudId { get; set; }

    public decimal PCtoId { get; set; }

    public string RjuNumOficio { get; set; } = null!;

    public DateTime RjuFecOficio { get; set; }

    public string RjuNumExpediente { get; set; } = null!;

    public DateTime RjuFecInicio { get; set; }

    public DateTime RjuFecTermino { get; set; }

    public decimal PRetenedorEntId { get; set; }

    public string RjuDescripcion { get; set; } = null!;

    public byte RjuDiaPago { get; set; }

    public decimal PReceptorEntId { get; set; }

    public decimal PReceptorEntSucId { get; set; }

    public byte RjuEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual GlbTEntidad PReceptorEnt { get; set; } = null!;

    public virtual GlbTEntidadSucursal PReceptorEntSuc { get; set; } = null!;

    public virtual GlbTEntidad PRetenedorEnt { get; set; } = null!;

    public virtual ICollection<RhuTCtoRetJudPago> RhuTCtoRetJudPagos { get; } = new List<RhuTCtoRetJudPago>();
}
