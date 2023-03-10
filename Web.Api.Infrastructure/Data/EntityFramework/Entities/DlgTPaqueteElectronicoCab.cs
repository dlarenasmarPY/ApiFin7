using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTPaqueteElectronicoCab
{
    public decimal PqcElectronicoCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short PerId { get; set; }

    public byte PqcTipoPaquete { get; set; }

    public string PqcXmlPaquete { get; set; } = null!;

    public int PqcNumDlgPaquete { get; set; }

    public string PqcIdentificadorSii { get; set; } = null!;

    public string PqcErrorSii { get; set; } = null!;

    public string PqcGlosaErrorSii { get; set; } = null!;

    public byte PqcEstado { get; set; }

    public DateTime PqcFecFirma { get; set; }

    public decimal PEntIdFirma { get; set; }

    public DateTime PqcFecEnvio { get; set; }

    public string CodOwner { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
