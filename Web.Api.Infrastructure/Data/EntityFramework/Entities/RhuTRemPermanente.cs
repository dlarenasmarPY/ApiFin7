using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemPermanente
{
    public decimal ConcPermId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal? PCtoId { get; set; }

    public decimal PConcRemId { get; set; }

    public decimal PProcRemId { get; set; }

    public DateTime PrmFecIniVigencia { get; set; }

    public int PrmCantMesVig { get; set; }

    public DateTime PrmFecTerVigencia { get; set; }

    public byte PrmIndValInf { get; set; }

    public decimal PrmMdaId { get; set; }

    public decimal PrmValNumerico { get; set; }

    public string PrmValAlfNum { get; set; } = null!;

    public DateTime PrmValFecha { get; set; }

    public short PrmValHora { get; set; }

    public double PrmValBaseNum { get; set; }

    public string PrmValBaseAlf { get; set; } = null!;

    public decimal PrmpCreId { get; set; }

    public decimal PrmTprId { get; set; }

    public decimal PrmPryId { get; set; }

    public short PrmEstadoReg { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PrmTipoDocId { get; set; }

    public string PrmNumDocto { get; set; } = null!;

    public DateTime PrmFechaDoc { get; set; }

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;

    public virtual RhuTCtoContrato? PCto { get; set; }
}
