using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTReglaNivelValidacion
{
    public decimal PTdoReferenciaSiiId { get; set; }

    public byte RrcIndNivVal { get; set; }

    public string RrcGlosaNivVal { get; set; } = null!;
}
