using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTPlanCuenta
{
    public decimal PdcId { get; set; }

    public string PdcNomPlan { get; set; } = null!;

    public byte PdcCantidadNiveles { get; set; }

    public string PdcNomNivel1 { get; set; } = null!;

    public string PdcNomNivel2 { get; set; } = null!;

    public string PdcNomNivel3 { get; set; } = null!;

    public string PdcNomNivel4 { get; set; } = null!;

    public string PdcNomNivel5 { get; set; } = null!;

    public string PdcNomNivel6 { get; set; } = null!;

    public string PdcNomNivel7 { get; set; } = null!;

    public string PdcOwner { get; set; } = null!;

    public short PdcLargoNivel1 { get; set; }

    public short PdclargoNivel2 { get; set; }

    public short PdcLargoNivel3 { get; set; }

    public short PdcLargoNivel4 { get; set; }

    public short PdcLargoNivel5 { get; set; }

    public short PdcLargoNivel6 { get; set; }

    public short PdcLargoNivel7 { get; set; }

    public short PdcPlanComun { get; set; }

    public DateTime PdcFechaAsig { get; set; }

    public string PdcUserCode { get; set; } = null!;

    public byte EscenarioCod { get; set; }
}
