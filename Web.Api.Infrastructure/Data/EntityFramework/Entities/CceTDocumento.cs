using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CceTDocumento
{
    public decimal DocCceId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEntIdSec { get; set; }

    public short EntSucNumeroSec { get; set; }

    public decimal PMonedaId { get; set; }

    public short TdoId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public decimal PEntIdTer { get; set; }

    public short EntSucNumeroTer { get; set; }

    public DateTime DocCceFecEmi { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public byte NivId { get; set; }

    public decimal PPartidaId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public int InstCod { get; set; }

    public int PlaCod { get; set; }

    public string DocCceCtaCteBco { get; set; } = null!;

    public short DocCceTotCuota { get; set; }

    public DateTime DocCceFecVenc { get; set; }

    public DateTime DocCceFecLib { get; set; }

    public DateTime DocCceFecProrroga { get; set; }

    public DateTime DocCceFecProyectada { get; set; }

    public DateTime DocCceFecProxima { get; set; }

    public byte DocCceEstado { get; set; }

    public byte DocCceSco { get; set; }

    public string DocCceUserCobResp { get; set; } = null!;

    public string DocCceUserVenResp { get; set; } = null!;

    public int DocCcePorEncaje { get; set; }

    public byte DocCceIndSelec { get; set; }

    public string DocCceDocRef { get; set; } = null!;

    public byte DocCceUbiFisCod { get; set; }

    public string DocCceNumCedente { get; set; } = null!;

    public string DocCceNumPagCedente { get; set; } = null!;

    public string DocCceNumDocBanco { get; set; } = null!;

    public decimal PEntCcoId { get; set; }

    public string DocCceEmiFolio { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<CceTMovimiento> CceTMovimientos { get; } = new List<CceTMovimiento>();

    public virtual GlbTDivision DivCodigoNavigation { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual GlbTDocumento Tdo { get; set; } = null!;
}
