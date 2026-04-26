namespace RIVEROSCRUZ_PATITASFELICES.Views
{
    partial class FormReserva
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNombreDueno;
        private System.Windows.Forms.TextBox txtNombreDueno;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label lblTipoMascota;
        private System.Windows.Forms.TextBox txtTipoMascota;
        private System.Windows.Forms.Label lblEdadMascota;
        private System.Windows.Forms.TextBox txtEdadMascota;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMensaje;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombreDueno = new System.Windows.Forms.Label();
            this.txtNombreDueno = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.lblTipoMascota = new System.Windows.Forms.Label();
            this.txtTipoMascota = new System.Windows.Forms.TextBox();
            this.lblEdadMascota = new System.Windows.Forms.Label();
            this.txtEdadMascota = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();

            int labelX = 20;
            int inputX = 180;
            int inputW = 230;
            int y = 20;
            int step = 32;

            // Nombre del dueno
            this.lblNombreDueno.AutoSize = true;
            this.lblNombreDueno.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblNombreDueno.Text = "Nombre del dueno:";
            this.txtNombreDueno.Location = new System.Drawing.Point(inputX, y);
            this.txtNombreDueno.Size = new System.Drawing.Size(inputW, 22);
            y += step;

            // Telefono
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblTelefono.Text = "Telefono:";
            this.txtTelefono.Location = new System.Drawing.Point(inputX, y);
            this.txtTelefono.Size = new System.Drawing.Size(inputW, 22);
            y += step;

            // Correo
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblCorreo.Text = "Correo:";
            this.txtCorreo.Location = new System.Drawing.Point(inputX, y);
            this.txtCorreo.Size = new System.Drawing.Size(inputW, 22);
            y += step;

            // Nombre de la mascota
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblNombreMascota.Text = "Nombre de la mascota:";
            this.txtNombreMascota.Location = new System.Drawing.Point(inputX, y);
            this.txtNombreMascota.Size = new System.Drawing.Size(inputW, 22);
            y += step;

            // Tipo de mascota
            this.lblTipoMascota.AutoSize = true;
            this.lblTipoMascota.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblTipoMascota.Text = "Tipo de mascota:";
            this.txtTipoMascota.Location = new System.Drawing.Point(inputX, y);
            this.txtTipoMascota.Size = new System.Drawing.Size(inputW, 22);
            y += step;

            // Edad de la mascota
            this.lblEdadMascota.AutoSize = true;
            this.lblEdadMascota.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblEdadMascota.Text = "Edad de la mascota:";
            this.txtEdadMascota.Location = new System.Drawing.Point(inputX, y);
            this.txtEdadMascota.Size = new System.Drawing.Size(inputW, 22);
            y += step;

            // Fecha de atencion
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblFecha.Text = "Fecha de atencion:";
            this.dtpFecha.Location = new System.Drawing.Point(inputX, y);
            this.dtpFecha.Size = new System.Drawing.Size(inputW, 22);
            this.dtpFecha.MinDate = System.DateTime.Today;
            y += step;

            // Hora de atencion
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblHora.Text = "Hora de atencion:";
            this.dtpHora.Location = new System.Drawing.Point(inputX, y);
            this.dtpHora.Size = new System.Drawing.Size(inputW, 22);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.ShowUpDown = true;
            y += step;

            // Motivo de consulta
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblMotivo.Text = "Motivo de consulta:";
            this.txtMotivo.Location = new System.Drawing.Point(inputX, y);
            this.txtMotivo.Size = new System.Drawing.Size(inputW, 60);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Height = 60;
            y += 70;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(inputX, y);
            this.btnGuardar.Size = new System.Drawing.Size(140, 30);
            this.btnGuardar.Text = "Guardar Reserva";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(inputX + 150, y);
            this.btnSalir.Size = new System.Drawing.Size(80, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            y += 40;

            // lblMensaje
            this.lblMensaje.AutoSize = false;
            this.lblMensaje.Location = new System.Drawing.Point(20, y);
            this.lblMensaje.Size = new System.Drawing.Size(400, 20);
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            this.lblMensaje.Text = "";

            // FormReserva
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 520);
            this.Controls.Add(this.lblNombreDueno);
            this.Controls.Add(this.txtNombreDueno);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblNombreMascota);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.lblTipoMascota);
            this.Controls.Add(this.txtTipoMascota);
            this.Controls.Add(this.lblEdadMascota);
            this.Controls.Add(this.txtEdadMascota);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMensaje);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patitas Felices - Nueva Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
