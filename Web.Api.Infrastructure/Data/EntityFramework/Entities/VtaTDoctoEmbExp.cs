using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDoctoEmbExp
{
    public decimal EmbId { get; set; }

    public string NroReserva { get; set; } = null!;

    public decimal PDoctoVentaCabId { get; set; }

    public byte TipoTranspCod { get; set; }

    public decimal PCodigoCiaId { get; set; }

    public decimal PCodigoCiaSucId { get; set; }

    public string Nave { get; set; } = null!;

    public DateTime FechaDespacho { get; set; }

    public decimal PPuertoOrigen { get; set; }

    public decimal PPuertoDestino { get; set; }

    public string Observaciones { get; set; } = null!;

    public string EntregaTransp { get; set; } = null!;

    public string EntregaCliente { get; set; } = null!;

    public decimal PAgenteAduanaId { get; set; }

    public decimal PAgenteAduanaSucId { get; set; }

    public string ConocimientoEmb { get; set; } = null!;

    public DateTime FechaEmbarque { get; set; }

    public byte TipoPago { get; set; }

    public double Monto { get; set; }

    public decimal PMonedaId { get; set; }

    public byte TipoParidad { get; set; }

    public decimal TipoCambioPar { get; set; }

    public DateTime FechaParidad { get; set; }

    public byte TipoPagoSeg { get; set; }

    public double MontoSeg { get; set; }

    public decimal PMonedaIdSeg { get; set; }

    public byte TipoParidadSeg { get; set; }

    public decimal TipoCambioParSeg { get; set; }

    public DateTime FechaParidadSeg { get; set; }

    public string DescFactura { get; set; } = null!;

    public string ObsInstructivo { get; set; } = null!;

    public byte Bloqueo { get; set; }

    public DateTime FechaStacking { get; set; }

    public DateTime FechaEntregaTras { get; set; }

    public DateTime FechaEntregaCli { get; set; }

    public DateTime FechaReserva { get; set; }

    public string EspacioRes { get; set; } = null!;
}
