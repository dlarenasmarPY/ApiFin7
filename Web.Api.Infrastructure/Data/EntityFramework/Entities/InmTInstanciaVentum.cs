using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTInstanciaVentum
{
    public short TventaId { get; set; }

    public byte InstPvtaId { get; set; }

    public int Secuencia { get; set; }

    public byte DocEstado { get; set; }

    public short DiasHito { get; set; }

    public virtual InmTInstancia InstPvta { get; set; } = null!;

    public virtual InmTTipoVentum Tventa { get; set; } = null!;
}
