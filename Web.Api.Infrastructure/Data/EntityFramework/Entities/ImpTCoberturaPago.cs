using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTCoberturaPago
{
    public decimal CoberturaPagoId { get; set; }

    public decimal PCoberturaDetId { get; set; }

    public int InstCod { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public double TasaCambioAcuerdo { get; set; }

    public byte CargoCtaCte { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
