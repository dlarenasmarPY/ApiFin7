using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalXml
{
    public decimal PDoctoLegalCabId { get; set; }

    public string DlcXmlSii { get; set; } = null!;

    public string DlcXmlCliente { get; set; } = null!;

    public decimal PPqcElectronicoCabAlSiiId { get; set; }

    public decimal PPqcElectronicoCabAlClienteId { get; set; }

    public DateTime DlcFecFirma { get; set; }

    public decimal PEntIdFirma { get; set; }

    public byte[]? DlcImagenTimbre { get; set; }

    public string DlcError { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public DateTime DlcFecRecepcionEnvio { get; set; }

    public DateTime DlcFecRecepcionResul { get; set; }

    public string DlcGloEstadoEnvioXml { get; set; } = null!;

    public byte DlcIndElectronico { get; set; }

    public byte DlcFormatoEnvioDte { get; set; }

    public string DlcMail { get; set; } = null!;

    public DateTime DlcFechaEnvioMail { get; set; }

    public string DlcXmlOriginal { get; set; } = null!;
}
