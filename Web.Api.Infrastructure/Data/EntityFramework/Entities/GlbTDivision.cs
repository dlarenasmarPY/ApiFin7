using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTDivision
{
    public short DivCodigo { get; set; }

    public string DivGlosa { get; set; } = null!;

    public virtual ICollection<AdqTOcCab> AdqTOcCabs { get; } = new List<AdqTOcCab>();

    public virtual ICollection<CceTDocumento> CceTDocumentos { get; } = new List<CceTDocumento>();

    public virtual ICollection<CceTMovimiento> CceTMovimientos { get; } = new List<CceTMovimiento>();

    public virtual ICollection<ConTCabeceraCom> ConTCabeceraComs { get; } = new List<ConTCabeceraCom>();

    public virtual ICollection<ConTCabeceraOpe> ConTCabeceraOpes { get; } = new List<ConTCabeceraOpe>();

    public virtual ICollection<ConTMovimiento> ConTMovimientos { get; } = new List<ConTMovimiento>();

    public virtual ICollection<IsaTMovimiento> IsaTMovimientos { get; } = new List<IsaTMovimiento>();

    public virtual ICollection<LogTOperacionesLogtCab> LogTOperacionesLogtCabs { get; } = new List<LogTOperacionesLogtCab>();

    public virtual ICollection<LogTPedidoMaterialCab> LogTPedidoMaterialCabs { get; } = new List<LogTPedidoMaterialCab>();

    public virtual ICollection<TesTMovimiento> TesTMovimientos { get; } = new List<TesTMovimiento>();
}
