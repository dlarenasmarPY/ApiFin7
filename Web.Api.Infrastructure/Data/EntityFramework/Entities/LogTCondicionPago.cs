using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTCondicionPago
{
    public decimal CondPagoId { get; set; }

    public int CondPagoCod { get; set; }

    public string CondPagoDes { get; set; } = null!;

    public decimal PFormaPagoId { get; set; }

    public double CdpPorcRecargo { get; set; }

    public double CdpPorcDescto { get; set; }

    public short CdpCantDocto { get; set; }

    public short DiasPrimerVto { get; set; }

    public short DiasEntreVto { get; set; }

    public short CdpPrioridad { get; set; }

    public byte CdpRevisaCredito { get; set; }

    public double MontoAsegurado { get; set; }

    public decimal PMonedaId { get; set; }

    public byte CdpUsaInteresImp { get; set; }

    public byte CdpUsaCuadroPago { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
