using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTRecepcionCab
{
    public decimal RecepcionCabId { get; set; }

    public decimal PEmpId { get; set; }

    public string RecRutEmisor { get; set; } = null!;

    public string RecRutEnvia { get; set; } = null!;

    public string RecRutReceptor { get; set; } = null!;

    public DateTime RecFecResolucion { get; set; }

    public int RecNroResolucion { get; set; }

    public DateTime RecFecRecepcion { get; set; }

    public string RecNombreArchivo { get; set; } = null!;

    public byte RecEstado { get; set; }

    public string RecOwner { get; set; } = null!;

    public decimal PEntIdFirma { get; set; }

    public DateTime RecFecFirma { get; set; }

    public DateTime RecFecEnvia { get; set; }

    public string RecXml { get; set; } = null!;

    public string RecXmlRespuesta { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string Email { get; set; } = null!;
}
