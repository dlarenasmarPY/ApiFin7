using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcCab
{
    public decimal OcCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int CorrLogtNum { get; set; }

    public byte IndProcedencia { get; set; }

    public byte IndCargoDirecto { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public string ContactoProv { get; set; } = null!;

    public decimal PTipoOpeId { get; set; }

    public decimal PListaPreCabId { get; set; }

    public decimal PCotizCabId { get; set; }

    public DateTime FechaEntrega { get; set; }

    public decimal PCconsumoId { get; set; }

    public decimal PDocOrigenId { get; set; }

    public int TipoUrgenciaCod { get; set; }

    public int TipoPrecioCod { get; set; }

    public byte IndicaFlete { get; set; }

    public string AdqGlosa { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioCierrePend { get; set; } = null!;

    public DateTime FechaCierrePend { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string AdqOwner { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string UsuarioPendAprobacion { get; set; } = null!;

    public decimal PConvenioId { get; set; }

    public decimal EntId3 { get; set; }

    public short EntSucNumero3 { get; set; }

    public byte IvaSituacion { get; set; }

    public string NumSolicitud { get; set; } = null!;

    public string NombreSolicitante { get; set; } = null!;

    public string Encargado { get; set; } = null!;

    public decimal PPuertoOrigen { get; set; }

    public decimal PPuertoDestino { get; set; }

    public byte TipoTranspCod { get; set; }

    public decimal PMetodoEnvioId { get; set; }

    public virtual ICollection<AdqTOcCabComercial> AdqTOcCabComercials { get; } = new List<AdqTOcCabComercial>();

    public virtual ICollection<AdqTOcCabCont> AdqTOcCabConts { get; } = new List<AdqTOcCabCont>();

    public virtual ICollection<AdqTOcCabFecha> AdqTOcCabFechas { get; } = new List<AdqTOcCabFecha>();

    public virtual ICollection<AdqTOcCabFlete> AdqTOcCabFletes { get; } = new List<AdqTOcCabFlete>();

    public virtual ICollection<AdqTOcCabGlosa> AdqTOcCabGlosas { get; } = new List<AdqTOcCabGlosa>();

    public virtual ICollection<AdqTOcCabTotale> AdqTOcCabTotales { get; } = new List<AdqTOcCabTotale>();

    public virtual ICollection<AdqTOcDet> AdqTOcDets { get; } = new List<AdqTOcDet>();

    public virtual GlbTDivision DivCodigoNavigation { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual GlbTEntidadSucursal PEntSuc { get; set; } = null!;

    public virtual LogTTipoOperacione PTipoOpe { get; set; } = null!;
}
