using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTArbolProyectoAux
{
    public decimal PTprId { get; set; }

    public short NodoId { get; set; }

    public string DescripcionNodo { get; set; } = null!;

    public byte NivelNodo { get; set; }

    public short NumeroOrden { get; set; }

    public int RamalNodo { get; set; }

    public short NumeroRepeticion { get; set; }

    public bool IndHojas { get; set; }

    public int HijoId { get; set; }

    public string NodoExternoId { get; set; } = null!;

    public string Precedencia { get; set; } = null!;

    public byte TipoDuracion { get; set; }

    public double Duracion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
