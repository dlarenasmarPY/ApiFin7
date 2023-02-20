using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CceTMovimiento
{
    public decimal MovCceId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public byte SisCodOri { get; set; }

    public decimal PCabOpeId { get; set; }

    public int CabOpeLinea { get; set; }

    public string MovCceDigUsuario { get; set; } = null!;

    public DateTime MovCceDigFec { get; set; }

    public decimal PDocCceId { get; set; }

    public short MovCceNumCuota { get; set; }

    public decimal PCtaId { get; set; }

    public DateTime MovCceFecVenc { get; set; }

    public DateTime DocCceFecProyectada { get; set; }

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }

    public double MovCceMontoConvDebe { get; set; }

    public double MovCceMontoConvHaber { get; set; }

    public string MovCceGlosa { get; set; } = null!;

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public byte NivId { get; set; }

    public decimal PPartidaId { get; set; }

    public DateTime MovCceCalFecha { get; set; }

    public int MovCceConNumero { get; set; }

    public DateTime MovCceConFecha { get; set; }

    public byte MovCceEstado { get; set; }

    public DateTime MovCceFecEstado { get; set; }

    public decimal PEntIdPago { get; set; }

    public decimal PMovTesId { get; set; }

    public decimal PDetCompId { get; set; }

    public decimal PCabCompId { get; set; }

    public string MovCceOwner { get; set; } = null!;

    public decimal PFormaPagoId { get; set; }

    public DateTime MovCceFecPagoPropuesta { get; set; }

    public short UniCodigoEmi { get; set; }

    public decimal PEmpIdDestino { get; set; }

    public short DivCodigoDestino { get; set; }

    public short UniCodigoDestino { get; set; }

    public decimal PCabOpeIdOri { get; set; }

    public int CabOpeLineaOri { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public string MovCceDocRef { get; set; } = null!;

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

    public virtual CceTDocumento PDocCce { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual GlbTUnidadAdm UniCodigoNavigation { get; set; } = null!;
}
