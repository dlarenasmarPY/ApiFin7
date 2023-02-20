using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParVigInstituc
{
    public decimal VinId { get; set; }

    public decimal PInsParId { get; set; }

    public DateTime VinFecVigencia { get; set; }

    public double VinTasaImposicionCja { get; set; }

    public short VinCodExCajaCja { get; set; }

    public short VinCodRegimenAntCja { get; set; }

    public decimal VinComisionFijaAfp { get; set; }

    public double VinComisionSegAfp { get; set; }

    public double VinComisionSegSis { get; set; }

    public double VinComisionMayorAfp { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParInstitucione PInsPar { get; set; } = null!;
}
