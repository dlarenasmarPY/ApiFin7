using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRecepcionDocDet
{
    public decimal RecDocDetId { get; set; }

    public decimal PRecDocCabId { get; set; }

    public int? RecDocDetNumLinea { get; set; }

    public short? RecDocDetTipoDoc { get; set; }

    public string? RecDocDetNumeroDoc { get; set; }

    public DateTime? RecDocDetFechaVenc { get; set; }

    public decimal? PMonedaId { get; set; }

    public decimal? PDocCceId { get; set; }

    public decimal? PCtaId { get; set; }

    public short? MovCceNumCuota { get; set; }

    public int? CtaCodigo { get; set; }

    public string? RecDocDetRutAceptante { get; set; }

    public string? RecDocDetRazonSocial { get; set; }

    public string? RecDocDetDocRef { get; set; }

    public string? RecDocDetNumPagCedente { get; set; }

    public string? RecDocDetTipoMovEntExt { get; set; }

    public string? RecDocDetNumDocEntExt { get; set; }

    public DateTime? RecDocDetFecProrroga { get; set; }

    public double? RecDocDetMontoDocumento { get; set; }

    public double? RecDocDetMontoIngreso { get; set; }

    public double? RecDocDetMontoEgreso { get; set; }

    public double? RecDocDetMontoComision { get; set; }

    public double? RecDocDetMontoAnticipo { get; set; }

    public double? RecDocDetMontoGasto { get; set; }

    public double? RecDocDetMontoInteres { get; set; }

    public double? RecDocDetMontoProtesto { get; set; }

    public decimal? PCabNomExtId { get; set; }

    public decimal? PCabOpeId { get; set; }

    public byte? RecDocDetError { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
