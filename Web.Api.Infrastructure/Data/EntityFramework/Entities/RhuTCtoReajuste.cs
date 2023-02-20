using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoReajuste
{
    public decimal RteId { get; set; }

    public DateTime RteFecha { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public DateTime RteFecVigencia { get; set; }

    public byte RteTipoReajuste { get; set; }

    public decimal PProcRemId { get; set; }

    public decimal PConcRemId { get; set; }

    public decimal PConcPerId { get; set; }

    public double RteReajuste { get; set; }

    public byte RteIndRedondeo { get; set; }

    public decimal RteValorMin { get; set; }

    public decimal RteValorMax { get; set; }

    public DateTime RteFecAntiguedadDes { get; set; }

    public DateTime RteFecAntiguedadHas { get; set; }

    public decimal PTabParId { get; set; }

    public decimal PItmParDesId { get; set; }

    public decimal PItmParHasId { get; set; }

    public decimal PCtoId { get; set; }

    public string RteObservacion { get; set; } = null!;

    public byte RteIndProporcional { get; set; }

    public byte RteEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PTipCtoDesde { get; set; }

    public decimal PTipCtoHasta { get; set; }

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual ICollection<RhuTCtoReajustesDet> RhuTCtoReajustesDets { get; } = new List<RhuTCtoReajustesDet>();
}
