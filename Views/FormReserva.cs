using System;
using System.Drawing;
using System.Windows.Forms;
using RIVEROSCRUZ_PATITASFELICES.Controllers;
using RIVEROSCRUZ_PATITASFELICES.Models;

namespace RIVEROSCRUZ_PATITASFELICES.Views
{
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Agendamiento agendamiento = new Agendamiento();
            agendamiento.NombreDueno = txtNombreDueno.Text;
            agendamiento.Telefono = txtTelefono.Text;
            agendamiento.Correo = txtCorreo.Text;
            agendamiento.NombreMascota = txtNombreMascota.Text;
            agendamiento.TipoMascota = txtTipoMascota.Text;
            agendamiento.MotivoConsulta = txtMotivo.Text;
            agendamiento.FechaAtencion = dtpFecha.Value.Date;
            agendamiento.HoraAtencion = dtpHora.Value.TimeOfDay;
            agendamiento.Estado = "Pendiente";

            int edad;
            if (!int.TryParse(txtEdadMascota.Text, out edad))
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "La edad debe ser un numero";
                lblMensaje.Visible = true;
                return;
            }
            agendamiento.EdadMascota = edad;

            try
            {
                AgendamientoController controller = new AgendamientoController();
                controller.Insertar(agendamiento);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Reserva registrada exitosamente";
                lblMensaje.Visible = true;
                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombreDueno.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtNombreMascota.Text = "";
            txtTipoMascota.Text = "";
            txtEdadMascota.Text = "";
            txtMotivo.Text = "";
            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Today;
        }
    }
}
