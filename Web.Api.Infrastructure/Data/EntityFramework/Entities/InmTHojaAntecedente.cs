using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTHojaAntecedente
{
    public decimal PEntId { get; set; }

    public DateTime FechaNacTitular { get; set; }

    public string DireccionTitular { get; set; } = null!;

    public int CmuCodigoTitular { get; set; }

    public string CmuCiudadTitular { get; set; } = null!;

    public string TelefonoTitular { get; set; } = null!;

    public double AntiguedadLabTitular { get; set; }

    public string ProfesionTitular { get; set; } = null!;

    public string EmpleadorTitular { get; set; } = null!;

    public string TelefonoEmpTitular { get; set; } = null!;

    public double RentaLiquidaTitular { get; set; }

    public short CodRegConyugalTitular { get; set; }

    public short CodEstCivilTitular { get; set; }

    public string RutConyuge { get; set; } = null!;

    public DateTime FechaNacConyuge { get; set; }

    public string DireccionConyuge { get; set; } = null!;

    public int CmuCodigoConyuge { get; set; }

    public string CmuCiudadConyuge { get; set; } = null!;

    public string ProfesionConyuge { get; set; } = null!;

    public string EmpleadorConyuge { get; set; } = null!;

    public string TelefonoEmpConyuge { get; set; } = null!;

    public double AntiguedadLabConyuge { get; set; }

    public double RentaLiquidaConyuge { get; set; }

    public string RutTitular2 { get; set; } = null!;

    public DateTime FechaNacTitular2 { get; set; }

    public string ProfesionTitular2 { get; set; } = null!;

    public string EmpleadorTitular2 { get; set; } = null!;

    public string TelefonoEmpTitular2 { get; set; } = null!;

    public double AntiguedadLabTitular2 { get; set; }

    public double RentaLiquidaTitular2 { get; set; }

    public short CodRegConyugalTitular2 { get; set; }

    public short CodEstCivilTitular2 { get; set; }

    public byte DocEstado { get; set; }

    public DateTime FechaRechazo { get; set; }

    public string MotivoRechazo { get; set; } = null!;

    public string FaxTitular { get; set; } = null!;

    public string EmailTitular { get; set; } = null!;

    public string CelularTitular { get; set; } = null!;

    public string TelefonoConyuge { get; set; } = null!;

    public string FaxConyuge { get; set; } = null!;

    public string EmailConyuge { get; set; } = null!;

    public string CelularConyuge { get; set; } = null!;

    public string TelefonoTitular2 { get; set; } = null!;

    public string FaxTitular2 { get; set; } = null!;

    public string EmailTitular2 { get; set; } = null!;

    public string CelularTitular2 { get; set; } = null!;

    public string RutConyuge2 { get; set; } = null!;

    public DateTime FechaNacConyuge2 { get; set; }

    public string ProfesionConyuge2 { get; set; } = null!;

    public string EmpleadorConyuge2 { get; set; } = null!;

    public string TelefonoEmpConyuge2 { get; set; } = null!;

    public double AntiguedadLabConyuge2 { get; set; }

    public double RentaLiquidaConyuge2 { get; set; }

    public string TelefonoConyuge2 { get; set; } = null!;

    public string FaxConyuge2 { get; set; } = null!;

    public string EmailConyuge2 { get; set; } = null!;

    public string CelularConyuge2 { get; set; } = null!;

    public byte IndComRentaTit { get; set; }

    public byte IndComRentaTit2 { get; set; }

    public short CategoriaId { get; set; }

    public string Nacionalidad { get; set; } = null!;

    public byte NumeroHijos { get; set; }

    public byte GrupoFamiliar { get; set; }

    public byte DesComId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string RutEmpresaComp { get; set; } = null!;

    public string TelefonoEmpresaComp { get; set; } = null!;

    public string FaxEmpresaComp { get; set; } = null!;

    public string EmailEmpresaComp { get; set; } = null!;

    public string RutEmpresaRepLeg { get; set; } = null!;

    public string RutTitularRepLeg { get; set; } = null!;

    public string ProfesionEmpComp { get; set; } = null!;

    public short CategoriaIdEmpComp { get; set; }

    public string CiudadEmpresaComp { get; set; } = null!;

    public string RutEmpresaCompRleg2 { get; set; } = null!;

    public string RutEmpresaCompRleg3 { get; set; } = null!;

    public string RutCoTitular { get; set; } = null!;

    public DateTime FechaNacCotitular { get; set; }

    public string ProfesionCotitular { get; set; } = null!;

    public string EmpleadorCotitular { get; set; } = null!;

    public string TelefonoEmpCotitular { get; set; } = null!;

    public double AntiguedadLabCotitular { get; set; }

    public double RentaLiquidaCotitular { get; set; }

    public string TelefonoCotitular { get; set; } = null!;

    public string FaxCotitular { get; set; } = null!;

    public string EmailCotitular { get; set; } = null!;

    public string CelularCotitular { get; set; } = null!;
}
