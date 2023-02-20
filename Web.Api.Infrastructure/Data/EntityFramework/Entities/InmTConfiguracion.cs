using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public short TdoIdCarOfe { get; set; }

    public decimal PCtaIdAntDeudores { get; set; }

    public decimal PCtaIdAntFuturo { get; set; }

    public decimal PCtaIdIntNoDev { get; set; }

    public decimal PCtaIdIntDev { get; set; }

    public decimal PCorIdCarOfe { get; set; }

    public decimal PCorIdPromesa { get; set; }

    public decimal PCorIdConvenio { get; set; }

    public decimal PCorIdPagares { get; set; }

    public decimal PTipoOpeIdEsc { get; set; }

    public decimal PTipoOpeIdTraspaso { get; set; }

    public bool CfgIndInteres { get; set; }

    public decimal PCtaIdVtaDesis { get; set; }

    public decimal PCtaIdCarEsc { get; set; }

    public decimal PCreIdCarEsc { get; set; }

    public int CdiCodigoCarEsc { get; set; }

    public decimal PTprIdCarEsc { get; set; }

    public string PryNumeroCarEsc { get; set; } = null!;

    public int PCtaIdAboEsc { get; set; }

    public decimal PCreIdAboEsc { get; set; }

    public int CdiCodigoAboEsc { get; set; }

    public decimal PTprIdAboEsc { get; set; }

    public string PryNumeroAboEsc { get; set; } = null!;

    public decimal PCtaIdCarPro { get; set; }

    public decimal PCreIdCarPro { get; set; }

    public int CdiCodigoCarPro { get; set; }

    public decimal PTprIdCarPro { get; set; }

    public string PryNumeroCarPro { get; set; } = null!;

    public decimal PCtaIdAboPro { get; set; }

    public decimal PCreIdAboPro { get; set; }

    public int CdiCodigoAboPro { get; set; }

    public decimal PTprIdAboPro { get; set; }

    public string PryNumeroAboPro { get; set; } = null!;

    public decimal PTipoOpeIdPro { get; set; }

    public decimal PCtaIdCarCosto { get; set; }

    public decimal PCreIdCarCosto { get; set; }

    public int CdiCodigoCarCosto { get; set; }

    public decimal PTprIdCarCosto { get; set; }

    public string PryNumeroCarCosto { get; set; } = null!;

    public int PCtaIdAboCosto { get; set; }

    public decimal PCreIdAboCosto { get; set; }

    public int CdiCodigoAboCosto { get; set; }

    public decimal PTprIdAboCosto { get; set; }

    public string PryNumeroAboCosto { get; set; } = null!;

    public double PorcContProm { get; set; }

    public string PathPlanos { get; set; } = null!;

    public string PathDocumentos { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short OpeCod { get; set; }

    public decimal PTipoOpeId { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PCtaIdPagos { get; set; }

    public int MontoDifPag { get; set; }

    public int IndPaqos { get; set; }

    public decimal PTipoNegocio { get; set; }

    public decimal PTipoFact { get; set; }

    public int ContabDesis { get; set; }

    public decimal PTipoFactEx { get; set; }

    public int PTipoOpeAnt { get; set; }

    public decimal PCtaIdExcedente { get; set; }

    public int TipodePago { get; set; }

    public int TipoEscritura { get; set; }
}
