using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTMoneda
{
    public decimal MonedaId { get; set; }

    public string MonGlosa { get; set; } = null!;

    public string MonSimbolo { get; set; } = null!;

    public string MonGlosaValor1 { get; set; } = null!;

    public byte MonNroDec { get; set; }

    public double MonMaxDiferencia { get; set; }

    public short TipoMonedaCnci { get; set; }

    public string MonCodigoSii { get; set; } = null!;

    public virtual ICollection<AdqTCotizacionCabCom> AdqTCotizacionCabComs { get; } = new List<AdqTCotizacionCabCom>();

    public virtual ICollection<AdqTListaPrecioCompraCab> AdqTListaPrecioCompraCabs { get; } = new List<AdqTListaPrecioCompraCab>();

    public virtual ICollection<AdqTListaPrecioCompraDet> AdqTListaPrecioCompraDets { get; } = new List<AdqTListaPrecioCompraDet>();

    public virtual ICollection<AdqTOcCabComercial> AdqTOcCabComercials { get; } = new List<AdqTOcCabComercial>();

    public virtual ICollection<AdqTRolUsuarioEmp> AdqTRolUsuarioEmps { get; } = new List<AdqTRolUsuarioEmp>();

    public virtual ICollection<CcpTConceptosCcp> CcpTConceptosCcps { get; } = new List<CcpTConceptosCcp>();

    public virtual ICollection<ConTMovimiento> ConTMovimientos { get; } = new List<ConTMovimiento>();

    public virtual ICollection<IsaTMovimiento> IsaTMovimientos { get; } = new List<IsaTMovimiento>();

    public virtual ICollection<TesTMovimiento> TesTMovimientos { get; } = new List<TesTMovimiento>();
}
