using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public short CfgDlgPerId { get; set; }

    public byte CfgDlgPerIdAntCerrado { get; set; }

    public short CfgDlgNumLineaBol { get; set; }

    public short CfgDlgNumLineaExp { get; set; }

    public short CfgDlgNumLineaNac { get; set; }

    public byte CfgDlgTotalHoja { get; set; }

    public byte CfgDlgLargoLinea { get; set; }

    public string CfgDlgSeparador { get; set; } = null!;

    public byte CfgDlgContabAutomatico { get; set; }

    public byte CfgDlgUpdFolioNulo { get; set; }

    public byte CfgDlgUsaElectronico { get; set; }

    public byte CfgDlgDistribuyeFolio { get; set; }

    public byte CfgDlgCalceNcd { get; set; }

    public byte CfgDlgImprimeComponente { get; set; }

    public decimal CfgDlgpTipoOpeGuiaId { get; set; }

    public decimal CfgDlgpTipoOpeOtroId { get; set; }

    public decimal CfgDlgpCtaAnticipoId { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte CfgDlgUsaParidadExacta { get; set; }

    public double CfgDlgPorcIvaUsoComun { get; set; }

    public byte CfgDlgProcesoAutomatico { get; set; }

    public short CfgDiaFactu { get; set; }

    public byte CfgDlgSeparaUemisora { get; set; }

    public byte CfgDlgImprimeGlosaPro { get; set; }

    public byte CfgDlgImprimeGlosaSer { get; set; }

    public decimal CfgDlgpProdClasId { get; set; }

    public byte CfgDlgIndCesion { get; set; }

    public byte CfgDlgUsaCesionAsocia { get; set; }

    public double CfgDlgPorcTolerancia { get; set; }

    public byte CfgDlgUsaContabilizaWs { get; set; }
}
