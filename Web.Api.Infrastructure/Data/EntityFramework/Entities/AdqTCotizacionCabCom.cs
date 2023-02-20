using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCotizacionCabCom
{
    public decimal CotizCabComId { get; set; }

    public decimal PCotizCabId { get; set; }

    public decimal PListaPreCabId { get; set; }

    public byte IndModificaPrecio { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCondPagoId { get; set; }

    public short PlazoNormalPago { get; set; }

    public double DesctoPorc1 { get; set; }

    public double DesctoPorc2 { get; set; }

    public double DesctoPorc3 { get; set; }

    public double DesctoPorc4 { get; set; }

    public double TotalDesctoPorc { get; set; }

    public short PlazoPrePago { get; set; }

    public double DesctoPorcPrepago { get; set; }

    public decimal PClausulaId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual AdqTCotizacionCab PCotizCab { get; set; } = null!;

    public virtual GlbTMoneda PMoneda { get; set; } = null!;
}
