using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTServicio
{
    public decimal ServicioId { get; set; }

    public string ServicioDes { get; set; } = null!;

    public decimal PCategoriaId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte NoVendible { get; set; }

    public string ServicioCod { get; set; } = null!;

    public byte SerIndProvee { get; set; }

    public byte TseCodigo { get; set; }

    public byte SerIndDespachable { get; set; }

    public byte SerCobroFlete { get; set; }

    public byte Interno { get; set; }

    public byte SerUsaVentaTercero { get; set; }

    public virtual ExiTProductosCategoria PCategoria { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMed { get; set; } = null!;
}
