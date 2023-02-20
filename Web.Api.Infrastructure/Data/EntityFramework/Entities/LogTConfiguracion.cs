using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTConfiguracion
{
    public byte TipoReserva { get; set; }

    public short DiasMinimoFechaProceso { get; set; }

    public byte IndReceta { get; set; }

    public byte IndFacturacion { get; set; }

    public byte IndPacking { get; set; }

    public byte PartNumberObligatorio { get; set; }

    public byte RutObligatorio { get; set; }

    public byte IncGlosaDesp { get; set; }

    public byte IndProcesoValoriza { get; set; }

    public byte NoContabilizaCm { get; set; }

    public byte TipoContabCm { get; set; }

    public byte ValidaDecServicios { get; set; }

    public byte IndInvTomaCiega { get; set; }

    public byte HojaUnicaInv { get; set; }
}
