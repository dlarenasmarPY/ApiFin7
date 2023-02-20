using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoNominasCf
{
    public decimal NomGfaId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PInsParCcafId { get; set; }

    public DateTime NomGfaFecha { get; set; }

    public int NomGfaNumero { get; set; }

    public byte NomGfaTipoMovto { get; set; }

    public string NomGfaRuta { get; set; } = null!;

    public string NomGfaArchivo { get; set; } = null!;

    public decimal PIcFseqId { get; set; }

    public decimal PItmNomGfaEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual RhuTParInterfaz PIcFseq { get; set; } = null!;

    public virtual RhuTParInstitucione PInsParCcaf { get; set; } = null!;

    public virtual RhuTParItem PItmNomGfaEstadoNavigation { get; set; } = null!;

    public virtual ICollection<RhuTCtoNominasCfdet> RhuTCtoNominasCfdets { get; } = new List<RhuTCtoNominasCfdet>();

    public virtual ICollection<RhuTCtoTmpNomina> RhuTCtoTmpNominas { get; } = new List<RhuTCtoTmpNomina>();
}
