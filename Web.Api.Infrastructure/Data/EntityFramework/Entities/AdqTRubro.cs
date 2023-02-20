using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTRubro
{
    public decimal RubroId { get; set; }

    public int RubroCod { get; set; }

    public string RubroDes { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<AdqTRubrosCategoria> AdqTRubrosCategoria { get; } = new List<AdqTRubrosCategoria>();

    public virtual ICollection<AdqTRubrosEntidade> AdqTRubrosEntidades { get; } = new List<AdqTRubrosEntidade>();
}
