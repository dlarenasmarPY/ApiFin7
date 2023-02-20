using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTRecepcionDetRefSiiResp
{
    public decimal PRecepcionBitId { get; set; }

    public decimal PEmpId { get; set; }

    public string RecDetRutEmisor { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public int DlcFolioDocto { get; set; }

    public string TipoDteSii { get; set; } = null!;

    public short TdoSii { get; set; }

    public DateTime RecFechaEmision { get; set; }

    public double RecMontoTotal { get; set; }

    public byte RecDetEstado { get; set; }

    public DateTime RecDetFechaRecepcion { get; set; }

    public string RecDetTrackId { get; set; } = null!;

    public decimal PRecepcionDetId { get; set; }

    public decimal PCabLlgId { get; set; }

    public string RecDetOwner { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
