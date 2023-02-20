using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosLinea
{
    public decimal LineaProdId { get; set; }

    public string LineaProdCod { get; set; } = null!;

    public string LineaProdDes { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<ExiTProductosCategoria> ExiTProductosCategoria { get; } = new List<ExiTProductosCategoria>();
}
