using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoTipoCertif
{
    public decimal DtoTipId { get; set; }

    public decimal PEmpId { get; set; }

    public int DtoTipCodigo { get; set; }

    public string DtoTipDescrip { get; set; } = null!;

    public string DtoTipPath { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTCtoDatosCertif> RhuTCtoDatosCertifs { get; } = new List<RhuTCtoDatosCertif>();
}
