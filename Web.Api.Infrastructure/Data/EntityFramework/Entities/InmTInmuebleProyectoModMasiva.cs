using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTInmuebleProyectoModMasiva
{
    public int Linea { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PinmuebleId { get; set; }

    public string InmuebleCodigo { get; set; } = null!;

    public short TinmId { get; set; }

    public double MtTerreno { get; set; }

    public double MtConstruidos { get; set; }

    public double MtVendibles { get; set; }

    public double MtMunicipales { get; set; }

    public string Deslindes { get; set; } = null!;

    public string CodOrientacion { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public double PrecioVenta { get; set; }

    public byte DocEstado { get; set; }

    public string DireccionInmueble { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCreId { get; set; }

    public string NumeroMunicipal { get; set; } = null!;

    public decimal PMonedaCostoId { get; set; }

    public double ValorCosto { get; set; }

    public double PrecioLista { get; set; }

    public byte ClasificaId { get; set; }

    public string NomArchPlano { get; set; } = null!;

    public double SupUtil { get; set; }

    public double SupTerraza { get; set; }

    public double SupLogia { get; set; }

    public string Piso { get; set; } = null!;

    public byte CantDormitorios { get; set; }

    public byte CantDormServ { get; set; }

    public byte CantBanos { get; set; }

    public byte CantBanosServ { get; set; }

    public double PrecioStock { get; set; }

    public double PorcentajeDescto { get; set; }

    public double MontoDescto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double MtTotales { get; set; }

    public byte IndLogia { get; set; }

    public byte IndBanoV { get; set; }

    public string CodigoRol { get; set; } = null!;

    public DateTime FechaRecepcion { get; set; }

    public double M2legales { get; set; }

    public int IndicadorIvaInm { get; set; }

    public string ColorInm { get; set; } = null!;
}
