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
    public partial class FrmProducto : Form
    {
        bool esNuevo;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(1033, 372);
        }

        private void listar()
        {
            var lista = ProductoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvLista.Columns["saldo"].HeaderText = "Saldo";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";

            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
            if (lista.Count > 0) dgvLista.Rows[0].Cells["codigo"].Selected = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(1033, 585);
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(1033, 585);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var producto = ProductoCln.get(id);

            txtCodigo.Text = producto.codigo;
            txtDescripcion.Text = producto.descripcion;
            cbxUnidadMedida.Text = producto.unidadMedida;
            nudSaldo.Value = producto.saldo;
            nudPrecioVenta.Value = producto.precioVenta;
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"Está seguro que sea dar de baja el Producto con código {codigo}", "::: Mensaje - Minerva ::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ProductoCln.eliminar(id, Util.usuario.usuario);
                listar();
                MessageBox.Show($"Producto dado de baja correctamente", "::: Mensaje - Minerva ::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(1033, 372);
            limpiar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
                guardar();
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpCodigo.SetError(txtCodigo, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpSaldo.SetError(nudSaldo, "");
            erpPrecioVenta.SetError(nudPrecioVenta, "");

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(nudSaldo.Text))
            {
                erpSaldo.SetError(nudSaldo, "El campo Saldo es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(nudPrecioVenta.Text))
            {
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta es obligatorio");
                esValido = false;
            }
            if (nudPrecioVenta.Value <= 0)
            {
                erpPrecioVenta.SetError(nudPrecioVenta, "El campo Precio de Venta debe ser mayor a Cero");
                esValido = false;
            }
            return esValido;
        }

        private void guardar()
        {
            var producto = new Producto();
            producto.codigo = txtCodigo.Text.Trim();
            producto.descripcion = txtDescripcion.Text.Trim();
            producto.unidadMedida = cbxUnidadMedida.Text;
            producto.saldo = nudSaldo.Value;
            producto.precioVenta = nudPrecioVenta.Value;
            producto.usuarioRegistro = Util.usuario.usuario;
            producto.fechaRegistro = DateTime.Now;

            if (esNuevo)
            {
                producto.registroActivo = true;
                ProductoCln.insertar(producto);
            }
            else
            {
                int index = dgvLista.CurrentCell.RowIndex;
                producto.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                ProductoCln.actualizar(producto);
            }

            btnCancelar.PerformClick();
            listar();

            dgvLista.Rows[dgvLista.Rows.Count - 1].Selected = true; // Separar con búsqueda
            MessageBox.Show($"Producto guardado correctamente", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiar()
        {
            txtCodigo.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            cbxUnidadMedida.Text = String.Empty;
            nudSaldo.Text = String.Empty;
            nudPrecioVenta.Text = String.Empty;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Util.onlyLetters(sender, e);
        }
    }
}
