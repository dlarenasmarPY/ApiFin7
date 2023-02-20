using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTIntegracion
{
    public decimal PTprId { get; set; }

    public short NodoId { get; set; }

    public string NodoExternoId { get; set; } = null!;

    public short NumeroOrden { get; set; }

    public byte NivelNodo { get; set; }

    public int HijoId { get; set; }

    public int RamalNodo { get; set; }
}
