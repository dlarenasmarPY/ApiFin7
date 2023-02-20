using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTEmbarqueCab
{
    public decimal EmbarqueCabId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public int EmcNumDocto { get; set; }

    public string EmcNumReserva { get; set; } = null!;

    public DateTime EmcFecReserva { get; set; }

    public DateTime EmcFecStacking { get; set; }

    public DateTime EmcFecEmbarque { get; set; }

    public byte EmcTipoTransporte { get; set; }

    public decimal PEntCiaTransId { get; set; }

    public decimal PEntSucCiaTransId { get; set; }

    public string EmcNave { get; set; } = null!;

    public string EmcEspacioReservado { get; set; } = null!;

    public decimal PPuertoOrigen { get; set; }

    public decimal PPuertoDestino { get; set; }

    public decimal PBodegaId { get; set; }

    public string EmcLugarEntregaTran { get; set; } = null!;

    public DateTime EmcFecLugarEntregaTran { get; set; }

    public string EmcLugarEntregaCli { get; set; } = null!;

    public DateTime EmcFecLugarEntregaCli { get; set; }

    public decimal PEntAduanaId { get; set; }

    public decimal PEntSucAduanaId { get; set; }

    public string EmcObservacion { get; set; } = null!;

    public string EmcConocimiento { get; set; } = null!;

    public DateTime EmcFecConocimiento { get; set; }

    public byte EmcPagoFlete { get; set; }

    public double EmcMtoFlete { get; set; }

    public decimal PMonedaFleteId { get; set; }

    public decimal PEntFleteId { get; set; }

    public byte EmcPagoSeguro { get; set; }

    public double EmcMtoSeguro { get; set; }

    public decimal PMonedaSeguroId { get; set; }

    public decimal PEntSeguroId { get; set; }

    public byte EmcPagoOtroGasto { get; set; }

    public double EmcMtoOtroGasto { get; set; }

    public decimal PMonedaOtroGastoId { get; set; }

    public decimal PEntOtroGastoId { get; set; }

    public byte EmcUsaCertificado { get; set; }

    public string EmcGlosaBl { get; set; } = null!;

    public string EmcGlosaInstructivo { get; set; } = null!;

    public decimal PUnidadMedClienteId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public byte ConEstCod { get; set; }

    public string CodOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte EmcUsaMtoEscrito { get; set; }

    public byte EmcUsaKiloNeto { get; set; }

    public byte EmcUsaCantItem { get; set; }

    public byte EmcUsaAgrupaDetalle { get; set; }

    public byte EmcUsaObsPiePagina { get; set; }

    public string EmcObsPiePagina { get; set; } = null!;

    public decimal PReservaEnvioCabId { get; set; }

    public short TmvCodigo { get; set; }

    public short TppCodigo { get; set; }

    public decimal PEntDirId { get; set; }

    public string DescriClauVta { get; set; } = null!;
}
