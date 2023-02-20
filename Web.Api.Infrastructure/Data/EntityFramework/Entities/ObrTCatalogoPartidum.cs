using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ObrTCatalogoPartidum
{
    public decimal PartidaCatalogoId { get; set; }

    public string GlosaPartida { get; set; } = null!;

    public string CodigoUnidadMedida { get; set; } = null!;

    public string IndTipoCostoPartida { get; set; } = null!;

    public int EmpId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string CodigoExternoPartida { get; set; } = null!;
}
