using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTClienteCredito
{
    public decimal PEntId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PCondPagoId { get; set; }

    public string CliIndCredito { get; set; } = null!;

    public double CliMtoLineaCredito { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime Fecha { get; set; }

    public byte VisaObligatoria { get; set; }

    public byte MotivoVisa { get; set; }

    public string GlosaVisa { get; set; } = null!;

    public byte BloqueaDespacho { get; set; }

    public string GlosaBloqueo { get; set; } = null!;

    public byte MotivoBloqueo { get; set; }

    public decimal PMonedaPatrimId { get; set; }

    public DateTime FechaDate { get; set; }

    public double MtoPatrimonio { get; set; }

    public byte ClienteVip { get; set; }

    public byte ClasificaCreditoCli { get; set; }

    public byte EximeVisa { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string CcoIntCobrador { get; set; } = null!;
}
