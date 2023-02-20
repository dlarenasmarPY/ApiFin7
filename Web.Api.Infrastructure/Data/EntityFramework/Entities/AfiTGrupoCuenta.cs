using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTGrupoCuenta
{
    public decimal PEmpId { get; set; }

    public short AfiGrupoCod { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public byte AfiFormulaCod { get; set; }

    public decimal PCtaIdAct { get; set; }

    public decimal PCtaIdCm { get; set; }

    public decimal PCtaIdDact { get; set; }

    public decimal PCtaIdDacum { get; set; }

    public decimal PCtaIdDeje { get; set; }

    public decimal PCtaIdRet { get; set; }

    public decimal PCtaIdPerdida { get; set; }

    public decimal PCtaIdGanancia { get; set; }

    public decimal PCtaIdBienAdm { get; set; }

    public decimal AfiCtaResultadoDet { get; set; }

    public decimal AfiCtaProvAcumDet { get; set; }

    public byte AfiTipoGrupo { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
