using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemNominasConcDet
{
    public string CodOwner { get; set; } = null!;

    public decimal NomConcDetId { get; set; }

    public decimal PNomConcId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PConcRemId { get; set; }

    public byte NcnDindValorInf { get; set; }

    public decimal NcnDmdaId { get; set; }

    public double NcnDvalNumerico { get; set; }

    public string NcnDvalAlfNum { get; set; } = null!;

    public DateTime NcnDvalFecha { get; set; }

    public short NcnDvalHora { get; set; }

    public decimal NcnDvalBaseNum { get; set; }

    public string NcnDvalBaseAlf { get; set; } = null!;

    public short NcnDperIdIniDev { get; set; }

    public short NcnDperIdTerDev { get; set; }

    public decimal? NcnDrefOrigen { get; set; }

    public decimal NcnDpCreId { get; set; }

    public decimal NcnDtprId { get; set; }

    public decimal NcnDpryId { get; set; }

    public string NcnDestadoProc { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
