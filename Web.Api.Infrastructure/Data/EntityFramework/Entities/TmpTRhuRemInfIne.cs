using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemInfIne
{
    public decimal IneinfId { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public string EntRut { get; set; } = null!;

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public string Inesexo { get; set; } = null!;

    public string InetipoContrato { get; set; } = null!;

    public byte Inecuadro { get; set; }

    public byte InecodCmo { get; set; }

    public double InesueldoBaseFijoSem { get; set; }

    public double IneotrosSueldoBasPer { get; set; }

    public double InesueldosSalariosFuncOc { get; set; }

    public double IneincentivosPremiosPagTrab { get; set; }

    public double InepagosTratoTrabEntidad { get; set; }

    public double InepagosHorasExtr { get; set; }

    public double InecomPagPorVentas { get; set; }

    public double InereemGasTrabGasTrab { get; set; }

    public double InepartGratAdiNoMens { get; set; }

    public double InepagEspeciesVivTra { get; set; }

    public double InesubTraspPorEmpleador { get; set; }

    public double InepagDirecTrabSegSoc { get; set; }

    public double IneaportesPatrSegTrab { get; set; }

    public double InegasServBienCap { get; set; }

    public double IneindemTermRelac { get; set; }

    public double IneotrosCostosManoObra { get; set; }

    public double InededucLegOblig { get; set; }

    public double InehorasOrdinarias { get; set; }

    public double InehorasExtraOrdinarias { get; set; }

    public double InedesvinculadosEmpresa { get; set; }

    public double InenuevoContratoEmpresa { get; set; }

    public double InelicenciaEmpresa { get; set; }

    public double Inehonorario { get; set; }

    public double Inesubcontratados { get; set; }
}
