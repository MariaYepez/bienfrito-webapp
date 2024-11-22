using System;
using System.Collections.Generic;

namespace BienFritoWebApp.Models;

public partial class EstadosPedido
{
    public int EstadoId { get; set; }

    public int PedidoId { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public virtual Pedido Pedido { get; set; } = null!;
}
