using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTTipoOperacionDet
{
    public decimal TipoOpeDetId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public short ClcId { get; set; }

    public decimal PCtaId { get; set; }

    public string OpeDetDescripcion { get; set; } = null!;

    public int OpeDetDebe { get; set; }

    public int OpeDetHaber { get; set; }

    public byte OpeDetFlagDesglose { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double OpeDetDebeFloat { get; set; }

    public double OpeDetHaberFloat { get; set; }
}
