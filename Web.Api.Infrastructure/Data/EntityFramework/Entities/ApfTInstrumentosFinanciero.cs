using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTInstrumentosFinanciero
{
    public decimal InstrumentoId { get; set; }

    public short TfmCodigo { get; set; }

    public short CodigoInstrumento { get; set; }

    public string NombreInstrumento { get; set; } = null!;

    public string DescripcionInstrumento { get; set; } = null!;

    public decimal PEntId { get; set; }

    public decimal PMonedaId { get; set; }

    public string PlazoInstrumento { get; set; } = null!;

    public bool FlagRenovable { get; set; }

    public int RemuneracionInstrumento { get; set; }

    public double ComisionEntrada { get; set; }

    public double ComisionSalida { get; set; }

    public double MontoMinimoInv { get; set; }

    public double MontoMaximoInv { get; set; }

    public int PorcDistribCartRf { get; set; }

    public int PorcDistribCartRv { get; set; }

    public decimal PMonedaCuotaId { get; set; }
}
