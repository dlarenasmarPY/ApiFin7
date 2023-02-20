using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTProyectoEtapa
{
    public decimal PTprId { get; set; }

    public short NodoId { get; set; }

    public decimal PCreId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaTermino { get; set; }

    public DateTime FechaEntregaEtapa { get; set; }

    public DateTime FechaVentaEtapa { get; set; }

    public int InstCod { get; set; }

    public double PorcDesctoIni { get; set; }

    public double PorcDesctoFin { get; set; }

    public double MontoReserva { get; set; }
}
