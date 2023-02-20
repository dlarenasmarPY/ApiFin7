using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTApvcEmpresa
{
    public decimal CtoApvcId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal CtoApvcNum { get; set; }

    public decimal PInsParApvcId { get; set; }

    public string CtoApvcPlan { get; set; } = null!;

    public DateTime CtoApvcFecSuscripcion { get; set; }

    public decimal PMonedaApId { get; set; }

    public double CtoApvcAporte { get; set; }

    public double CtoApvcMaxAp { get; set; }

    public short CtoApvcPeriodicidad { get; set; }

    public short CtoApvcPorcMinTr { get; set; }

    public int CtoApvcNumMinTr { get; set; }

    public byte CtoApvcMesesVig { get; set; }

    public short CtoApvcMaxMesPerm { get; set; }

    public short CtoApvcMinMesPerm { get; set; }

    public int InstCod { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public decimal PItmParEstId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual RhuTParInstitucione PInsParApvc { get; set; } = null!;

    public virtual RhuTParItem PItmParEst { get; set; } = null!;

    public virtual RhuTParMoneda PMonedaAp { get; set; } = null!;

    public virtual ICollection<RhuTApvcAfiliado> RhuTApvcAfiliados { get; } = new List<RhuTApvcAfiliado>();

    public virtual ICollection<RhuTApvcLegale> RhuTApvcLegales { get; } = new List<RhuTApvcLegale>();
}
