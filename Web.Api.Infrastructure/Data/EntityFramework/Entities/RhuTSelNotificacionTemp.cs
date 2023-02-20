using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelNotificacionTemp
{
    public decimal IdNotificacion { get; set; }

    public string IdUsuario { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PidPostulante { get; set; }
}
