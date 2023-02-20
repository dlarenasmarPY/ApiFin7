using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuRecurso
{
    public string IdRecurso { get; set; } = null!;

    public string? Tipo { get; set; }

    public string? Recurso { get; set; }

    public virtual ICollection<UsuFuncionalidade> IdFuncionalidads { get; } = new List<UsuFuncionalidade>();
}
