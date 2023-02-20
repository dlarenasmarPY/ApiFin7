using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTCabeceraCom
{
    public decimal CabCompId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public short TcoId { get; set; }

    public int ComNumero { get; set; }

    public DateTime ComFecha { get; set; }

    public decimal PTipoOpeId { get; set; }

    public byte ComEstadoCod { get; set; }

    public DateTime ComFechaReversa { get; set; }

    public decimal ComIdReversa { get; set; }

    public string DigUsuario { get; set; } = null!;

    public DateTime DigFecha { get; set; }

    public string ActUsuario { get; set; } = null!;

    public DateTime ActFecha { get; set; }

    public string? AprUsuario { get; set; }

    public DateTime AprFecha { get; set; }

    public string ComOwner { get; set; } = null!;

    public string ComGlosa { get; set; } = null!;

    public byte ComIndCorrMon { get; set; }

    public byte InterEmpDiv { get; set; }

    public byte SisCodOri { get; set; }

    public virtual GlbTDivision DivCodigoNavigation { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual GlbTUnidadAdm UniCodigoNavigation { get; set; } = null!;
}
