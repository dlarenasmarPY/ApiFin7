using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoSolCambio
{
    public decimal SlTctoId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal SlTctoNumero { get; set; }

    public DateTime SlTctoFecVigencia { get; set; }

    public DateTime SlTctoFecRenovacion { get; set; }

    public DateTime SlTctoFecCompromiso { get; set; }

    public DateTime SlTctoFecAntiguedad { get; set; }

    public DateTime SlTctoFecFiniquito { get; set; }

    public decimal PItmTpContratoId { get; set; }

    public short CgoCodCargo { get; set; }

    public decimal PItmTpRtaId { get; set; }

    public decimal PItmTpImptoId { get; set; }

    public decimal PItmCategoriaId { get; set; }

    public decimal PItmCalJurId { get; set; }

    public short SlTctoJornada { get; set; }

    public decimal PItmJornadaId { get; set; }

    public byte SlTctoIndSegCes { get; set; }

    public decimal PCreId { get; set; }

    public decimal PItmLugarPagoId { get; set; }

    public decimal PLugId { get; set; }

    public decimal PItmGruConId { get; set; }

    public decimal PItmIntegroId { get; set; }

    public decimal PCcafEntId { get; set; }

    public byte SlTctoIndMutual { get; set; }

    public decimal PMutualEntId { get; set; }

    public decimal PMutualEntSucId { get; set; }

    public decimal PSdeId { get; set; }

    public decimal PItmCtoEstado { get; set; }

    public int SlTctoPeriodoDesde { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte SlTctoIndSegCes11 { get; set; }

    public virtual ConTCentrosResp PCre { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmCalJur { get; set; } = null!;

    public virtual RhuTParItem PItmCategoria { get; set; } = null!;

    public virtual RhuTParItem PItmIntegro { get; set; } = null!;

    public virtual RhuTParItem PItmJornada { get; set; } = null!;

    public virtual RhuTParItem PItmLugarPago { get; set; } = null!;

    public virtual RhuTParItem PItmTpContrato { get; set; } = null!;

    public virtual RhuTParItem PItmTpImpto { get; set; } = null!;

    public virtual RhuTParItem PItmTpRta { get; set; } = null!;

    public virtual RhuTParLugarTrabajo PLug { get; set; } = null!;
}
