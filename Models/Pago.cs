using System;
using System.Collections.Generic;

namespace BienFritoWebApp.Models;

public partial class Pago
{
    public int PagoId { get; set; }

    public int PedidoId { get; set; }

    public decimal Monto { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? MetodoPago { get; set; }

    public string? Estado { get; set; }

    public virtual Pedido Pedido { get; set; } = null!;
}
