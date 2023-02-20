using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTCambioSujetoCab
{
    public decimal CambioSujetoCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PVendedorId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public string DvcNumOrdenC { get; set; } = null!;

    public DateTime DvcFecOrdenC { get; set; }

    public string CscReferenciaDocto { get; set; } = null!;

    public byte TpdTipoParidad { get; set; }

    public double DvcValorParidad { get; set; }

    public DateTime FechaParidad { get; set; }

    public double CfgPorcIva { get; set; }

    public double DlcPorcIvaRetenido { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public string CodOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PNegocioVtaId { get; set; }

    public byte CscTipoSujeto { get; set; }
}
