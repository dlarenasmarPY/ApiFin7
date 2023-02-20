using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTFleteProvDet
{
    public decimal FleteProvDetId { get; set; }

    public decimal PFleteProvCabId { get; set; }

    public decimal PBodegaId { get; set; }

    public byte IndTipoTarifa { get; set; }

    public double FleteCargoPorc { get; set; }

    public double FleteValorKilo { get; set; }

    public double FleteValorVol { get; set; }

    public double FleteValorMin { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ExiTBodega PBodega { get; set; } = null!;

    public virtual AdqTFleteProvCab PFleteProvCab { get; set; } = null!;
}
