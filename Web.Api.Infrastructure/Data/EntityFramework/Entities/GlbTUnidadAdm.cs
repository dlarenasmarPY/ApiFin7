using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTUnidadAdm
{
    public short UniCodigo { get; set; }

    public string UniNombre { get; set; } = null!;

    public byte UniTipo { get; set; }

    public virtual ICollection<CceTMovimiento> CceTMovimientos { get; } = new List<CceTMovimiento>();

    public virtual ICollection<ConTCabeceraCom> ConTCabeceraComs { get; } = new List<ConTCabeceraCom>();

    public virtual ICollection<ConTCabeceraOpe> ConTCabeceraOpes { get; } = new List<ConTCabeceraOpe>();

    public virtual ICollection<ConTMovimiento> ConTMovimientos { get; } = new List<ConTMovimiento>();

    public virtual ICollection<IsaTMovimiento> IsaTMovimientos { get; } = new List<IsaTMovimiento>();

    public virtual ICollection<TesTMovimiento> TesTMovimientos { get; } = new List<TesTMovimiento>();
}
