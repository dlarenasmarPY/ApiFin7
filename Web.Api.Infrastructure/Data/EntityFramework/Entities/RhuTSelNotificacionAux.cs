using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelNotificacionAux
{
    public string SelOwner { get; set; } = null!;

    public decimal PidPostulante { get; set; }

    public string GlosaObservacion { get; set; } = null!;
}
