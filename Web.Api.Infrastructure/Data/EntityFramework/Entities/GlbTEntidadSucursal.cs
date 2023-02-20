using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEntidadSucursal
{
    public decimal EntSucId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public string EntSucDescripcion { get; set; } = null!;

    public decimal PEntDirId { get; set; }

    public decimal PEntConId { get; set; }

    public decimal PFormaPagoId { get; set; }

    public byte FormaPagoCheque { get; set; }

    public byte IndCruzado { get; set; }

    public int InstCod { get; set; }

    public short EntSucInstSuc { get; set; }

    public string EntSucCodCtaCteBco { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string EntSucCodCtaCteBcoMx { get; set; } = null!;

    public virtual ICollection<AdqTCotizacionCab> AdqTCotizacionCabs { get; } = new List<AdqTCotizacionCab>();

    public virtual ICollection<AdqTFleteProvCab> AdqTFleteProvCabs { get; } = new List<AdqTFleteProvCab>();

    public virtual ICollection<AdqTOcCab> AdqTOcCabs { get; } = new List<AdqTOcCab>();

    public virtual ICollection<RhuTCtoDistribucion> RhuTCtoDistribucions { get; } = new List<RhuTCtoDistribucion>();

    public virtual ICollection<RhuTCtoRetJudiciale> RhuTCtoRetJudiciales { get; } = new List<RhuTCtoRetJudiciale>();
}
