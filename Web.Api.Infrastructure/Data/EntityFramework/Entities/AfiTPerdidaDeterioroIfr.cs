using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTPerdidaDeterioroIfr
{
    public decimal PerdidaDeterioroId { get; set; }

    public decimal PDeterioroIfrsId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public decimal PCreId { get; set; }

    public double AfiPorcentajeResp { get; set; }

    public double AfiMontoDeterioro { get; set; }

    public double AfiMontoReversion { get; set; }

    public double AfiProvisionAcum { get; set; }

    public double AfiPtjeDet { get; set; }

    public double AfiValorNeto { get; set; }

    public double AfiDeterioroAcum { get; set; }

    public double AfiValorNetoConDeter { get; set; }

    public double AfiValorNetoTotal { get; set; }

    public DateTime AfiFechaIngreso { get; set; }

    public string AfiUserIngreso { get; set; } = null!;

    public DateTime AfiFechaAprob { get; set; }

    public string AfiUserAprob { get; set; } = null!;

    public byte AfiEstado { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public decimal PCabOpeId { get; set; }

    public DateTime CabOpeFechaRev { get; set; }

    public decimal PCabOpeIdRev { get; set; }

    public byte AfiContabiliza { get; set; }

    public double AfiDepAcumEje { get; set; }

    public double AfiDepPeriodo { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
