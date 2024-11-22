using System;
using System.Collections.Generic;

namespace BienFritoWebApp.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public int ClienteId { get; set; }

    public DateTime? FechaPedido { get; set; }

    public string? Estado { get; set; }

    public decimal? Total { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual ICollection<EstadosPedido> EstadosPedidos { get; set; } = new List<EstadosPedido>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
