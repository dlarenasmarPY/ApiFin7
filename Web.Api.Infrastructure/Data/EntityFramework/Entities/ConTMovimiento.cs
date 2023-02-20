using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTMovimiento
{
    public decimal MovConId { get; set; }

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

    public string MovConNumero { get; set; } = null!;

    public short MovConNumCuota { get; set; }

    public DateTime MovConFecVenc { get; set; }

    public DateTime MovConFecProyectada { get; set; }

    public double MovConMontoImpuDebe { get; set; }

    public double MovConMontoImpuHaber { get; set; }

    public double MovConMontoLocalDebe { get; set; }

    public double MovConMontoLocalHaber { get; set; }

    public double MovConMontoConvDebe { get; set; }

    public double MovConMontoConvHaber { get; set; }

    public string MovConGlosa { get; set; } = null!;

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public byte NivId { get; set; }

    public decimal PPartidaId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public DateTime MovConCalFecha { get; set; }

    public int MovConConNumero { get; set; }

    public DateTime MovConConFecha { get; set; }

    public byte MovConEstado { get; set; }

    public DateTime MovConFecEstado { get; set; }

    public decimal PEntIdPago { get; set; }

    public decimal PDetCompId { get; set; }

    public decimal PCabCompId { get; set; }

    public string MovConOwner { get; set; } = null!;

    public decimal PEmpIdDestino { get; set; }

    public short DivCodigoDestino { get; set; }

    public short UniCodigoDestino { get; set; }

    public decimal PCabOpeIdOri { get; set; }

    public int CabOpeLineaOri { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public string MovConDocRef { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int MovIdRelEscenario { get; set; }

    public byte MarcaComplemento { get; set; }

    public byte IndCorreccionMon { get; set; }

    public virtual GlbTDivision DivCodigoNavigation { get; set; } = null!;

    public virtual ConTCuenta PCta { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual GlbTMoneda PMoneda { get; set; } = null!;

    public virtual GlbTUnidadAdm UniCodigoNavigation { get; set; } = null!;
}
