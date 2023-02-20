using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelParRequisito
{
    public short CodRequisito { get; set; }

    public string DescripcionRequisito { get; set; } = null!;

    public string NomTablaRequisito { get; set; } = null!;

    public string NomTablaRequisito2 { get; set; } = null!;

    public string NomAtributoRequisito { get; set; } = null!;

    public string NomAtributoRequisito2 { get; set; } = null!;

    public string? NomParametroTraduccion { get; set; }

    public string? NomAtributoTraduccion { get; set; }

    public string? DescripcionTraduccion { get; set; }

    public short CodCondicionInicial { get; set; }

    public string TipoDato { get; set; } = null!;

    public string IndCalculo { get; set; } = null!;

    public string IndRango { get; set; } = null!;

    public string IndEdad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
