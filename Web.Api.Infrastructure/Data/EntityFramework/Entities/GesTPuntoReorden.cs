using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GesTPuntoReorden
{
    public decimal PuntoReordenId { get; set; }

    public byte PuntoReordenCod { get; set; }

    public string PuntoReordenDes { get; set; } = null!;
}
