using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTDrtResumenAnual
{
    public decimal DrtRanId { get; set; }

    public decimal PDrtDclId { get; set; }

    public decimal PFicPerId { get; set; }

    public double DrtRemunImpon { get; set; }

    public double DrtRemunImponAct { get; set; }

    public double DrtDesctosPrev { get; set; }

    public double DrtDesctosPrevAct { get; set; }

    public double DrtRentaNeta { get; set; }

    public double DrtRentaNetaAct { get; set; }

    public double DrtImptoRet { get; set; }

    public double DrtImptoRetAct { get; set; }

    public double DrtMayorRetSol { get; set; }

    public double DrtMayorRetSolAct { get; set; }

    public double DrtRentaExenta { get; set; }

    public double DrtRentaExentaAct { get; set; }

    public double DrtRebZonaExtr { get; set; }

    public double DrtRebZonaExtrAct { get; set; }

    public double DrtImptoRetEje { get; set; }

    public double DrtImptoRetEjeSgt { get; set; }

    public byte DrtIndEne { get; set; }

    public byte DrtIndFeb { get; set; }

    public byte DrtIndMar { get; set; }

    public byte DrtIndAbr { get; set; }

    public byte DrtIndMay { get; set; }

    public byte DrtIndJun { get; set; }

    public byte DrtIndJul { get; set; }

    public byte DrtIndAgo { get; set; }

    public byte DrtIndSep { get; set; }

    public byte DrtIndOct { get; set; }

    public byte DrtIndNov { get; set; }

    public byte DrtIndDic { get; set; }

    public decimal DrtCertificado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double DrtRentaNoGrava { get; set; }

    public double DrtRentaNoGravaAct { get; set; }

    public virtual RhuTDrtDeclaracion PDrtDcl { get; set; } = null!;
}
