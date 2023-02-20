using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalCabAtr
{
    public decimal PDoctoLegalCabId { get; set; }

    public decimal PEntId { get; set; }

    public string DlcPatente { get; set; } = null!;

    public string DlcRutConductor { get; set; } = null!;

    public string DlcIdentificacionConductor { get; set; } = null!;

    public string DlcDireccionDestino { get; set; } = null!;

    public int CmuCodigo { get; set; }

    public int CiuCodigo { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PEntReceptorId { get; set; }

    public decimal PEntDirId { get; set; }

    public string RutaTransporte { get; set; } = null!;

    public DateTime FecIniTransporte { get; set; }

    public DateTime FecFinTransporte { get; set; }

    public string DoctoAduanTransporte { get; set; } = null!;

    public string EstablDestinoTransporte { get; set; } = null!;

    public string MotivoTransporte { get; set; } = null!;

    public string CodContribuyente { get; set; } = null!;

    public string EntMail { get; set; } = null!;

    public short FormaPagoCodExt { get; set; }

    public decimal PEntDirOrigenId { get; set; }

    public decimal PRutaDespId { get; set; }
}
