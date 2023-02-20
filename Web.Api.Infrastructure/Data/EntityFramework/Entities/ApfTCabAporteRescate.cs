using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTCabAporteRescate
{
    public decimal CabActivoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PInstrumentoId { get; set; }

    public short PerId { get; set; }

    public byte EstCodigo { get; set; }

    public DateTime FechaInversion { get; set; }

    public byte TipoMovimiento { get; set; }

    public byte TipoRescate { get; set; }

    public string ActDigUsuario { get; set; } = null!;

    public string ActAprUsuario { get; set; } = null!;

    public DateTime FechaParidad { get; set; }

    public double TipoCambio { get; set; }

    public double MontoInversion { get; set; }

    public double MontoLocal { get; set; }

    public double ValorCuota { get; set; }

    public short CantidadCuotas { get; set; }

    public string ActGlosa { get; set; } = null!;

    public double ComisionEntrada { get; set; }

    public double ComisionSalida { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PCabOpeId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PMovCceId { get; set; }
}
