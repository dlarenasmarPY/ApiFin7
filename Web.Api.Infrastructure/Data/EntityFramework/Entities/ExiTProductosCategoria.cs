using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosCategoria
{
    public decimal CategoriaId { get; set; }

    public string CategoriaCod { get; set; } = null!;

    public string CategoriaDes { get; set; } = null!;

    public decimal PLineaProdId { get; set; }

    public decimal PGrupoContId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndProductoGenerico { get; set; }

    public virtual ICollection<AdqTRubrosCategoria> AdqTRubrosCategoria { get; } = new List<AdqTRubrosCategoria>();

    public virtual ICollection<ExiTServicio> ExiTServicios { get; } = new List<ExiTServicio>();

    public virtual ICollection<LogTPedidoMaterialDet> LogTPedidoMaterialDets { get; } = new List<LogTPedidoMaterialDet>();

    public virtual ExiTGruposContable PGrupoCont { get; set; } = null!;

    public virtual ExiTProductosLinea PLineaProd { get; set; } = null!;
}
