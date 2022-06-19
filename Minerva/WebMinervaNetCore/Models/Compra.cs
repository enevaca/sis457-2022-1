﻿using System;
using System.Collections.Generic;

namespace WebMinervaNetCore.Models
{
    public partial class Compra
    {
        public Compra()
        {
            CompraDetalles = new HashSet<CompraDetalle>();
        }

        public int Id { get; set; }
        public int Transaccion { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProveedor { get; set; }
        public string? UsuarioRegistro { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? RegistroActivo { get; set; }

        public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
        public virtual ICollection<CompraDetalle> CompraDetalles { get; set; }
    }
}
