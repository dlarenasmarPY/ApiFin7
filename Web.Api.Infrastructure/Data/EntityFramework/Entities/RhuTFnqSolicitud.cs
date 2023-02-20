using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFnqSolicitud
{
    public decimal FnqSolId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PCtoTerId { get; set; }

    public DateTime FnqSolFecha { get; set; }

    public int FnqSolFolio { get; set; }

    public byte FnqIndForma { get; set; }

    public decimal FnqpEmpId { get; set; }

    public decimal FnqCreDesId { get; set; }

    public decimal FnqCreHasId { get; set; }

    public DateTime FnqFecVigDes { get; set; }

    public DateTime FnqFecVigHas { get; set; }

    public DateTime FnqFecRenDes { get; set; }

    public DateTime FnqFecRenHas { get; set; }

    public decimal FnqCtoDesId { get; set; }

    public decimal FnqCtoHasId { get; set; }

    public decimal FnqTabParId { get; set; }

    public decimal FnqItmParDesId { get; set; }

    public decimal FnqItmParHasId { get; set; }

    public decimal PEsoId { get; set; }

    public decimal PItmFnqSolEstId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short DivCodigo { get; set; }

    public DateTime FnqSolCabFecFiniquito { get; set; }

    public DateTime FnqSolCabFecAviso { get; set; }

    public DateTime FnqSolCabFecPago { get; set; }

    public decimal PCabFnqCauId { get; set; }

    public decimal PCabFnqCauReaId { get; set; }

    public virtual RhuTCtoContrato PCtoTer { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual ICollection<RhuTFnqSolicitudDet> RhuTFnqSolicitudDets { get; } = new List<RhuTFnqSolicitudDet>();
}
