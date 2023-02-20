using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GesTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public decimal PPuntoReordenId { get; set; }

    public byte IndTipoReposicion { get; set; }

    public byte IndTipoTransito { get; set; }

    public short DiasxMes { get; set; }

    public short DiasColocaOc { get; set; }

    public short DiasRevisionNiveles { get; set; }

    public short PerCalConsumo { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
