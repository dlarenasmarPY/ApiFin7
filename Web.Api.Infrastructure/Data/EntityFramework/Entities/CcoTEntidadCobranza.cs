using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTEntidadCobranza
{
    public decimal EntCcoId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public byte IndFactoring { get; set; }

    public string EntCcoTituloNomina { get; set; } = null!;

    public byte RepNomCod { get; set; }
}
