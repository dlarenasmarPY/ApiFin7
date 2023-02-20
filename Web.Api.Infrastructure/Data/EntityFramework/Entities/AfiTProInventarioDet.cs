using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTProInventarioDet
{
    public decimal ProInvDetId { get; set; }

    public decimal PProInvCabId { get; set; }

    public int AfiFolioHojaInv { get; set; }

    public int AfiLineaHojaInv { get; set; }

    public decimal PCodigoBienId { get; set; }

    public DateTime AfiFechaProceso { get; set; }

    public double AfiCant1erRecInv { get; set; }

    public DateTime AfiFec1erRecInv { get; set; }

    public string UserResp1erRecInv { get; set; } = null!;

    public double AfiCant2doRecInv { get; set; }

    public DateTime AfiFec2doRecInv { get; set; }

    public string UserResp2doRecInv { get; set; } = null!;

    public double AfiCantConfirmada { get; set; }

    public DateTime AfiFecDetPrInv { get; set; }

    public string UserRespDetPrInv { get; set; } = null!;

    public double AfiCantidadAjuste { get; set; }

    public string AfiOwnerHojaInv { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public DateTime AfiFecEstDetPrInv { get; set; }

    public string AfiCodSerie { get; set; } = null!;

    public byte AfiTipoRegistro { get; set; }

    public byte AfiEstComparacion { get; set; }

    public string NombreArchivoCarga { get; set; } = null!;

    public int Linea { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
