using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTLibro20161207
{
    public decimal LibId { get; set; }

    public decimal PEmpId { get; set; }

    public short PerId { get; set; }

    public short TipoLibroId { get; set; }

    public short TipoEnvioId { get; set; }

    public decimal LibFolioNotificacion { get; set; }

    public string LibCodAutorizacionRec { get; set; } = null!;

    public int LibNumero { get; set; }

    public byte LibEstado { get; set; }

    public string LibError { get; set; } = null!;

    public byte LibIndMensualEspecial { get; set; }

    public string LibTrackId { get; set; } = null!;

    public string LibXml { get; set; } = null!;

    public string LibXmlImpresion { get; set; } = null!;

    public decimal PEntIdFirma { get; set; }

    public DateTime LibFecFirma { get; set; }

    public DateTime LibFecEnvia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndMoneda { get; set; }

    public decimal PMonedaId { get; set; }
}
