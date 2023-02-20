using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalCabRef
{
    public decimal PDoctoLegalCabId { get; set; }

    public string DlcTipoDocRef { get; set; } = null!;

    public string DlcFolioDocRef { get; set; } = null!;

    public DateTime DlcFecDocRef { get; set; }

    public byte DlcCodDocRef { get; set; }

    public string DlcGlosaDocRef { get; set; } = null!;

    public string DlcRutOtroContrib { get; set; } = null!;

    public string DlcRazonSocialOtroContrib { get; set; } = null!;

    public byte DlcUsaImpresion { get; set; }

    public byte ConEstCod { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
