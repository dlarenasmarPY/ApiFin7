using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieBeneficiosTope
{
    public decimal BenTopId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PBeneficiosId { get; set; }

    public byte BenSecuencia { get; set; }

    public DateTime FecDesde { get; set; }

    public byte IndBeneficiario { get; set; }

    public string DescripTope { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public decimal ValAnual { get; set; }

    public decimal ValBeneficio { get; set; }

    public decimal IndAplica { get; set; }

    public decimal ValTope { get; set; }

    public decimal ValCoPago { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem IndAplicaNavigation { get; set; } = null!;

    public virtual RhuTBieBeneficio PBeneficios { get; set; } = null!;

    public virtual ICollection<RhuTBieSolicitude> RhuTBieSolicitudes { get; } = new List<RhuTBieSolicitude>();
}
