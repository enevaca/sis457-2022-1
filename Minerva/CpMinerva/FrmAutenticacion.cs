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
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();

            //var empleado = new Empleado();
            //empleado.cedulaIdentidad = "123456";
            //empleado.nombre = "Noel";
            //empleado.paterno = "Vaca";
            //empleado.materno = "Moreno";
            //empleado.direccion = "Calle Loa N° 777";
            //empleado.celular = 76862782;
            //empleado.cargo = "Administrador";
            //empleado.usuarioRegistro = "sa";
            //empleado.fechaRegistro = DateTime.Now;
            //empleado.registroActivo = true;
            //int idEmpleado = EmpleadoCln.insertar(empleado);

            //var usuario = new Usuario();
            //usuario.usuario = "noel";
            //usuario.clave = Util.Encrypt("hola1234.");
            //usuario.idEmpleado = idEmpleado;
            //usuario.usuarioRegistro = "sa";
            //usuario.fechaRegistro = DateTime.Now;
            //usuario.registroActivo = true;
            //UsuarioCln.insertar(usuario);
        }

        private bool validar() 
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");

            if (string.IsNullOrEmpty(txtUsuario.Text)) {
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text)) {
                erpClave.SetError(txtClave, "El campo Contraseña es obligatorio");
                esValido = false;
            }
            return esValido;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string usuario = txtUsuario.Text.Trim();
                string clave = Util.Encrypt(txtClave.Text.Trim());
                var usuarioExistente = UsuarioCln.validar(usuario, clave);
                if (usuarioExistente != null)
                {
                    Util.usuario = usuarioExistente;
                    txtClave.Text = string.Empty;
                    txtUsuario.SelectAll();
                    Visible = false;
                    new FrmPrincipal(this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto", "::: Mensaje - Minerva :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIngresar.PerformClick();
        }
    }
}
