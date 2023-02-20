using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTProyecto
{
    public decimal PTprId { get; set; }

    public short UniCodigo { get; set; }

    public decimal PPdcId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short TventaId { get; set; }

    public decimal PEntIdRepLegal1 { get; set; }

    public decimal PEntIdRepLegal2 { get; set; }

    public decimal PEntIdRepLegal3 { get; set; }

    public byte PdcNivel { get; set; }

    public byte Estado { get; set; }

    public byte IndUsaCcunico { get; set; }

    public double TopeDesctoMas { get; set; }

    public byte IndContabCstVnt { get; set; }

    public decimal PCreId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PMonedaCostoId { get; set; }

    public int CmuCodigo { get; set; }

    public short CostoInm { get; set; }

    public byte TipoComision { get; set; }

    public byte AplicaBono { get; set; }

    public byte PromesaAut { get; set; }

    public int IndPrecioMinimo { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public double M2totTerreno { get; set; }

    public double AvaluoTerreno { get; set; }

    public DateTime FechaAvaluo { get; set; }

    public int IndicadorIva { get; set; }

    public DateTime FechaIngMunicipal { get; set; }

    public int TipoAvaluo { get; set; }

    public int EmpresaVendedora { get; set; }

    public double TopeBenSinSubsid { get; set; }

    public double TopeBenConSubsid { get; set; }

    public double FactorSobreIva { get; set; }

    public double FactorExento { get; set; }

    public double TopeBeneficio { get; set; }
}
