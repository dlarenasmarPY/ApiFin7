using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTBitacoraDocumento
{
    public decimal BitacoraDocumentoId { get; set; }

    public short BidOrigenDato { get; set; }

    public byte BidTipoAccion { get; set; }

    public decimal PDocReferenciaId { get; set; }

    public string BidDatoAntiguo { get; set; } = null!;

    public string BidDatoNuevo { get; set; } = null!;

    public string BidGlosa { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public decimal PEmpId { get; set; }
}
