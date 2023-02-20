using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTPaqueteElectronicoDet
{
    public decimal PqdElectronicoDetId { get; set; }

    public decimal PPqcElectronicoCabId { get; set; }

    public short TdoSii { get; set; }

    public int PqdNumDlgInformado { get; set; }

    public int PqdNumDlgAceptado { get; set; }

    public int PqdNumDlgRechazado { get; set; }

    public int PqdNumDlgConReparo { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
