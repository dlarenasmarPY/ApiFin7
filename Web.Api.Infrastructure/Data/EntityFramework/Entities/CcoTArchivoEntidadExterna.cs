using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTArchivoEntidadExterna
{
    public decimal PFrmCcoId { get; set; }

    public byte TipoRegistro { get; set; }

    public int Secuencia { get; set; }

    public byte Atributo { get; set; }

    public short PosicionInicial { get; set; }

    public int Largo { get; set; }

    public string IndAtributoControl { get; set; } = null!;

    public string IndComparacion { get; set; } = null!;

    public string IndConversion { get; set; } = null!;

    public string ValorPorOmision { get; set; } = null!;

    public decimal PFormatoId { get; set; }

    public string TipoDato { get; set; } = null!;
}
