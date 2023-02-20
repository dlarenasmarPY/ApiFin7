using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTVendedor
{
    public decimal VendedorId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PEntId { get; set; }

    public byte TreCodigo { get; set; }

    public string IdUsuario { get; set; } = null!;

    public decimal PCreId { get; set; }

    public byte VenIndDescto { get; set; }

    public byte VenIndPrecio { get; set; }

    public byte VenIndFirma { get; set; }

    public byte VenIndEnvia { get; set; }

    public byte VenIndAnula { get; set; }

    public byte VenIndAdministrador { get; set; }

    public string VenRazonSocialCert { get; set; } = null!;

    public DateTime VenFecCertVigencia { get; set; }

    public string VenToken { get; set; } = null!;

    public DateTime VenFecToken { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
