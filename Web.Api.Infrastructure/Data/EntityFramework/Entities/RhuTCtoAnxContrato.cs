using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoAnxContrato
{
    public decimal AnxCtoId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal AnxCtoNumero { get; set; }

    public string AnxCtoSecuencia { get; set; } = null!;

    public DateTime AnxCtoFecVigencia { get; set; }

    public DateTime AnxCtoFecRenovacion { get; set; }

    public DateTime AnxCtoFecCompromiso { get; set; }

    public DateTime AnxCtoFecAntiguedad { get; set; }

    public DateTime AnxCtoFecFiniquito { get; set; }

    public decimal PItmTpContratoAnxId { get; set; }

    public short CgoCodCargo { get; set; }

    public decimal PItmTpRtaAnxId { get; set; }

    public decimal PItmTpImptoAnxId { get; set; }

    public decimal PItmCategoriaAnxId { get; set; }

    public decimal PItmCalJurAnxId { get; set; }

    public short AnxCtoJornada { get; set; }

    public decimal PItmJornadaAnxId { get; set; }

    public byte AnxCtoIndSegCes { get; set; }

    public decimal PCreId { get; set; }

    public decimal PItmLugarPagoAnxId { get; set; }

    public decimal PLugId { get; set; }

    public decimal PItmGruConAnxId { get; set; }

    public decimal PItmIntegroAnxId { get; set; }

    public decimal PCcafEntId { get; set; }

    public byte AnxCtoIndMutual { get; set; }

    public decimal PMutualEntId { get; set; }

    public decimal PMutualEntSucId { get; set; }

    public decimal PSdeId { get; set; }

    public decimal PItmEstadoAnxCtoId { get; set; }

    public int AnxCtoPeriodoDesde { get; set; }

    public string AnxCtoDicNumOrder { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte AnxCtoIndSegCes11 { get; set; }

    public virtual ConTCentrosResp PCre { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmCalJurAnx { get; set; } = null!;

    public virtual RhuTParItem PItmCategoriaAnx { get; set; } = null!;

    public virtual RhuTParItem PItmIntegroAnx { get; set; } = null!;

    public virtual RhuTParItem PItmJornadaAnx { get; set; } = null!;

    public virtual RhuTParItem PItmLugarPagoAnx { get; set; } = null!;

    public virtual RhuTParItem PItmTpContratoAnx { get; set; } = null!;

    public virtual RhuTParItem PItmTpImptoAnx { get; set; } = null!;

    public virtual RhuTParItem PItmTpRtaAnx { get; set; } = null!;

    public virtual RhuTParLugarTrabajo PLug { get; set; } = null!;
}
