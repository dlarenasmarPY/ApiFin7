using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpCertRentum
{
    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public string PerMes { get; set; } = null!;

    public int NumCert { get; set; }

    public double FactorAmort { get; set; }

    public double AuxRentaBruta { get; set; }

    public double AuxRentaBruta1 { get; set; }

    public double AuxRentaBruta2 { get; set; }

    public double AuxRetencionImp { get; set; }

    public double AuxRetencionImp1 { get; set; }

    public double AuxRetencionImp2 { get; set; }

    public short UblId { get; set; }

    public byte MonNroDec { get; set; }

    public byte MonNroDecConv { get; set; }

    public double RetActHono { get; set; }

    public double RetActPart { get; set; }

    public double RentaHono { get; set; }

    public double RentaPart { get; set; }

    public string CerOwner { get; set; } = null!;

    public byte? Mes { get; set; }
}
