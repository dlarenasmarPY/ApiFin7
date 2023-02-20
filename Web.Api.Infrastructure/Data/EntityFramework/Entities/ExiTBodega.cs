using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTBodega
{
    public decimal BodegaId { get; set; }

    public int BodegaCod { get; set; }

    public string BodegaDes { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PEntDirId { get; set; }

    public decimal PPlantaId { get; set; }

    public string EntRutResponsable { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndGeneraTransaccion { get; set; }

    public decimal PEntSucIdAuxiliar { get; set; }

    public virtual ICollection<AdqTFleteProvDet> AdqTFleteProvDets { get; } = new List<AdqTFleteProvDet>();

    public virtual ICollection<AdqTProcesoCompraDet> AdqTProcesoCompraDets { get; } = new List<AdqTProcesoCompraDet>();

    public virtual ICollection<ExiTUbicacione> ExiTUbicaciones { get; } = new List<ExiTUbicacione>();

    public virtual ICollection<LogTOperacionesLogtCab> LogTOperacionesLogtCabs { get; } = new List<LogTOperacionesLogtCab>();

    public virtual ICollection<LogTOperacionesLogtDet> LogTOperacionesLogtDets { get; } = new List<LogTOperacionesLogtDet>();

    public virtual ICollection<LogTPedidoMaterialCab> LogTPedidoMaterialCabs { get; } = new List<LogTPedidoMaterialCab>();

    public virtual ICollection<LogTReservasDet> LogTReservasDets { get; } = new List<LogTReservasDet>();

    public virtual ICollection<LogTSaldosBodega> LogTSaldosBodegas { get; } = new List<LogTSaldosBodega>();

    public virtual ExiTPlanta PPlanta { get; set; } = null!;
}
