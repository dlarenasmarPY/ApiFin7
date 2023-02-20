using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTHomologaNominaPago
{
    public decimal FormatoHomologaId { get; set; }

    public int PCodFormatoNomina { get; set; }

    public string AtributoHomologa { get; set; } = null!;

    public string ValorNomina { get; set; } = null!;

    public string ValorCliente { get; set; } = null!;
}
