using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTDiccionarioArchivo
{
    public byte Atributo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string TipoDato { get; set; } = null!;

    public string IndFormato { get; set; } = null!;

    public string IndSigno { get; set; } = null!;

    public string IndEntero { get; set; } = null!;

    public string IndDecimal { get; set; } = null!;

    public string IndTraduccion { get; set; } = null!;

    public string TablaTraduccion { get; set; } = null!;

    public string AtributoTraduccion { get; set; } = null!;

    public string TablaTraduccionSalida { get; set; } = null!;

    public string AtributoTraduccionSalida { get; set; } = null!;

    public string TablaDestino { get; set; } = null!;

    public string AtributoDestino { get; set; } = null!;

    public string AtributoOrigen { get; set; } = null!;

    public string AtributoOrigenSalida { get; set; } = null!;

    public string AtributoDestinoSalida { get; set; } = null!;

    public byte TipoRegistro { get; set; }
}
