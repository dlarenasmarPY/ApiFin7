using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTDetAporteRescate
{
    public decimal DetActivoId { get; set; }

    public int Linea { get; set; }

    public decimal PCabActivoId { get; set; }

    public byte TmrCodigo { get; set; }

    public short TfpCodigo { get; set; }

    public DateTime FechaParidad { get; set; }

    public int InstCod { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public int NumChequera { get; set; }

    public string MovTesNumero { get; set; } = null!;

    public decimal PInstrumentoId { get; set; }

    public double TipoCambio { get; set; }

    public double MontoInversion { get; set; }

    public double MontoLocal { get; set; }

    public double ValorCuota { get; set; }

    public short CantidadCuotas { get; set; }

    public double ComisionEntrada { get; set; }

    public string TasaPiso { get; set; } = null!;

    public DateTime FechaVenc { get; set; }

    public string ActGlosa { get; set; } = null!;

    public decimal PCabAporteRescateId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
