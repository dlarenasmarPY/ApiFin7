using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTAuditoriaEscrituracion
{
    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public decimal PCartaOfertaId { get; set; }

    public DateTime FechaProceso { get; set; }

    public DateTime FechaEscrit { get; set; }

    public DateTime FechaCalculo { get; set; }

    public double CotTasaCambio { get; set; }

    public double PrecioVentaInm { get; set; }

    public double MontoLocal { get; set; }

    public int PBitacoraId { get; set; }

    public int FolioFactElec { get; set; }

    public double SupUtilCo { get; set; }

    public double SupUtilAd { get; set; }

    public double M2legalesTotales { get; set; }

    public double FactorM2legales { get; set; }

    public double AvaluoTerreno { get; set; }

    public double ValorTerreno { get; set; }

    public double CalculoAfecto { get; set; }

    public double CalculoExento { get; set; }

    public double MontoBruto { get; set; }

    public double TasaIva { get; set; }

    public double MontoIva { get; set; }

    public double MontoCeec { get; set; }

    public double MontoCeecUf { get; set; }

    public double TasaDesc { get; set; }
}
