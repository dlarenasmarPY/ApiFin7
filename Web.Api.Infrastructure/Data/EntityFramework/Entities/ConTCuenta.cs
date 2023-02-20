using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTCuenta
{
    public decimal CtaId { get; set; }

    public int CtaCodigo { get; set; }

    public string CtaNombre { get; set; } = null!;

    public string CtaDescUsoCta { get; set; } = null!;

    public byte TctId { get; set; }

    public byte TccId { get; set; }

    public byte TauId { get; set; }

    public byte CtaUsaCentroResp { get; set; }

    public byte CtaContabCentro { get; set; }

    public byte CtaUsaConcepto { get; set; }

    public byte CtaContabConcepto { get; set; }

    public byte CtaUsaFechaReferencia { get; set; }

    public byte CtaUsaProyecto { get; set; }

    public byte CtaContabProyecto { get; set; }

    public byte CtaMultiMoneda { get; set; }

    public DateTime CtaFechaMaxImpu { get; set; }

    public byte CtaTipoConv { get; set; }

    public byte CtaUsaRut { get; set; }

    public byte CtaUsaMayor { get; set; }

    public decimal CtaCtaMayor { get; set; }

    public decimal CtaPresupuesto { get; set; }

    public decimal CtaFlujoDebe { get; set; }

    public decimal CtaFlujoHaber { get; set; }

    public short AuditaSaldoCod { get; set; }

    public byte CtaUsaPartida { get; set; }

    public byte CtaContabPartida { get; set; }

    public byte CtaUsaLineaProd { get; set; }

    public byte CtaContabLineaProd { get; set; }

    public byte CtaCobranza { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte? EfeFlujoEfe { get; set; }

    public byte? EfeActFijo { get; set; }

    public byte EscenarioCod { get; set; }

    public virtual ICollection<CceTMovimiento> CceTMovimientos { get; } = new List<CceTMovimiento>();

    public virtual ICollection<ConTMovimiento> ConTMovimientos { get; } = new List<ConTMovimiento>();

    public virtual ICollection<IsaTMovimiento> IsaTMovimientos { get; } = new List<IsaTMovimiento>();
}
