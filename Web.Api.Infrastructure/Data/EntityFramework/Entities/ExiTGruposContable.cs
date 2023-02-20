using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTGruposContable
{
    public decimal GrupoContId { get; set; }

    public string GrupoContCod { get; set; } = null!;

    public string GrupoContDes { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndProductoServicio { get; set; }

    public virtual ICollection<ExiTGruposContablesCuenta> ExiTGruposContablesCuenta { get; } = new List<ExiTGruposContablesCuenta>();

    public virtual ICollection<ExiTGruposContablesTipoOpe> ExiTGruposContablesTipoOpes { get; } = new List<ExiTGruposContablesTipoOpe>();

    public virtual ICollection<ExiTProductosCategoria> ExiTProductosCategoria { get; } = new List<ExiTProductosCategoria>();
}
