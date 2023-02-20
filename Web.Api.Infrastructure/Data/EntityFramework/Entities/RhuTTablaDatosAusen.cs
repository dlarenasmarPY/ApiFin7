using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTTablaDatosAusen
{
    public decimal PEmpId { get; set; }

    public int BitFicLinea { get; set; }

    public string BitFicArchivo { get; set; } = null!;

    public string EntRut { get; set; } = null!;

    public int NroContrato { get; set; }

    public decimal Permiso { get; set; }

    public DateTime SpeFecSolic { get; set; }

    public DateTime SpeFecInicio { get; set; }

    public DateTime SpeFecTermino { get; set; }

    public short SpeDias { get; set; }

    public DateTime SpeHraInicio { get; set; }

    public DateTime SpeHraTermino { get; set; }

    public double SpeHoras { get; set; }

    public string SpeObsSolic { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;
}
