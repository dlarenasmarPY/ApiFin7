﻿using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuFuncionalidade
{
    public string IdFuncionalidad { get; set; } = null!;

    public string IdProcesoNegocio { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? EstadoReg { get; set; }

    public DateTime? FecEstadoReg { get; set; }

    public DateTime? FecIngReg { get; set; }

    public string? IdUsuarioIngReg { get; set; }

    public DateTime? FecUltModifReg { get; set; }

    public string? IdUsuarioUltModifReg { get; set; }

    public string? IdFuncionUltModifReg { get; set; }

    public virtual ICollection<UsuRecurso> IdRecursos { get; } = new List<UsuRecurso>();
}