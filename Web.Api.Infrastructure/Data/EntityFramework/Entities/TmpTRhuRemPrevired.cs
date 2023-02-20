using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemPrevired
{
    public decimal ArcPrevId { get; set; }

    public string CodOwner { get; set; } = null!;

    public byte TipoRegistro { get; set; }

    public byte ClmIindAccesorio { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public int CreCodigo { get; set; }

    public byte CgoIndTrabPesado { get; set; }

    public DateTime PreviRedPerIni { get; set; }

    public DateTime PreviRedPerTer { get; set; }

    public decimal PAntPrevId { get; set; }

    public decimal PAntAfpId { get; set; }

    public decimal PAntSaludId { get; set; }

    public byte PreviRedSecRut { get; set; }

    public byte PreviRedSecMto { get; set; }

    public byte RhuRegimenImpos { get; set; }

    public string EntRut { get; set; } = null!;

    public DateTime FicFecNacimiento { get; set; }

    public string EntConApePaterno { get; set; } = null!;

    public string EntConApeMaterno { get; set; } = null!;

    public string EntConNombres { get; set; } = null!;

    public string IlgSexCodigo { get; set; } = null!;

    public bool EntNacionalidad { get; set; }

    public byte PreviRedTipoPago { get; set; }

    public double LqTtimponTopeSal { get; set; }

    public double LqTtimponible { get; set; }

    public string PreviRedRegPrev { get; set; } = null!;

    public byte PrevRedTipTrab { get; set; }

    public int LqTdiasPago { get; set; }

    public string IlgTipMovtoPers { get; set; } = null!;

    public DateTime IlgFecIniMovtoPers { get; set; }

    public DateTime IlgFecTerMovtoPers { get; set; }

    public string TraCodTramo { get; set; } = null!;

    public int PreNumCargasNor { get; set; }

    public int LqTnumCargasMat { get; set; }

    public int PreNumCargasInv { get; set; }

    public double IlgTasigFam { get; set; }

    public double IlgTasigFamR { get; set; }

    public double IlgTreintAf { get; set; }

    public double IlgTasigFamNor { get; set; }

    public double IlgTasigFamInv { get; set; }

    public double IlgTasigFamMat { get; set; }

    public int LqTnumCargasInvRetr { get; set; }

    public int LqTnumCargasNorRetr { get; set; }

    public int LqTnumCargasMatRetr { get; set; }

    public double IlgTasigFamNorRetr { get; set; }

    public double IlgTasigFamInvRetr { get; set; }

    public double IlgTasigFamMatRetr { get; set; }

    public int AfpCodSuperInt { get; set; }

    public double IlgCotObligatoria { get; set; }

    public double IlgAhoVoluntario { get; set; }

    public double IlgTtopeIndSust { get; set; }

    public double IlgPorcIndSust { get; set; }

    public int IlgCotIndSust { get; set; }

    public byte PreviRedNperIndSust { get; set; }

    public DateTime PreviRedPerIniIndSust { get; set; }

    public DateTime PreviRedPerTerIndSust { get; set; }

    public string CgoNombre { get; set; } = null!;

    public double CgoPorcentaje { get; set; }

    public double IlgCotTrabPesado { get; set; }

    public string IlgRutEntidadPag { get; set; } = null!;

    public int CjAcodSuperInt { get; set; }

    public short VinCodExCajaCja { get; set; }

    public double VinTasaImposicionCja { get; set; }

    public double IlgCotCajaAnt { get; set; }

    public double IlgTimponibleDesahucio { get; set; }

    public short VinCodExCajaCjadsh { get; set; }

    public double VinTasaDesahucioCja { get; set; }

    public double IlgCotFondoDesahucio { get; set; }

    public double PreviRedInpotrosAp { get; set; }

    public double IlgTsaludFonasa { get; set; }

    public double IlgTsaludCaja { get; set; }

    public double IlgBonifLey15386 { get; set; }

    public double PreviRedCredAfamEmp { get; set; }

    public double IlgTpagoInp { get; set; }

    public int IsaCodSuperInt { get; set; }

    public byte PreviRedMdaPlanSal { get; set; }

    public double IlgCotLegalSalud { get; set; }

    public double IlgLey18566 { get; set; }

    public double IlgTadiSalud { get; set; }

    public double PreviRedOtrosApSal { get; set; }

    public decimal IlgSalPlan { get; set; }

    public double IlgTisapre { get; set; }

    public string SalFun { get; set; } = null!;

    public decimal SalPlan { get; set; }

    public int CjCcodSuperInt { get; set; }

    public double IlgTprestamoCcaf { get; set; }

    public double IlgTconvDntCcaf { get; set; }

    public double IlgTleasingCcaf { get; set; }

    public double IlgTsegVidaCcaf { get; set; }

    public double IlgTotrosCcaf { get; set; }

    public double IlgTcotCcafnoIsap { get; set; }

    public double IlgTccafdescAf { get; set; }

    public int MutCodSuperInt { get; set; }

    public double IlgAporteMutual { get; set; }

    public short PreviRedSucMut { get; set; }

    public short PreviRedCodInsApv { get; set; }

    public byte PreviRedFormaPagoApv { get; set; }

    public double IlgApv { get; set; }

    public double IlgDepConvenido { get; set; }

    public double LqTtimponTopeSegC { get; set; }

    public double IlgSegCesTrabajador { get; set; }

    public double IlgSegCesEmpresa { get; set; }

    public string PreviRedCcosSucAge { get; set; } = null!;

    public double LqTttributable { get; set; }

    public double LqTtimpuestos { get; set; }

    public double LqTtafectoImpto { get; set; }

    public string IlgCodPrestamoFonasa { get; set; } = null!;

    public double IlgTprestamoFonasa { get; set; }

    public double LqTtimponTope { get; set; }

    public double IlgComisionFp { get; set; }

    public double IlgCotTrabPesadoAemp { get; set; }

    public double LqTtimponTopeMut { get; set; }

    public decimal IlgAporteComisionAfp { get; set; }

    public decimal IlgAporteComisionAfpacc { get; set; }
}
