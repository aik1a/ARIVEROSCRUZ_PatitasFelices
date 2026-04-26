using System;
using System.Drawing;
using System.Windows.Forms;
using RIVEROSCRUZ_PATITASFELICES.Controllers;
using RIVEROSCRUZ_PATITASFELICES.Models;

namespace RIVEROSCRUZ_PATITASFELICES.Views
{
    public partial class FormAdmin : Form
    {
        private AgendamientoController controller = new AgendamientoController();

        public FormAdmin()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvAgendamientos.DataSource = null;
            dgvAgendamientos.DataSource = controller.GetAll();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltroEstado.SelectedItem.ToString();
            if (filtro == "Todos")
            {
                dgvAgendamientos.DataSource = null;
                dgvAgendamientos.DataSource = controller.GetAll();
            }
            else
            {
                dgvAgendamientos.DataSource = null;
                dgvAgendamientos.DataSource = controller.GetByEstado(filtro);
            }
        }

        private void dgvAgendamientos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAgendamientos.CurrentRow == null) return;
            DataGridViewRow fila = dgvAgendamientos.CurrentRow;
            if (fila.Cells["NombreDueno"].Value == null) return;

            txtNombreDueno.Text = fila.Cells["NombreDueno"].Value.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtNombreMascota.Text = fila.Cells["NombreMascota"].Value.ToString();
            txtTipoMascota.Text = fila.Cells["TipoMascota"].Value.ToString();
            txtEdadMascota.Text = fila.Cells["EdadMascota"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaAtencion"].Value);
            dtpHora.Value = DateTime.Today.Add((TimeSpan)fila.Cells["HoraAtencion"].Value);
            txtMotivo.Text = fila.Cells["MotivoConsulta"].Value.ToString();
            cmbEstado.SelectedItem = fila.Cells["Estado"].Value.ToString();
        }

        private Agendamiento ObtenerAgendamientoDesdeCampos()
        {
            Agendamiento a = new Agendamiento();
            a.NombreDueno = txtNombreDueno.Text;
            a.Telefono = txtTelefono.Text;
            a.Correo = txtCorreo.Text;
            a.NombreMascota = txtNombreMascota.Text;
            a.TipoMascota = txtTipoMascota.Text;
            a.MotivoConsulta = txtMotivo.Text;
            a.FechaAtencion = dtpFecha.Value.Date;
            a.HoraAtencion = dtpHora.Value.TimeOfDay;

            int edad;
            if (!int.TryParse(txtEdadMascota.Text, out edad))
                throw new ArgumentException("La edad debe ser un numero");
            a.EdadMascota = edad;

            return a;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamiento a = ObtenerAgendamientoDesdeCampos();
                a.Estado = cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : "Pendiente";
                controller.Insertar(a);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Registro insertado exitosamente";
                lblMensaje.Visible = true;
                CargarDatos();
            }
            catch (ArgumentException ex)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvAgendamientos.CurrentRow == null) return;
            try
            {
                Agendamiento a = ObtenerAgendamientoDesdeCampos();
                a.IdAgendamiento = Convert.ToInt32(dgvAgendamientos.CurrentRow.Cells["IdAgendamiento"].Value);
                a.Estado = cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : "Pendiente";
                controller.Actualizar(a);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Registro actualizado exitosamente";
                lblMensaje.Visible = true;
                CargarDatos();
            }
            catch (ArgumentException ex)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = ex.Message;
                lblMensaje.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAgendamientos.CurrentRow == null) return;
            DialogResult respuesta = MessageBox.Show("Desea eliminar esta reserva?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvAgendamientos.CurrentRow.Cells["IdAgendamiento"].Value);
                controller.Eliminar(id);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Registro eliminado exitosamente";
                lblMensaje.Visible = true;
                CargarDatos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}
