using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTConfiguracion
{
    public decimal PEmpId { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public decimal PMonedaIdCfg { get; set; }

    public byte AfiIndContabiliza { get; set; }

    public double AfiMtoMaximo { get; set; }

    public double AfiMtoTopeUtmCrFiscal { get; set; }

    public double AfiPorcentajeCrFiscal { get; set; }

    public decimal PCtaIdCrFiscal { get; set; }

    public decimal PCreId { get; set; }

    public decimal PMonedaIdUtm { get; set; }

    public byte AfiIndCodigoBien { get; set; }

    public decimal PPcrId { get; set; }

    public byte ClaCreNodoNivel { get; set; }

    public byte AfiUgeUsaDivCodigo { get; set; }

    public decimal PTipoOpeId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
