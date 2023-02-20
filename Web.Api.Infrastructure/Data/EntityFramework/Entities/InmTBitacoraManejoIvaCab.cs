using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTBitacoraManejoIvaCab
{
    public decimal BitacoraId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public int NroBitacora { get; set; }

    public DateTime FechaVigencia { get; set; }

    public double M2totTerreno { get; set; }

    public int TipoAvaluo { get; set; }

    public double AvaluoTerreno { get; set; }

    public double M2legales { get; set; }

    public double M2terrenoAva { get; set; }

    public double ImpuestoIva { get; set; }

    public int TipoMod { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaProceso { get; set; }
}
