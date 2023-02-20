using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTMarcaEmpresa
{
    public decimal MarcaEmpresaId { get; set; }

    public decimal PMarcaId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PCreId { get; set; }
}
