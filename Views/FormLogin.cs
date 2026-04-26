using System;
using System.Windows.Forms;
using RIVEROSCRUZ_PATITASFELICES.Controllers;
using RIVEROSCRUZ_PATITASFELICES.Models;

namespace RIVEROSCRUZ_PATITASFELICES.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            try
            {
                Usuario usuario = controller.ValidarLogin(txtUsuario.Text, txtClave.Text);
                if (usuario.Rol == "admin")
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                    this.Hide();
                }
                else if (usuario.Rol == "cliente")
                {
                    FormReserva formReserva = new FormReserva();
                    formReserva.Show();
                    this.Hide();
                }
            }
            catch (ArgumentException ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
