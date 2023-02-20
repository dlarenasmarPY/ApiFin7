using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTMsgReclaAcepDte
{
    public decimal MsgReclaAcepDteid { get; set; }

    public string MetodoWs { get; set; } = null!;

    public string CodigoWs { get; set; } = null!;

    public string DescripcionWs { get; set; } = null!;

    public short AccionWs { get; set; }

    public string GlosaAccionWs { get; set; } = null!;

    public byte EstadoAcuse { get; set; }

    public byte EstadoReclamo { get; set; }
}
