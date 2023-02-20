using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class FljTCabEveNoContab
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public string EntRut { get; set; } = null!;

    public short MovSucNumero { get; set; }

    public short TdoId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public short MovCceNumCuota { get; set; }

    public decimal TipoFlujoCod { get; set; }

    public short PerId { get; set; }

    public DateTime ProDocFecha { get; set; }

    public DateTime DocCceFecVenc { get; set; }

    public byte DocCceEstado { get; set; }

    public string MovCceGlosa { get; set; } = null!;

    public decimal TesSdoMontoOriginal { get; set; }

    public bool Imputacion { get; set; }
}
