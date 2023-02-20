using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ObrTEmpresaUsuario
{
    public int EmpId { get; set; }

    public string IdUsuario { get; set; } = null!;
}
