using CadMinerva;
using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var producto = new Producto();
            producto.codigo = txtCodigo.Text.Trim();
            producto.descripcion = txtCodigo.Text.Trim();
            producto.unidadMedida = cbxUnidadMedida.Text;
            producto.saldo = nudSaldo.Value;
            producto.precioVenta = nudPrecioVenta.Value;
            producto.usuarioRegistro = "noel";
            producto.fechaRegistro = DateTime.Now;
            producto.registroActivo = true;

            int id = ProductoCln.insertar(producto);
            MessageBox.Show($"Producto insertado con id: {id}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
