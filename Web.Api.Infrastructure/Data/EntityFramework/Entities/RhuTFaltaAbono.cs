using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFaltaAbono
{
    public string Rut { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal PFlegBitId { get; set; }
}
