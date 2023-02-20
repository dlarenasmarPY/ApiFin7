using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTClaseDocumento
{
    public decimal ClaseImpId { get; set; }

    public string ClaseImpDes { get; set; } = null!;

    public decimal PTipoConceptoImpId { get; set; }
}
