﻿using System;
using System.Collections.Generic;

namespace BienFritoWebApp.Models;

public partial class DetallePedido
{
    public int DetalleId { get; set; }

    public int PedidoId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual Pedido Pedido { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}