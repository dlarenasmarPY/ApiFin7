using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CbaTArchivoCartola
{
    public decimal PFrmCbaId { get; set; }

    public byte TipoRegistro { get; set; }

    public int Secuencia { get; set; }

    public byte Atributo { get; set; }

    public short PosicionInicial { get; set; }

    public int Largo { get; set; }

    public string IndAtributoControl { get; set; } = null!;

    public string IndComparacion { get; set; } = null!;

    public string ValorPorOmision { get; set; } = null!;

    public decimal PFormatoFechaId { get; set; }
}
