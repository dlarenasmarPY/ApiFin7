using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTExcTipExc
{
    public decimal TexId { get; set; }

    public decimal PItmEveAsiId { get; set; }

    public byte TexCod { get; set; }

    public string TexGlosa { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem PItmEveAsi { get; set; } = null!;

    public virtual ICollection<RhuTExcEmpresa> RhuTExcEmpresas { get; } = new List<RhuTExcEmpresa>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicas { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicas { get; } = new List<RhuTLicRmedica>();

    public virtual ICollection<RhuTPerSolicitud> RhuTPerSolicituds { get; } = new List<RhuTPerSolicitud>();
}
