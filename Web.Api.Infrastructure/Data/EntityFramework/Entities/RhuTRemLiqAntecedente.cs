using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemLiqAntecedente
{
    public decimal LiqId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public string LiqTipoCalculo { get; set; } = null!;

    public decimal LiqRecalculoLiqId { get; set; }

    public short LiqSecRecalculo { get; set; }

    public DateTime LiqFecCalculo { get; set; }

    public DateTime LiqFecPago { get; set; }

    public DateTime LiqFecUf { get; set; }

    public DateTime LiqFecUtm { get; set; }

    public decimal? PAntPrevId { get; set; }

    public decimal? PAntAfpId { get; set; }

    public decimal? PAntSaludId { get; set; }

    public string LqTestadoPago { get; set; } = null!;

    public string LqTestadoCentraliz { get; set; } = null!;

    public decimal PRemAudId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PCreId { get; set; }

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual ICollection<RhuTRemLiqAccesorio> RhuTRemLiqAccesorios { get; } = new List<RhuTRemLiqAccesorio>();

    public virtual ICollection<RhuTRemLiqDato> RhuTRemLiqDatos { get; } = new List<RhuTRemLiqDato>();

    public virtual ICollection<RhuTRemLiqDetalle> RhuTRemLiqDetalles { get; } = new List<RhuTRemLiqDetalle>();

    public virtual RhuTRemLiqTotale? RhuTRemLiqTotale { get; set; }
}
