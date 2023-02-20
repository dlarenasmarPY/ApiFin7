using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTCargoBancario
{
    public string CodOwner { get; set; } = null!;

    public string NumDoctoPasivo { get; set; } = null!;

    public int InstCod { get; set; }

    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public DateTime AuxFechaInicio { get; set; }

    public DateTime FechaVenc { get; set; }

    public int NumeroCuota { get; set; }

    public int LineaDocto { get; set; }

    public double MontoIntereses { get; set; }

    public double MontoCuota { get; set; }

    public double CuotaMes { get; set; }

    public double NuevoInteres { get; set; }

    public decimal PPasDetDocumentoId { get; set; }

    public decimal PPasDocumentoId { get; set; }

    public string DocGlosaPas { get; set; } = null!;

    public short TdoId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public DateTime FechaEmision { get; set; }

    public int CodigoGastosDebe { get; set; }

    public decimal CtaIdIva { get; set; }

    public string MonSimbolo { get; set; } = null!;

    public double TasaInteres { get; set; }

    public double MontoPresente { get; set; }

    public double MontoTotal { get; set; }

    public double MontoIva { get; set; }

    public double MontoNoDevengado { get; set; }

    public decimal CtaIdHaber { get; set; }

    public decimal PEntId { get; set; }

    public byte APago { get; set; }

    public byte Pagosolointereses { get; set; }

    public decimal PMonedaId { get; set; }

    public byte TipoPasivoId { get; set; }
}
