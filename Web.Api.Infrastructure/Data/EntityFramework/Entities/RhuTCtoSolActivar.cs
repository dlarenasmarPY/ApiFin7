using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoSolActivar
{
    public decimal CtoSolActId { get; set; }

    public DateTime CtoSolFecha { get; set; }

    public int CtoSolFolio { get; set; }

    public decimal PCtoTerId { get; set; }

    public decimal PItmSolActEstId { get; set; }

    public decimal PEmpId { get; set; }

    public short CtoSolDivDes { get; set; }

    public short CtoSolDivHas { get; set; }

    public int CtoSolCreDes { get; set; }

    public int CtoSolCreHas { get; set; }

    public DateTime CtoSolFecFnqDes { get; set; }

    public DateTime CtoSolFecFnqHas { get; set; }

    public decimal CtoSolTipCtoDes { get; set; }

    public decimal CtoSolTipCtoHas { get; set; }

    public decimal PTabParId { get; set; }

    public decimal CtoSolItmDes { get; set; }

    public decimal CtoSolItmHas { get; set; }

    public int EmpIdOrigen { get; set; }

    public int EmpIdDestino { get; set; }

    public short DivCodigoDestino { get; set; }

    public decimal PCreId { get; set; }

    public DateTime CtoSolFecCto { get; set; }

    public byte CtoActRentas { get; set; }

    public byte CtoActAfilia { get; set; }

    public byte CtoActPerma { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCtoTer { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual ICollection<RhuTCtoSolActivarDet> RhuTCtoSolActivarDets { get; } = new List<RhuTCtoSolActivarDet>();
}
