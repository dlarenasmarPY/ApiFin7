using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEntidad
{
    public decimal EntId { get; set; }

    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public string EntNomFantasia { get; set; } = null!;

    public DateTime EntFecActivacion { get; set; }

    public byte EntTipoSociedadCod { get; set; }

    public int GirCod { get; set; }

    public int AecCod { get; set; }

    public byte EntProcedencia { get; set; }

    public byte EstEntCod { get; set; }

    public byte NivId { get; set; }

    public decimal PEntRutHolding { get; set; }

    public string EntSitioWeb { get; set; } = null!;

    public byte EntRutRetenedor { get; set; }

    public byte EntRutDifFisica { get; set; }

    public byte EntTipoRazonSocial { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte EntIndElectronico { get; set; }

    public byte EntFormatoEnvioDte { get; set; }

    public string EntMail { get; set; } = null!;

    public byte EntTipoCategoria { get; set; }

    public string Cuit { get; set; } = null!;

    public string CodContribuyente { get; set; } = null!;

    public byte Ident { get; set; }

    public byte IndRetIva { get; set; }

    public byte IndRetFuente { get; set; }

    public byte IndObligContab { get; set; }

    public string EntRazonSocialExtendida { get; set; } = null!;

    public decimal PPorcRetId { get; set; }

    public byte IndAfectoExento { get; set; }

    public virtual ICollection<AdqTCotizacionCab> AdqTCotizacionCabs { get; } = new List<AdqTCotizacionCab>();

    public virtual ICollection<AdqTFleteProvCab> AdqTFleteProvCabs { get; } = new List<AdqTFleteProvCab>();

    public virtual ICollection<AdqTListaPrecioCompraCab> AdqTListaPrecioCompraCabs { get; } = new List<AdqTListaPrecioCompraCab>();

    public virtual ICollection<AdqTOcCab> AdqTOcCabs { get; } = new List<AdqTOcCab>();

    public virtual ICollection<AdqTRubrosEntidade> AdqTRubrosEntidades { get; } = new List<AdqTRubrosEntidade>();

    public virtual ICollection<CcpTMovtosGto> CcpTMovtosGtos { get; } = new List<CcpTMovtosGto>();

    public virtual ICollection<LogTUnidadesMedidaEntidad> LogTUnidadesMedidaEntidads { get; } = new List<LogTUnidadesMedidaEntidad>();

    public virtual RhuTCapEntidade? RhuTCapEntidade { get; set; }

    public virtual ICollection<RhuTCtoAfiliacionVol> RhuTCtoAfiliacionVols { get; } = new List<RhuTCtoAfiliacionVol>();

    public virtual ICollection<RhuTCtoDistribucion> RhuTCtoDistribucions { get; } = new List<RhuTCtoDistribucion>();

    public virtual ICollection<RhuTCtoRetJudiciale> RhuTCtoRetJudicialePReceptorEnts { get; } = new List<RhuTCtoRetJudiciale>();

    public virtual ICollection<RhuTCtoRetJudiciale> RhuTCtoRetJudicialePRetenedorEnts { get; } = new List<RhuTCtoRetJudiciale>();

    public virtual RhuTEpeEntidad? RhuTEpeEntidad { get; set; }

    public virtual RhuTFicPersona? RhuTFicPersona { get; set; }

    public virtual ICollection<RhuTParInstitucione> RhuTParInstituciones { get; } = new List<RhuTParInstitucione>();
}
