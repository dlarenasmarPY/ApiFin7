using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTClasificaProyecto
{
    public decimal PPdcId { get; set; }

    public short ClaCtaNivel1 { get; set; }

    public short ClaCtaNivel2 { get; set; }

    public short ClaCtaNivel3 { get; set; }

    public short ClaCtaNivel4 { get; set; }

    public short ClaCtaNivel5 { get; set; }

    public short ClaCtaNivel6 { get; set; }

    public short ClaCtaNivel7 { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte ClaCtaNodoNivel { get; set; }

    public string ClaCtaNodoNombre { get; set; } = null!;

    public int ClaCtaNodoCodigoAlt { get; set; }

    public decimal ClaIdentity { get; set; }

    public int ProyIdentity { get; set; }

    public string DescripcionAltA { get; set; } = null!;

    public string DescripcionAltb { get; set; } = null!;

    public int NPryIdentity { get; set; }
}
