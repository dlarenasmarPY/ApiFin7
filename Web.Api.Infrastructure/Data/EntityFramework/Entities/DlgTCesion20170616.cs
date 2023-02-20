using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTCesion20170616
{
    public decimal CesionId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public int CesNumdocto { get; set; }

    public DateTime CesFecha { get; set; }

    public byte CesEstado { get; set; }

    public DateTime CesFecFirma { get; set; }

    public decimal PEntIdFirma { get; set; }

    public string CesXml { get; set; } = null!;

    public decimal PEntIdCesionario { get; set; }

    public decimal PEntSucIdCesionario { get; set; }

    public double CesMonto { get; set; }

    public string CesOtrasCondiciones { get; set; } = null!;

    public string CesMailDeudor { get; set; } = null!;

    public string CesMailCesionario { get; set; } = null!;

    public DateTime CesFechaDespacho { get; set; }

    public byte CesIndDeclaracionJurada { get; set; }

    public DateTime CesFechaEnvioSii { get; set; }

    public string CesTrackId { get; set; } = null!;

    public string CesError { get; set; } = null!;

    public byte CesStatusSii { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string CodOwner { get; set; } = null!;
}
