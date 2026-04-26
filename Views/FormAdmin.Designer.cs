namespace RIVEROSCRUZ_PATITASFELICES.Views
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvAgendamientos;

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
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
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
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvAgendamientos = new System.Windows.Forms.DataGridView();

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
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();

            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamientos)).BeginInit();
            this.SuspendLayout();

            // SECCION SUPERIOR
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(20, 18);
            this.lblFiltro.Text = "Filtrar por estado:";

            this.cmbFiltroEstado.Location = new System.Drawing.Point(140, 15);
            this.cmbFiltroEstado.Size = new System.Drawing.Size(160, 22);
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Confirmada", "Atendida", "Cancelada" });
            this.cmbFiltroEstado.SelectedIndex = 0;
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);

            this.btnCargar.Location = new System.Drawing.Point(320, 13);
            this.btnCargar.Size = new System.Drawing.Size(140, 28);
            this.btnCargar.Text = "Cargar Registros";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);

            this.dgvAgendamientos.Location = new System.Drawing.Point(20, 50);
            this.dgvAgendamientos.Size = new System.Drawing.Size(850, 250);
            this.dgvAgendamientos.ReadOnly = true;
            this.dgvAgendamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgendamientos.MultiSelect = false;
            this.dgvAgendamientos.AllowUserToAddRows = false;
            this.dgvAgendamientos.AllowUserToDeleteRows = false;
            this.dgvAgendamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgendamientos.SelectionChanged += new System.EventHandler(this.dgvAgendamientos_SelectionChanged);

            // SECCION INFERIOR
            int colALabel = 20;
            int colAInput = 170;
            int colBLabel = 460;
            int colBInput = 610;
            int inputW = 250;
            int yStart = 320;
            int step = 32;

            // Columna A
            int yA = yStart;
            this.lblNombreDueno.AutoSize = true;
            this.lblNombreDueno.Location = new System.Drawing.Point(colALabel, yA + 3);
            this.lblNombreDueno.Text = "Nombre del dueno:";
            this.txtNombreDueno.Location = new System.Drawing.Point(colAInput, yA);
            this.txtNombreDueno.Size = new System.Drawing.Size(inputW, 22);
            yA += step;

            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(colALabel, yA + 3);
            this.lblTelefono.Text = "Telefono:";
            this.txtTelefono.Location = new System.Drawing.Point(colAInput, yA);
            this.txtTelefono.Size = new System.Drawing.Size(inputW, 22);
            yA += step;

            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(colALabel, yA + 3);
            this.lblCorreo.Text = "Correo:";
            this.txtCorreo.Location = new System.Drawing.Point(colAInput, yA);
            this.txtCorreo.Size = new System.Drawing.Size(inputW, 22);
            yA += step;

            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Location = new System.Drawing.Point(colALabel, yA + 3);
            this.lblNombreMascota.Text = "Nombre de la mascota:";
            this.txtNombreMascota.Location = new System.Drawing.Point(colAInput, yA);
            this.txtNombreMascota.Size = new System.Drawing.Size(inputW, 22);
            yA += step;

            this.lblTipoMascota.AutoSize = true;
            this.lblTipoMascota.Location = new System.Drawing.Point(colALabel, yA + 3);
            this.lblTipoMascota.Text = "Tipo de mascota:";
            this.txtTipoMascota.Location = new System.Drawing.Point(colAInput, yA);
            this.txtTipoMascota.Size = new System.Drawing.Size(inputW, 22);
            yA += step;

            // Columna B
            int yB = yStart;
            this.lblEdadMascota.AutoSize = true;
            this.lblEdadMascota.Location = new System.Drawing.Point(colBLabel, yB + 3);
            this.lblEdadMascota.Text = "Edad de la mascota:";
            this.txtEdadMascota.Location = new System.Drawing.Point(colBInput, yB);
            this.txtEdadMascota.Size = new System.Drawing.Size(inputW, 22);
            yB += step;

            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(colBLabel, yB + 3);
            this.lblFecha.Text = "Fecha de atencion:";
            this.dtpFecha.Location = new System.Drawing.Point(colBInput, yB);
            this.dtpFecha.Size = new System.Drawing.Size(inputW, 22);
            this.dtpFecha.MinDate = System.DateTime.Today;
            yB += step;

            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(colBLabel, yB + 3);
            this.lblHora.Text = "Hora de atencion:";
            this.dtpHora.Location = new System.Drawing.Point(colBInput, yB);
            this.dtpHora.Size = new System.Drawing.Size(inputW, 22);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.ShowUpDown = true;
            yB += step;

            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(colBLabel, yB + 3);
            this.lblEstado.Text = "Estado:";
            this.cmbEstado.Location = new System.Drawing.Point(colBInput, yB);
            this.cmbEstado.Size = new System.Drawing.Size(inputW, 22);
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] { "Pendiente", "Confirmada", "Atendida", "Cancelada" });
            yB += step;

            // Motivo (debajo, ancho completo)
            int yMotivo = System.Math.Max(yA, yB) + 5;
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(colALabel, yMotivo + 3);
            this.lblMotivo.Text = "Motivo de consulta:";
            this.txtMotivo.Location = new System.Drawing.Point(colAInput, yMotivo);
            this.txtMotivo.Size = new System.Drawing.Size(690, 50);
            this.txtMotivo.Multiline = true;
            yMotivo += 60;

            // Botones
            int yBtn = yMotivo + 10;
            this.btnInsertar.Location = new System.Drawing.Point(170, yBtn);
            this.btnInsertar.Size = new System.Drawing.Size(110, 30);
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);

            this.btnActualizar.Location = new System.Drawing.Point(290, yBtn);
            this.btnActualizar.Size = new System.Drawing.Size(110, 30);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(410, yBtn);
            this.btnEliminar.Size = new System.Drawing.Size(110, 30);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.btnSalir.Location = new System.Drawing.Point(770, yBtn);
            this.btnSalir.Size = new System.Drawing.Size(90, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // Mensaje
            int yMsg = yBtn + 40;
            this.lblMensaje.AutoSize = false;
            this.lblMensaje.Location = new System.Drawing.Point(20, yMsg);
            this.lblMensaje.Size = new System.Drawing.Size(850, 20);
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            this.lblMensaje.Text = "";

            // FormAdmin
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 670);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cmbFiltroEstado);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvAgendamientos);
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
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMensaje);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Text = "Patitas Felices - Panel de Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
