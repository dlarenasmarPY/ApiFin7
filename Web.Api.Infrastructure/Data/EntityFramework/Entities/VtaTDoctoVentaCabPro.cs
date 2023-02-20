using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDoctoVentaCabPro
{
    public decimal DoctoVentaCabProId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public DateTime DvpFecProyectada { get; set; }

    public double DvpPorcProyectado { get; set; }

    public double DvpMtoProyectado { get; set; }

    public byte DvdIndAfectoExento { get; set; }

    public byte DvdIndRetencion { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string DvpObservacion { get; set; } = null!;

    public byte TseCodigo { get; set; }

    public byte ConEstCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
