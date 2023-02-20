using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTFleteProvCab
{
    public decimal FleteProvCabId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public byte IndTipoTarifa { get; set; }

    public double FleteCargoPorc { get; set; }

    public double FleteValorKilo { get; set; }

    public double FleteValorVol { get; set; }

    public double FleteValorMin { get; set; }

    public decimal PMonedaId { get; set; }

    public byte IndTarifaBod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<AdqTFleteProvDet> AdqTFleteProvDets { get; } = new List<AdqTFleteProvDet>();

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual GlbTEntidadSucursal PEntSuc { get; set; } = null!;
}
