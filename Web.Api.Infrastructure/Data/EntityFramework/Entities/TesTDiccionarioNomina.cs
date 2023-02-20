using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTDiccionarioNomina
{
    public byte Atributo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string TipoDato { get; set; } = null!;

    public string IndFecha { get; set; } = null!;

    public string TablaTraduccion { get; set; } = null!;

    public string AtributoTraduccion { get; set; } = null!;

    public string IndSigno { get; set; } = null!;

    public string IndEntero { get; set; } = null!;

    public string IndDecimal { get; set; } = null!;

    public string IndTraduccion { get; set; } = null!;

    public string TablaDestino { get; set; } = null!;

    public string AtributoDestino { get; set; } = null!;

    public string AtributoOrigen { get; set; } = null!;
}
