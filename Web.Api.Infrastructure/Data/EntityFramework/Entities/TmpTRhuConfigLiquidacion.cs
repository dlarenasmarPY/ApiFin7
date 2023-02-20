using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuConfigLiquidacion
{
    public decimal? CnRPEmpId { get; set; }

    public string? CnRCnRcodigo { get; set; }

    public string? CnRCnRdescripcion { get; set; }

    public byte? CnRCnRnivActualizacion { get; set; }

    public string? CnRCnRtipo { get; set; }

    public string? CnRCnRtipoVariable { get; set; }

    public string? CnRCnRtipoFormula { get; set; }

    public short? CnRCnRtipoDato { get; set; }

    public byte? CnRCnRindReliquidacion { get; set; }

    public byte? CnRCnRindCorrUtmacc { get; set; }

    public byte? CnRCnRindCalculoDif { get; set; }

    public string? CnRCnRactDatoTbMidTbMnombre { get; set; }

    public string? CnRCnRactDatoAtrMidTbMnombre { get; set; }

    public string? CnRCnRactDatoAtrMidAtrMnombre { get; set; }

    public DateTime? CpeCpeFecIniVigencia { get; set; }

    public short? CpeCpeEstado { get; set; }

    public DateTime? CpeCpeFecTerVigencia { get; set; }

    public string? CpeCnRtipoAplicabilidad { get; set; }

    public string? CpeCpeFormula { get; set; }

    public string? CpeCpeOriDatoAtrMidTbMnombre { get; set; }

    public string? CpeCpeOriDatoAtrMidAtrMnombre { get; set; }

    public string? CpeCpeRefAplicTbMidTbMnombre { get; set; }

    public byte? CpeCpeIndUsoPermte { get; set; }

    public byte? CpeCpeIndUsoMovtoMes { get; set; }

    public string? CpeCpeTopeTipo { get; set; }

    public double? CpeCpeTopeValor { get; set; }

    public string? CpeCpeTopeConcRemIdCnRcodigo { get; set; }

    public int? CpeCpeTipoAjuste { get; set; }

    public byte? CpeCpeIndHabLiquido { get; set; }

    public byte? CpeCpeHabLiquidoUso { get; set; }

    public byte? CpeCpeHabLiquidoRec { get; set; }

    public byte? CpeCpeIndGrabacion { get; set; }

    public byte? CpeCpeIndCentralizacion { get; set; }

    public string? CpeCpeBaseImprConcIdCnRcodigo { get; set; }

    public decimal? CpeCpeReliqDesdePerId { get; set; }

    public decimal? CpeCpeReliqHastaPerId { get; set; }

    public string? TotPConcRemIdCnRcodigo { get; set; }

    public string? TotCttTipoOperacion { get; set; }

    public byte? TotCttIndAfecPerLiq { get; set; }

    public byte? TotCttIndAfecPerDev { get; set; }

    public int? CpRCprPrioridadCalc { get; set; }

    public DateTime? CpRCprFecIniVigencia { get; set; }

    public DateTime? CpRCprFecTerVigencia { get; set; }
}
