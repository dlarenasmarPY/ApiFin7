using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTTablaDatosPerman
{
    public int BitFicLinea { get; set; }

    public string BitFicArchivo { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public string EntRut { get; set; } = null!;

    public int NroContrato { get; set; }

    public string CodProceso { get; set; } = null!;

    public decimal PrmTipoDocId { get; set; }

    public string PrmNumDocto { get; set; } = null!;

    public DateTime PrmFechaDoc { get; set; }

    public byte PrmIndValInf { get; set; }

    public string ConceptoImpGlosa { get; set; } = null!;

    public string PrmValAlfNum { get; set; } = null!;

    public decimal PrmValNumerico { get; set; }

    public string PrmValBaseAlf { get; set; } = null!;

    public double PrmValBaseNum { get; set; }

    public DateTime PrmFecIniVigencia { get; set; }

    public int PrmCantMesVig { get; set; }

    public DateTime PrmFecTerVigencia { get; set; }

    public decimal PrmMdaId { get; set; }

    public int CreCodigo { get; set; }

    public decimal PrmTprId { get; set; }

    public string PryNumero { get; set; } = null!;
}
