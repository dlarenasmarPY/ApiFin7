using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTmpCotizacion
{
    public string Usuario { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PTprId { get; set; }

    public int Correlativo { get; set; }

    public string PryNumero { get; set; } = null!;

    public short AfluId { get; set; }

    public short ConveId { get; set; }

    public short ExpId { get; set; }

    public short TventaId { get; set; }

    public int VenId { get; set; }

    public short TcliId { get; set; }

    public decimal PCategoriaId { get; set; }

    public short ModoId { get; set; }

    public string EntRut { get; set; } = null!;

    public decimal PCotizacionId { get; set; }

    public string ObservacionInm { get; set; } = null!;
}
