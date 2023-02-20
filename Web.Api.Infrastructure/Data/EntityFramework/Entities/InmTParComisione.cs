using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTParComisione
{
    public decimal CargoId { get; set; }

    public decimal PEmpId { get; set; }

    public string Descripcion { get; set; } = null!;

    public byte Indicador { get; set; }
}
