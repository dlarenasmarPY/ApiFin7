using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public byte UsaCorrNp { get; set; }

    public int CorrelativoNp { get; set; }

    public decimal PListaPreCabId { get; set; }

    public byte CfgVtaUsaCorrelativoSav { get; set; }

    public int CfgVtaCorrelativoSav { get; set; }

    public byte CfgVtaUsaCorrelativoEmb { get; set; }

    public int CfgVtaCorrelativoEmb { get; set; }

    public byte CfgVtaConsolidaDeuda { get; set; }

    public byte CfgVtaConsolidaLcredito { get; set; }

    public byte CfgVtaConsolidaMorosidad { get; set; }

    public short CfgVtaDiaMorosidad { get; set; }

    public double CfgVtaMtoMinimoDeudor { get; set; }

    public byte CfgVtaUsaCarteraCliente { get; set; }

    public byte CfgVtaUsaCorrelativoDev { get; set; }

    public int CfgVtaCorrelativoDev { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PCondPagoId { get; set; }

    public byte CfgVtaConsolidaHoldCli { get; set; }

    public byte CfgVtaConsolidaEmpId { get; set; }

    public double CfgVtaPorcPrecioMaximo { get; set; }

    public double CfgVtaPorcMargenMinItem { get; set; }

    public double CfgVtaPorcMargenMaxItem { get; set; }

    public double CfgVtaPorcMargenMinVta { get; set; }

    public double CfgVtaPorcMargenMaxVta { get; set; }

    public byte UsaCorrCot { get; set; }

    public int CorrelativoCot { get; set; }

    public byte CfgVtaIndCcosto { get; set; }

    public byte CfgVtaUsaReaperturaNp { get; set; }

    public byte CfgVtaImprimeProductoDesNp { get; set; }

    public byte CfgVtaImprimeGlosaNp { get; set; }

    public byte CfgVtaMesDlg { get; set; }

    public decimal PCconsumoId { get; set; }
}
