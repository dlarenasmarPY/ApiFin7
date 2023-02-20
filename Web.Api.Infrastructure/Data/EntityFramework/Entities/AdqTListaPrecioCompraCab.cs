using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTListaPrecioCompraCab
{
    public decimal ListaPreCabId { get; set; }

    public string ListaPreDes { get; set; } = null!;

    public decimal PEntId { get; set; }

    public string ReferenciaProv { get; set; } = null!;

    public byte IndTipoListaPre { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCondPagoId { get; set; }

    public short PlazoNormalPago { get; set; }

    public double DesctoPorc1 { get; set; }

    public double DesctoPorc2 { get; set; }

    public double DesctoPorc3 { get; set; }

    public double DesctoPorc4 { get; set; }

    public double TotalDesctoPorc { get; set; }

    public short PlazoPrePago { get; set; }

    public double DesctoPorcPrepago { get; set; }

    public decimal PClausulaId { get; set; }

    public double ClausulaPorcFob { get; set; }

    public double ClausulaPorcCif { get; set; }

    public double ClausulaPorcBodega { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string AdqOwner { get; set; } = null!;

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<AdqTListaPrecioCompraDet> AdqTListaPrecioCompraDets { get; } = new List<AdqTListaPrecioCompraDet>();

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual GlbTMoneda PMoneda { get; set; } = null!;
}
