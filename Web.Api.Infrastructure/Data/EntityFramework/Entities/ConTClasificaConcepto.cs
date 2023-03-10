using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTClasificaConcepto
{
    public decimal PPdcId { get; set; }

    public short ClaCtaNivel1 { get; set; }

    public short ClaCtaNivel2 { get; set; }

    public short ClaCtaNivel3 { get; set; }

    public short ClaCtaNivel4 { get; set; }

    public short ClaCtaNivel5 { get; set; }

    public short ClaCtaNivel6 { get; set; }

    public short ClaCtaNivel7 { get; set; }

    public decimal PCdiId { get; set; }

    public byte ClaCtaNodoNivel { get; set; }

    public string ClaCtaNodoNombre { get; set; } = null!;

    public int ClaCtaNodoCodigoAlt { get; set; }

    public decimal ClaIdentity { get; set; }
}
