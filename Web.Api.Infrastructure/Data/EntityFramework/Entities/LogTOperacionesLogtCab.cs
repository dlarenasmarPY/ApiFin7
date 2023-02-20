using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtCab
{
    public decimal OpeLogtCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PDocOrigenId { get; set; }

    public decimal PBodOrigenId { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public DateTime FecActBod { get; set; }

    public double TasaCambio { get; set; }

    public DateTime FecTasaIni { get; set; }

    public decimal PMonedaOrigenId { get; set; }

    public short ProNegocioCod { get; set; }

    public string GlosaExis { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string LogOwner { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PEmbarqueCabId { get; set; }

    public short PerId { get; set; }

    public DateTime FechaCierre { get; set; }

    public decimal NumRecepEmbarque { get; set; }

    public decimal PDevolucionCabId { get; set; }

    public byte AfectaConsignacion { get; set; }

    public decimal PConvenioCabId { get; set; }

    public decimal PCconsumoId { get; set; }

    public byte PedidoTipoRecepcion { get; set; }

    public byte TraspasoRecibido { get; set; }

    public int IntWms { get; set; }

    public virtual GlbTDivision DivCodigoNavigation { get; set; } = null!;

    public virtual ICollection<LogTOperacionesLogtCabCont> LogTOperacionesLogtCabConts { get; } = new List<LogTOperacionesLogtCabCont>();

    public virtual ICollection<LogTOperacionesLogtDet> LogTOperacionesLogtDets { get; } = new List<LogTOperacionesLogtDet>();

    public virtual ICollection<LogTOperacionesLogtDoctoRef> LogTOperacionesLogtDoctoRefs { get; } = new List<LogTOperacionesLogtDoctoRef>();

    public virtual ExiTBodega PBodega { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;
}
