using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTInterfazEntradum
{
    public decimal IntCcoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PFrmCcoId { get; set; }

    public string IntCcoNomArchivo { get; set; } = null!;

    public string IntCcoOwner { get; set; } = null!;

    public DateTime IntCcoFechaRecepcion { get; set; }

    public DateTime IntCcoFechaCedente { get; set; }

    public string IntCcoRutCedente { get; set; } = null!;

    public byte TipoRegistro { get; set; }

    public int IntCcoNumLinea { get; set; }

    public short PerId { get; set; }

    public string IntCcoRutAceptante { get; set; } = null!;

    public string IntCcoRazonSocial { get; set; } = null!;

    public string IntCcoDocRef { get; set; } = null!;

    public int IntCcoNumCedente { get; set; }

    public string IntCcoNumPagCedente { get; set; } = null!;

    public string IntCcoTipoMovEntExt { get; set; } = null!;

    public string IntCcoNumDocEntExt { get; set; } = null!;

    public short IntCcoTipoDoc { get; set; }

    public string IntCcoNumeroDoc { get; set; } = null!;

    public DateTime IntCcoFechaVenc { get; set; }

    public DateTime IntCcoFecProrroga { get; set; }

    public double IntCcoMontoDocumento { get; set; }

    public double IntCcoMontoAnticipo { get; set; }

    public double IntCcoMontoGastos { get; set; }

    public double IntCcoMontoInteres { get; set; }

    public double IntCcoMontoIngreso { get; set; }

    public double IntCcoMontoEgreso { get; set; }

    public double IntCcoMontoComision { get; set; }

    public double IntCcoMontoProtesto { get; set; }

    public double IntCcoPorcentajeFin { get; set; }

    public int CtaCodigo { get; set; }

    public decimal PMonedaId { get; set; }

    public short IntCcoNumCuota { get; set; }

    public string IntCcoRutEntExt { get; set; } = null!;

    public int InstCod { get; set; }

    public short EntSucNumero { get; set; }

    public int PlaCod { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public byte InsCcoCod { get; set; }

    public byte ModCcoCod { get; set; }

    public byte TipNotCod { get; set; }

    public byte IntCcoError { get; set; }
}
