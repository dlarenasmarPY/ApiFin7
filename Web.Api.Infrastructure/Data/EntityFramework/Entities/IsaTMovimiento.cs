using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IsaTMovimiento
{
    public decimal MovIsaId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public byte SisCodOri { get; set; }

    public decimal PCabOpeId { get; set; }

    public int CabOpeLinea { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEntIdSec { get; set; }

    public short EntSucNumeroSec { get; set; }

    public decimal PEntIdTer { get; set; }

    public short EntSucNumeroTer { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public short TdoId { get; set; }

    public string MovIsaNumero { get; set; } = null!;

    public DateTime MovIsaFecVenc { get; set; }

    public decimal MovIsaSecInterno { get; set; }

    public DateTime MovIsaFecProyectada { get; set; }

    public double MovIsaMontoImpuDebe { get; set; }

    public double MovIsaMontoImpuHaber { get; set; }

    public double MovIsaMontoLocalDebe { get; set; }

    public double MovIsaMontoLocalHaber { get; set; }

    public double MovIsaMontoConvDebe { get; set; }

    public double MovIsaMontoConvHaber { get; set; }

    public string MovIsaGlosa { get; set; } = null!;

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public byte NivId { get; set; }

    public decimal PPartidaId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public DateTime MovIsaCalFecha { get; set; }

    public int MovIsaConNumero { get; set; }

    public DateTime MovIsaConFecha { get; set; }

    public decimal PDetCompId { get; set; }

    public decimal PCabCompId { get; set; }

    public string MovIsaOwner { get; set; } = null!;

    public decimal PEmpIdDestino { get; set; }

    public short DivCodigoDestino { get; set; }

    public short UniCodigoDestino { get; set; }

    public decimal PCabOpeIdOri { get; set; }

    public int CabOpeLineaOri { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public string MovIsaDocRef { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int MovIdRelEscenario { get; set; }

    public byte MarcaComplemento { get; set; }

    public virtual GlbTDivision DivCodigoNavigation { get; set; } = null!;

    public virtual ConTCabeceraOpe PCabOpe { get; set; } = null!;

    public virtual ConTCuenta PCta { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual GlbTMoneda PMoneda { get; set; } = null!;

    public virtual GlbTUnidadAdm UniCodigoNavigation { get; set; } = null!;
}
