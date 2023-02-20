using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTTablaDato
{
    public string BitFicArchivo { get; set; } = null!;

    public short BitFicLinea { get; set; }

    public string IdFuncionUlt { get; set; } = null!;

    public string Rut { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string ApellidoMaterno { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public int LugarNacimiento { get; set; }

    public short Nacionalidad { get; set; }

    public short EstadoCivil { get; set; }

    public short Profesion { get; set; }

    public short NivelLaboral { get; set; }

    public string Direccion { get; set; } = null!;

    public byte RegCodigo { get; set; }

    public int CmuCodigo { get; set; }

    public int CiuCodigo { get; set; }

    public string Telefono { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string Email { get; set; } = null!;

    public short OrigenCurr { get; set; }

    public short Disponibilidad { get; set; }

    public byte FicIndRecomendado { get; set; }

    public string FicEntRazonSocial { get; set; } = null!;

    public short TipoCotizacion { get; set; }

    public string PreIndPrevisional { get; set; } = null!;

    public short CajaAntigua { get; set; }

    public byte PreIndJubilado { get; set; }

    public short MotivoPension { get; set; }

    public int PreMesCotizados { get; set; }

    public string TraCodTramo { get; set; } = null!;

    public int PreNumCargasNor { get; set; }

    public int PreNumCargasInv { get; set; }

    public int PreNumCargasEsp { get; set; }

    public int PreNumCargasCorr { get; set; }

    public int PreNumGrupoFam { get; set; }

    public DateTime AfpFecPrimeraAfi { get; set; }

    public string AfpFun { get; set; } = null!;

    public DateTime AfpFecContratoFun { get; set; }

    public DateTime AfpFecRecepcion { get; set; }

    public string RutAfp { get; set; } = null!;

    public byte MonedaVolum { get; set; }

    public decimal AfpVoluntario { get; set; }

    public byte MonedaAhorro { get; set; }

    public decimal AfpAhorro { get; set; }

    public string RutAfc { get; set; } = null!;

    public DateTime SalFecPrimeraAfi { get; set; }

    public string SalFun { get; set; } = null!;

    public DateTime SalFecContratoFun { get; set; }

    public DateTime SalFecRecepcion { get; set; }

    public string RutIsa { get; set; } = null!;

    public byte MonedaAuge { get; set; }

    public double SalAuge { get; set; }

    public byte MonedaSalud { get; set; }

    public decimal SalPlan { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short TipoContrato { get; set; }

    public DateTime FechaContrato { get; set; }

    public DateTime CtoFecRenovacion { get; set; }

    public short TipoRenta { get; set; }

    public short TipoImpuesto { get; set; }

    public string Cargo { get; set; } = null!;

    public short CtoJornada { get; set; }

    public short DistriJornada { get; set; }

    public byte CtoIndSegCes { get; set; }

    public short Calidadjuridica { get; set; }

    public short Categoria { get; set; }

    public short GrupoConta { get; set; }

    public short LugarTrabajo { get; set; }

    public short LugarPago { get; set; }

    public int CreCodigo { get; set; }

    public decimal FormaPago { get; set; }

    public short Banco { get; set; }

    public short EntSucInstSuc { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public short LugarIntegro { get; set; }

    public double Sueldobase { get; set; }

    public byte CtoIndMutual { get; set; }

    public string RutMutual { get; set; } = null!;

    public decimal PMutualEntSucId { get; set; }
}
