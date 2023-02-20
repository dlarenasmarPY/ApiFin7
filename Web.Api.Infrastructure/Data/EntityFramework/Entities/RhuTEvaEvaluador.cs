using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaEvaluador
{
    public decimal PFicPerId { get; set; }

    public string IndSupervisor { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;
}
