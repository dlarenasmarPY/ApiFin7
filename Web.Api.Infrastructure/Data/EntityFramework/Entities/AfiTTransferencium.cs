using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTTransferencium
{
    public decimal PCodigoBienId { get; set; }

    public decimal AfiDctoDigitacion { get; set; }

    public byte ConEstCod { get; set; }

    public short AfiUnidadRespOr { get; set; }

    public short AfiUnidadRespDest { get; set; }

    public int AfiUbiFisOr { get; set; }

    public int AfiUbiFisDest { get; set; }

    public short AfiSubgrOr { get; set; }

    public short AfiSubgrDest { get; set; }

    public decimal AfiRespOr { get; set; }

    public DateTime AfiFechaIngTransf { get; set; }

    public decimal AfiRespDest { get; set; }

    public string AfiDctoLegal { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte AfiTipoTransf { get; set; }

    public decimal PTprIdOr { get; set; }

    public decimal PTprIdDest { get; set; }

    public string PryNumeroOr { get; set; } = null!;

    public string PryNumeroDest { get; set; } = null!;

    public int CdiCodigoOr { get; set; }

    public int CdiCodigoDest { get; set; }

    public decimal PPartidaIdOr { get; set; }

    public decimal PPartidaIdDest { get; set; }
}
