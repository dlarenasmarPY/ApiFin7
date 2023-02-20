using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTTipoOperacione
{
    public decimal TipoOpeId { get; set; }

    public string TipoOpeDes { get; set; } = null!;

    public decimal PTipoOpeContId { get; set; }

    public short ProNegocioCod { get; set; }

    public byte AfectaExistencias { get; set; }

    public byte EntradaSalida { get; set; }

    public byte AfectaCantidad { get; set; }

    public byte AfectaValor { get; set; }

    public byte AfectaCm { get; set; }

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public byte UnicaImpContable { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte AfectaConsignacion { get; set; }

    public byte AfectaContabilidad { get; set; }

    public virtual ICollection<AdqTOcCab> AdqTOcCabs { get; } = new List<AdqTOcCab>();

    public virtual ICollection<LogTPedidoMaterialCab> LogTPedidoMaterialCabs { get; } = new List<LogTPedidoMaterialCab>();

    public virtual ICollection<LogTTipoOpeEntidad> LogTTipoOpeEntidads { get; } = new List<LogTTipoOpeEntidad>();

    public virtual ICollection<LogTUsuarioTipoOpe> LogTUsuarioTipoOpes { get; } = new List<LogTUsuarioTipoOpe>();
}
