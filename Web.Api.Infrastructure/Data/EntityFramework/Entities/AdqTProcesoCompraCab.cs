using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTProcesoCompraCab
{
    public decimal ProCompraCabId { get; set; }

    public decimal PPedidoMaterialId { get; set; }

    public decimal PRubroId { get; set; }

    public int NumeroReferencia { get; set; }

    public byte IndEmpCentraliza { get; set; }

    public byte ConEstCod { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PRolUsuarioId { get; set; }

    public virtual ICollection<AdqTProcesoCompraDet> AdqTProcesoCompraDets { get; } = new List<AdqTProcesoCompraDet>();
}
